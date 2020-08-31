namespace CoCaro
{
    partial class board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(board));
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.prbDemNguoc = new System.Windows.Forms.ProgressBar();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlTrangThai = new System.Windows.Forms.Panel();
            this.rtbLuatChoi = new System.Windows.Forms.RichTextBox();
            this.timerThoiGian = new System.Windows.Forms.Timer(this.components);
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.pnlTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBanCo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBanCo.Location = new System.Drawing.Point(246, 0);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(688, 551);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.LightGray;
            this.pnlThongTin.Controls.Add(this.label2);
            this.pnlThongTin.Controls.Add(this.prbDemNguoc);
            this.pnlThongTin.Controls.Add(this.ptbAvatar);
            this.pnlThongTin.Controls.Add(this.btnPause);
            this.pnlThongTin.Controls.Add(this.btnStart);
            this.pnlThongTin.Location = new System.Drawing.Point(12, 9);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(228, 174);
            this.pnlThongTin.TabIndex = 1;
            this.pnlThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTin_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prbDemNguoc
            // 
            this.prbDemNguoc.Location = new System.Drawing.Point(6, 125);
            this.prbDemNguoc.Name = "prbDemNguoc";
            this.prbDemNguoc.Size = new System.Drawing.Size(109, 19);
            this.prbDemNguoc.TabIndex = 1;
            this.prbDemNguoc.Click += new System.EventHandler(this.prbDemNguoc_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.ptbAvatar.Location = new System.Drawing.Point(3, 3);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(109, 92);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 2;
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(140, 42);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Kết thúc";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(140, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlTrangThai
            // 
            this.pnlTrangThai.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlTrangThai.Controls.Add(this.rtbLuatChoi);
            this.pnlTrangThai.Location = new System.Drawing.Point(12, 200);
            this.pnlTrangThai.Name = "pnlTrangThai";
            this.pnlTrangThai.Size = new System.Drawing.Size(228, 150);
            this.pnlTrangThai.TabIndex = 2;
            this.pnlTrangThai.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTrangThai_Paint);
            // 
            // rtbLuatChoi
            // 
            this.rtbLuatChoi.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLuatChoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLuatChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLuatChoi.ForeColor = System.Drawing.Color.DarkBlue;
            this.rtbLuatChoi.Location = new System.Drawing.Point(0, 0);
            this.rtbLuatChoi.Name = "rtbLuatChoi";
            this.rtbLuatChoi.Size = new System.Drawing.Size(228, 150);
            this.rtbLuatChoi.TabIndex = 2;
            this.rtbLuatChoi.Text = "There are no gaming guides and it will always be, if you don\'t know how to play i" +
    "t, go fuck yourself :v\n";
            this.rtbLuatChoi.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // timerThoiGian
            // 
            this.timerThoiGian.Tick += new System.EventHandler(this.timerThoiGian_Tick);
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.pnlTrangThai);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.pnlBanCo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 590);
            this.MinimumSize = new System.Drawing.Size(950, 590);
            this.Name = "board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.pnlTrangThai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Panel pnlTrangThai;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.ProgressBar prbDemNguoc;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RichTextBox rtbLuatChoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerThoiGian;
    }
}

