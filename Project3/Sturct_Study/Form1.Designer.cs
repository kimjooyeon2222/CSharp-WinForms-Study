namespace Sturct_Study
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pboxRed = new System.Windows.Forms.PictureBox();
            this.pboxOrange = new System.Windows.Forms.PictureBox();
            this.pboxYellow = new System.Windows.Forms.PictureBox();
            this.pboxNone = new System.Windows.Forms.PictureBox();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.lboxResult1 = new System.Windows.Forms.ListBox();
            this.lboxResult2 = new System.Windows.Forms.ListBox();
            this.leaderBoard = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl1.Location = new System.Drawing.Point(20, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(939, 40);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "- Player는 한 번씩 돌아가면서 선택을 하게 됩니다.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl2.Location = new System.Drawing.Point(20, 66);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(1446, 40);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "- 각 5회 진행 후 빨강, 주황, 노랑의 숫자의 합이 가장 높은 사람이 승리합니다. ";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // pboxRed
            // 
            this.pboxRed.BackColor = System.Drawing.Color.Red;
            this.pboxRed.Location = new System.Drawing.Point(51, 111);
            this.pboxRed.Name = "pboxRed";
            this.pboxRed.Size = new System.Drawing.Size(166, 249);
            this.pboxRed.TabIndex = 2;
            this.pboxRed.TabStop = false;
            this.pboxRed.Click += new System.EventHandler(this.pboxRed_Click);
            // 
            // pboxOrange
            // 
            this.pboxOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pboxOrange.Location = new System.Drawing.Point(572, 111);
            this.pboxOrange.Name = "pboxOrange";
            this.pboxOrange.Size = new System.Drawing.Size(170, 249);
            this.pboxOrange.TabIndex = 3;
            this.pboxOrange.TabStop = false;
            this.pboxOrange.Click += new System.EventHandler(this.pboxOrange_Click);
            // 
            // pboxYellow
            // 
            this.pboxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pboxYellow.Location = new System.Drawing.Point(1076, 109);
            this.pboxYellow.Name = "pboxYellow";
            this.pboxYellow.Size = new System.Drawing.Size(170, 249);
            this.pboxYellow.TabIndex = 4;
            this.pboxYellow.TabStop = false;
            this.pboxYellow.Click += new System.EventHandler(this.pboxYellow_Click);
            // 
            // pboxNone
            // 
            this.pboxNone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pboxNone.Location = new System.Drawing.Point(1574, 111);
            this.pboxNone.Name = "pboxNone";
            this.pboxNone.Size = new System.Drawing.Size(170, 249);
            this.pboxNone.TabIndex = 5;
            this.pboxNone.TabStop = false;
            this.pboxNone.Click += new System.EventHandler(this.pboxNone_Click);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Font = new System.Drawing.Font("굴림", 13F);
            this.rdoPlayer1.Location = new System.Drawing.Point(24, 398);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(166, 39);
            this.rdoPlayer1.TabIndex = 6;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Font = new System.Drawing.Font("굴림", 13F);
            this.rdoPlayer2.Location = new System.Drawing.Point(887, 398);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(166, 39);
            this.rdoPlayer2.TabIndex = 7;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            this.rdoPlayer2.CheckedChanged += new System.EventHandler(this.rdoPlayer2_CheckedChanged);
            // 
            // lboxResult1
            // 
            this.lboxResult1.Font = new System.Drawing.Font("굴림", 13F);
            this.lboxResult1.FormattingEnabled = true;
            this.lboxResult1.ItemHeight = 35;
            this.lboxResult1.Location = new System.Drawing.Point(24, 478);
            this.lboxResult1.Name = "lboxResult1";
            this.lboxResult1.Size = new System.Drawing.Size(768, 354);
            this.lboxResult1.TabIndex = 8;
            this.lboxResult1.SelectedIndexChanged += new System.EventHandler(this.lboxResult1_SelectedIndexChanged);
            // 
            // lboxResult2
            // 
            this.lboxResult2.Font = new System.Drawing.Font("굴림", 13F);
            this.lboxResult2.FormattingEnabled = true;
            this.lboxResult2.ItemHeight = 35;
            this.lboxResult2.Location = new System.Drawing.Point(887, 478);
            this.lboxResult2.Name = "lboxResult2";
            this.lboxResult2.Size = new System.Drawing.Size(857, 354);
            this.lboxResult2.TabIndex = 9;
            // 
            // leaderBoard
            // 
            this.leaderBoard.BackColor = System.Drawing.Color.Black;
            this.leaderBoard.Cursor = System.Windows.Forms.Cursors.No;
            this.leaderBoard.Font = new System.Drawing.Font("굴림", 12F);
            this.leaderBoard.ForeColor = System.Drawing.Color.Transparent;
            this.leaderBoard.FormattingEnabled = true;
            this.leaderBoard.ItemHeight = 32;
            this.leaderBoard.Location = new System.Drawing.Point(27, 909);
            this.leaderBoard.Name = "leaderBoard";
            this.leaderBoard.Size = new System.Drawing.Size(1717, 292);
            this.leaderBoard.TabIndex = 10;
            this.leaderBoard.SelectedIndexChanged += new System.EventHandler(this.leaderBoard_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 1246);
            this.Controls.Add(this.leaderBoard);
            this.Controls.Add(this.lboxResult2);
            this.Controls.Add(this.lboxResult1);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pboxNone);
            this.Controls.Add(this.pboxYellow);
            this.Controls.Add(this.pboxOrange);
            this.Controls.Add(this.pboxRed);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pboxRed;
        private System.Windows.Forms.PictureBox pboxOrange;
        private System.Windows.Forms.PictureBox pboxYellow;
        private System.Windows.Forms.PictureBox pboxNone;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.ListBox lboxResult1;
        private System.Windows.Forms.ListBox lboxResult2;
        private System.Windows.Forms.ListBox leaderBoard;
    }
}

