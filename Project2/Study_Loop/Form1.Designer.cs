namespace Study_Loop
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
            this.testboxResult = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testboxResult
            // 
            this.testboxResult.Location = new System.Drawing.Point(13, 13);
            this.testboxResult.Multiline = true;
            this.testboxResult.Name = "testboxResult";
            this.testboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testboxResult.Size = new System.Drawing.Size(428, 411);
            this.testboxResult.TabIndex = 0;
            this.testboxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFor.Location = new System.Drawing.Point(456, 27);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(316, 143);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnForeach.Location = new System.Drawing.Point(456, 176);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(316, 143);
            this.btnForeach.TabIndex = 2;
            this.btnForeach.Text = "ForEach";
            this.btnForeach.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.testboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testboxResult;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnForeach;
    }
}

