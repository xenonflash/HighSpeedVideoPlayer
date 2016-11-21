/*
 * Created by SharpDevelop.
 * User: ky024810
 * Date: 1/28/2016
 * Time: 5:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

namespace emgu_video
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			btn_play.Enabled=false;
			btn_nextFrame.Enabled=false;
			btn_preFrame.Enabled=false;
            btn_startRender.Enabled = false;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Capture cap;
		bool processing=false;
		double  currentPos=0;
		int frameDelay=33;
        int capNum = 0;
        bool rendering = false;
        VideoWriter vw;
        Point textLoc = new Point(5, 40);
        MCvScalar textColor = new MCvScalar(0, 255, 0);

		
		public  delegate void D_updateMsg(object msg);
		
		public  void updateLabel(object msg)
		{
			lb_frameCount.Text=msg.ToString();
		}
		public void updateTrackBar(object pos)
		{
			track_playPosition.Value=Convert.ToInt16(pos);
		}
		
		
		
		void Btn_openClick(object sender, EventArgs e)
		{
			OpenFileDialog op=new OpenFileDialog();
			
			op.ShowDialog();
			string filePath=op.FileName;
			if (filePath!="")
			{
				cap=new Capture(filePath);
				
				cap.ImageGrabbed+=ProcessFrame;

				cap.Grab();
				track_playPosition.Maximum =(int)cap.GetCaptureProperty(CapProp.FrameCount);
				
				
				
			}
			else
			{
				MessageBox.Show("no file selected");
				return;
			}
			btn_play.Enabled=true;
            btn_startRender.Enabled = true;
			
		}
		
		private void ProcessFrame(object sender,EventArgs e)
		{
			D_updateMsg MyUpdateLb= new D_updateMsg(updateLabel);
			D_updateMsg MyUpdateTrack=new D_updateMsg(updateTrackBar);

            Mat frame = new Mat();
            
            
            cap.Retrieve(frame);
            currentPos = cap.GetCaptureProperty(CapProp.PosFrames);
            this.BeginInvoke(MyUpdateLb, currentPos);
            this.BeginInvoke(MyUpdateTrack, currentPos);
            // draw fps string
            if (rendering)
            {

                CvInvoke.PutText(frame, currentPos.ToString(), textLoc, FontFace.HersheySimplex,1.5, textColor, 3);
                vw.Write(frame);
                imageBox1.Image = frame;

            }
            else
            {
             
                imageBox1.Image =frame;
            }

            //delay
            System.Threading.Thread.Sleep(frameDelay);
            Application.DoEvents();
            capNum += 1;
            if (capNum >= 4)
            {
                GC.Collect();
                capNum = 0;
            }
            

        }
	
		void Btn_playClick(object sender, EventArgs e)
		{
			if (processing) 
			{
				cap.Pause();
			
				btn_preFrame.Enabled=true;
				btn_nextFrame.Enabled=true;
				btn_play.Text="play";
			}

			else
			{
				cap.Start();
				
				btn_preFrame.Enabled=false;
				btn_nextFrame.Enabled=false;
				btn_play.Text="pause";
			}
			processing=!processing;			
			
			
			
		}
		
		
		
		void Btn_nextFrameClick(object sender, EventArgs e)
		{
			
			if (currentPos==cap.GetCaptureProperty(CapProp.FrameCount))
			{
				MessageBox.Show("video finished");
			}
			else
			{
				
			cap.Grab();
			}
		}
		
		void Btn_preFrameClick(object sender, EventArgs e)
		{
			
			cap.SetCaptureProperty(CapProp.PosFrames,currentPos-2);
			cap.Grab();
		}
		
		void Track_playPositionScroll(object sender, EventArgs e)
		{
			
			cap.SetCaptureProperty(CapProp.PosFrames,track_playPosition.Value);
			cap.Grab();			
		}
		
		
		
		
		
		void ImageBox1DoubleClick(object sender, EventArgs e)
		{
			Btn_openClick(sender,e);
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			frameDelay=trackBar1.Value;
			lb_frameRate.Text=(1000/(frameDelay+1)).ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			trackBar1.Value=33;
			frameDelay=33;	
			lb_frameRate.Text="30";
			
		}

        private void btn_addFrameNo_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveOp;
            


            if (rendering)
            {

                MessageBox.Show("render finished");
                btn_startRender.Text = "start render";
            }
            else
            {
                MessageBox.Show("please select save path");
                
                saveOp = new SaveFileDialog();
                saveOp.DefaultExt = "avi";
                saveOp.ShowDialog();
                
                vw = new VideoWriter(saveOp.FileName ,25, new Size((int)cap.GetCaptureProperty(CapProp.FrameWidth),(int) cap.GetCaptureProperty(CapProp.FrameHeight)), true);
                
                btn_startRender.Text = "stop render";
            }
            rendering = !rendering;


        }

       
    }
}
