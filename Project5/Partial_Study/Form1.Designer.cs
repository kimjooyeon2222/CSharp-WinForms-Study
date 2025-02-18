namespace Partial_Study
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
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.cboxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCout = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxItem
            // 
            this.lboxItem.BackColor = System.Drawing.Color.MintCream;
            this.lboxItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 24;
            this.lboxItem.Location = new System.Drawing.Point(21, 22);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(369, 364);
            this.lboxItem.TabIndex = 0;
            this.lboxItem.SelectedIndexChanged += new System.EventHandler(this.lboxItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(419, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // cboxItem
            // 
            this.cboxItem.BackColor = System.Drawing.SystemColors.Window;
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(423, 59);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(121, 32);
            this.cboxItem.TabIndex = 2;
            this.cboxItem.SelectedIndexChanged += new System.EventHandler(this.cboxItem_SelectedIndexChanged);
            // 
            // cboxRate
            // 
            this.cboxRate.BackColor = System.Drawing.Color.Azure;
            this.cboxRate.FormattingEnabled = true;
            this.cboxRate.Location = new System.Drawing.Point(423, 157);
            this.cboxRate.Name = "cboxRate";
            this.cboxRate.Size = new System.Drawing.Size(121, 32);
            this.cboxRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(419, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "할인율(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(419, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수";
            // 
            // numCout
            // 
            this.numCout.BackColor = System.Drawing.Color.Azure;
            this.numCout.Location = new System.Drawing.Point(423, 247);
            this.numCout.Name = "numCout";
            this.numCout.Size = new System.Drawing.Size(122, 35);
            this.numCout.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(423, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 48);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.BackColor = System.Drawing.Color.Azure;
            this.tboxResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxResult.Location = new System.Drawing.Point(20, 407);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(369, 35);
            this.tboxResult.TabIndex = 8;
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.BackColor = System.Drawing.Color.Azure;
            this.tboxErrorMsg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.tboxErrorMsg.Location = new System.Drawing.Point(12, 460);
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(533, 35);
            this.tboxErrorMsg.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(423, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 51);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 515);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tboxErrorMsg);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.ComboBox cboxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxErrorMsg;
        private System.Windows.Forms.Button btnClear;
    }
}

