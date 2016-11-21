/*
 * Created by SharpDevelop.
 * User: ky024810
 * Date: 1/28/2016
 * Time: 5:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace emgu_video
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
            if(vw!=null)
            vw.Dispose();
            if(cap!=null)
            cap.Dispose();
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.track_playPosition = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_frameRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nextFrame = new System.Windows.Forms.Button();
            this.btn_preFrame = new System.Windows.Forms.Button();
            this.lb_frameCount = new System.Windows.Forms.Label();
            this.btn_startRender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_playPosition)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Silver;
            this.imageBox1.Location = new System.Drawing.Point(10, 28);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(608, 345);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
      
            this.imageBox1.DoubleClick += new System.EventHandler(this.ImageBox1DoubleClick);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play.Location = new System.Drawing.Point(691, 31);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(62, 31);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.Btn_playClick);
            // 
            // track_playPosition
            // 
            this.track_playPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.track_playPosition.BackColor = System.Drawing.SystemColors.Control;
            this.track_playPosition.Location = new System.Drawing.Point(0, 379);
            this.track_playPosition.Name = "track_playPosition";
            this.track_playPosition.Size = new System.Drawing.Size(618, 45);
            this.track_playPosition.TabIndex = 8;
            this.track_playPosition.Scroll += new System.EventHandler(this.Track_playPositionScroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_frameRate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(622, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "play speed";
            // 
            // lb_frameRate
            // 
            this.lb_frameRate.Location = new System.Drawing.Point(12, 48);
            this.lb_frameRate.Name = "lb_frameRate";
            this.lb_frameRate.Size = new System.Drawing.Size(54, 19);
            this.lb_frameRate.TabIndex = 13;
            this.lb_frameRate.Text = "30";
            this.lb_frameRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(9, 14);
            this.trackBar1.Maximum = 333;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(116, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 33;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.Location = new System.Drawing.Point(622, 32);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(66, 30);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_openClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_nextFrame);
            this.groupBox2.Controls.Add(this.btn_preFrame);
            this.groupBox2.Controls.Add(this.lb_frameCount);
            this.groupBox2.Location = new System.Drawing.Point(623, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 93);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame";
            // 
            // btn_nextFrame
            // 
            this.btn_nextFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nextFrame.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nextFrame.Location = new System.Drawing.Point(68, 52);
            this.btn_nextFrame.Name = "btn_nextFrame";
            this.btn_nextFrame.Size = new System.Drawing.Size(60, 30);
            this.btn_nextFrame.TabIndex = 10;
            this.btn_nextFrame.Text = ">";
            this.btn_nextFrame.UseVisualStyleBackColor = false;
            this.btn_nextFrame.Click += new System.EventHandler(this.Btn_nextFrameClick);
            // 
            // btn_preFrame
            // 
            this.btn_preFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_preFrame.BackColor = System.Drawing.SystemColors.Control;
            this.btn_preFrame.Location = new System.Drawing.Point(2, 52);
            this.btn_preFrame.Name = "btn_preFrame";
            this.btn_preFrame.Size = new System.Drawing.Size(63, 30);
            this.btn_preFrame.TabIndex = 9;
            this.btn_preFrame.Text = "<";
            this.btn_preFrame.UseVisualStyleBackColor = false;
            this.btn_preFrame.Click += new System.EventHandler(this.Btn_preFrameClick);
            // 
            // lb_frameCount
            // 
            this.lb_frameCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_frameCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_frameCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_frameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_frameCount.ForeColor = System.Drawing.Color.Yellow;
            this.lb_frameCount.Location = new System.Drawing.Point(2, 19);
            this.lb_frameCount.Name = "lb_frameCount";
            this.lb_frameCount.Size = new System.Drawing.Size(125, 30);
            this.lb_frameCount.TabIndex = 8;
            this.lb_frameCount.Text = "0";
            this.lb_frameCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_startRender
            // 
            this.btn_startRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startRender.Location = new System.Drawing.Point(631, 259);
            this.btn_startRender.Name = "btn_startRender";
            this.btn_startRender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_startRender.Size = new System.Drawing.Size(115, 32);
            this.btn_startRender.TabIndex = 13;
            this.btn_startRender.Text = "start randering";
            this.btn_startRender.UseVisualStyleBackColor = true;
            this.btn_startRender.Click += new System.EventHandler(this.btn_addFrameNo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(765, 420);
            this.Controls.Add(this.btn_startRender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.track_playPosition);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "emgu_video";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_playPosition)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Label lb_frameRate;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TrackBar track_playPosition;
		private System.Windows.Forms.Button btn_nextFrame;
		private System.Windows.Forms.Button btn_preFrame;
		private System.Windows.Forms.Label lb_frameCount;
		private System.Windows.Forms.Button btn_play;
		private System.Windows.Forms.Button btn_open;
		private Emgu.CV.UI.ImageBox imageBox1;
		
		void MainFormPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			imageBox1.Height=this.Height-140;
			imageBox1.Width=this.Width-180;
			
			track_playPosition.Size=new System.Drawing.Size(imageBox1.Width,20);
		}

        private System.Windows.Forms.Button btn_startRender;
    }
}
