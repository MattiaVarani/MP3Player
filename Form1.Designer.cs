namespace MusicPlayer
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TxtSong = new System.Windows.Forms.TextBox();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.RdbDown = new System.Windows.Forms.RadioButton();
            this.RdbUp = new System.Windows.Forms.RadioButton();
            this.RdbRandom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Location = new System.Drawing.Point(303, 52);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(82, 33);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Location = new System.Drawing.Point(215, 72);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(82, 32);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "Down";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(215, 34);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 32);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Up";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // listBoxAll
            // 
            this.listBoxAll.AllowDrop = true;
            this.listBoxAll.BackColor = System.Drawing.Color.Black;
            this.listBoxAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAll.ForeColor = System.Drawing.Color.White;
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.Location = new System.Drawing.Point(12, 8);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxAll.Size = new System.Drawing.Size(197, 223);
            this.listBoxAll.TabIndex = 4;
            this.listBoxAll.DoubleClick += new System.EventHandler(this.listBoxAll_DoubleClick);
            // 
            // BtnStop
            // 
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Location = new System.Drawing.Point(391, 72);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(82, 32);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(385, 207);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(41, 24);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "All Media Files|*.mp3";
            this.FileDialog.Multiselect = true;
            // 
            // TxtSong
            // 
            this.TxtSong.BackColor = System.Drawing.Color.Black;
            this.TxtSong.ForeColor = System.Drawing.Color.White;
            this.TxtSong.Location = new System.Drawing.Point(215, 8);
            this.TxtSong.Name = "TxtSong";
            this.TxtSong.Size = new System.Drawing.Size(258, 20);
            this.TxtSong.TabIndex = 7;
            // 
            // BtnQuit
            // 
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Location = new System.Drawing.Point(432, 207);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(41, 24);
            this.BtnQuit.TabIndex = 8;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandom.Location = new System.Drawing.Point(391, 34);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(82, 32);
            this.BtnRandom.TabIndex = 9;
            this.BtnRandom.Text = "Play random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // Check
            // 
            this.Check.Interval = 500;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // RdbDown
            // 
            this.RdbDown.AutoSize = true;
            this.RdbDown.ForeColor = System.Drawing.Color.White;
            this.RdbDown.Location = new System.Drawing.Point(6, 10);
            this.RdbDown.Name = "RdbDown";
            this.RdbDown.Size = new System.Drawing.Size(76, 17);
            this.RdbDown.TabIndex = 10;
            this.RdbDown.TabStop = true;
            this.RdbDown.Text = "Downward";
            this.RdbDown.UseVisualStyleBackColor = true;
            // 
            // RdbUp
            // 
            this.RdbUp.AutoSize = true;
            this.RdbUp.Location = new System.Drawing.Point(6, 33);
            this.RdbUp.Name = "RdbUp";
            this.RdbUp.Size = new System.Drawing.Size(62, 17);
            this.RdbUp.TabIndex = 11;
            this.RdbUp.TabStop = true;
            this.RdbUp.Text = "Upward";
            this.RdbUp.UseVisualStyleBackColor = true;
            // 
            // RdbRandom
            // 
            this.RdbRandom.AutoSize = true;
            this.RdbRandom.Location = new System.Drawing.Point(6, 56);
            this.RdbRandom.Name = "RdbRandom";
            this.RdbRandom.Size = new System.Drawing.Size(65, 17);
            this.RdbRandom.TabIndex = 12;
            this.RdbRandom.TabStop = true;
            this.RdbRandom.Text = "Random";
            this.RdbRandom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.RdbDown);
            this.groupBox1.Controls.Add(this.RdbRandom);
            this.groupBox1.Controls.Add(this.RdbUp);
            this.groupBox1.Location = new System.Drawing.Point(215, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Display
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.TxtSong);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.listBoxAll);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPlay);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.TextBox TxtSong;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnRandom;
        public System.Windows.Forms.Timer Check;
        private System.Windows.Forms.RadioButton RdbDown;
        private System.Windows.Forms.RadioButton RdbUp;
        private System.Windows.Forms.RadioButton RdbRandom;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

