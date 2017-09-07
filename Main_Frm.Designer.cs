namespace AudioTest
{
    partial class Main_Frm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Frm));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label_L = new System.Windows.Forms.Label();
            this.tB_L = new System.Windows.Forms.TextBox();
            this.tB_R = new System.Windows.Forms.TextBox();
            this.label_R = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VolBar = new System.Windows.Forms.TrackBar();
            this.VolTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isSync = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FS = new System.Windows.Forms.TextBox();
            this.FE = new System.Windows.Forms.TextBox();
            this.Fstep = new System.Windows.Forms.TextBox();
            this.Sweep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sweepTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(12, 230);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(77, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "播放";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(95, 230);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label_L
            // 
            this.label_L.AutoSize = true;
            this.label_L.Location = new System.Drawing.Point(31, 32);
            this.label_L.Name = "label_L";
            this.label_L.Size = new System.Drawing.Size(47, 12);
            this.label_L.TabIndex = 2;
            this.label_L.Text = "L（Hz）";
            this.label_L.Click += new System.EventHandler(this.label_L_Click);
            // 
            // tB_L
            // 
            this.tB_L.Location = new System.Drawing.Point(84, 23);
            this.tB_L.Name = "tB_L";
            this.tB_L.Size = new System.Drawing.Size(100, 21);
            this.tB_L.TabIndex = 3;
            this.tB_L.Text = "1000";
            // 
            // tB_R
            // 
            this.tB_R.Location = new System.Drawing.Point(84, 74);
            this.tB_R.Name = "tB_R";
            this.tB_R.Size = new System.Drawing.Size(100, 21);
            this.tB_R.TabIndex = 5;
            this.tB_R.Text = "1000";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(31, 83);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(47, 12);
            this.label_R.TabIndex = 4;
            this.label_R.Text = "R（Hz）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shiniverse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Donated by";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VolBar
            // 
            this.VolBar.LargeChange = 1;
            this.VolBar.Location = new System.Drawing.Point(195, 23);
            this.VolBar.Name = "VolBar";
            this.VolBar.Size = new System.Drawing.Size(243, 45);
            this.VolBar.TabIndex = 8;
            this.VolBar.Value = 10;
            this.VolBar.Scroll += new System.EventHandler(this.VolBar_Scroll);
            // 
            // VolTxt
            // 
            this.VolTxt.AutoSize = true;
            this.VolTxt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolTxt.ForeColor = System.Drawing.Color.Navy;
            this.VolTxt.Location = new System.Drawing.Point(397, 78);
            this.VolTxt.Name = "VolTxt";
            this.VolTxt.Size = new System.Drawing.Size(36, 19);
            this.VolTxt.TabIndex = 9;
            this.VolTxt.Text = "max";
            this.VolTxt.Click += new System.EventHandler(this.VolTxt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(366, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vol:";
            // 
            // isSync
            // 
            this.isSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isSync.AutoSize = true;
            this.isSync.Location = new System.Drawing.Point(84, 52);
            this.isSync.Name = "isSync";
            this.isSync.Size = new System.Drawing.Size(48, 16);
            this.isSync.TabIndex = 12;
            this.isSync.Text = "Sync";
            this.isSync.UseVisualStyleBackColor = true;
            this.isSync.CheckedChanged += new System.EventHandler(this.isSync_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FS
            // 
            this.FS.Location = new System.Drawing.Point(14, 130);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(100, 21);
            this.FS.TabIndex = 14;
            this.FS.Text = "20";
            // 
            // FE
            // 
            this.FE.Location = new System.Drawing.Point(133, 130);
            this.FE.Name = "FE";
            this.FE.Size = new System.Drawing.Size(100, 21);
            this.FE.TabIndex = 15;
            this.FE.Text = "20000";
            // 
            // Fstep
            // 
            this.Fstep.Location = new System.Drawing.Point(253, 130);
            this.Fstep.Name = "Fstep";
            this.Fstep.Size = new System.Drawing.Size(51, 21);
            this.Fstep.TabIndex = 16;
            this.Fstep.Text = "50";
            // 
            // Sweep
            // 
            this.Sweep.Location = new System.Drawing.Point(176, 230);
            this.Sweep.Name = "Sweep";
            this.Sweep.Size = new System.Drawing.Size(75, 23);
            this.Sweep.TabIndex = 17;
            this.Sweep.Text = "Sweep";
            this.Sweep.UseVisualStyleBackColor = true;
            this.Sweep.Click += new System.EventHandler(this.Sweep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Start(Hz)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dest(Hz)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Interval(Hz)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sweepTime
            // 
            this.sweepTime.Location = new System.Drawing.Point(349, 130);
            this.sweepTime.Name = "sweepTime";
            this.sweepTime.Size = new System.Drawing.Size(51, 21);
            this.sweepTime.TabIndex = 21;
            this.sweepTime.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sweeptime(s)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(445, 265);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sweepTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sweep);
            this.Controls.Add(this.Fstep);
            this.Controls.Add(this.FE);
            this.Controls.Add(this.FS);
            this.Controls.Add(this.isSync);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolTxt);
            this.Controls.Add(this.VolBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_R);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.tB_L);
            this.Controls.Add(this.label_L);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleTone";
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label_L;
        private System.Windows.Forms.TextBox tB_L;
        private System.Windows.Forms.TextBox tB_R;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar VolBar;
        private System.Windows.Forms.Label VolTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isSync;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox FS;
        private System.Windows.Forms.TextBox FE;
        private System.Windows.Forms.TextBox Fstep;
        private System.Windows.Forms.Button Sweep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sweepTime;
        private System.Windows.Forms.Label label7;
    }
}

