namespace StreamReader_Write
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxConfigData = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.cboxData = new System.Windows.Forms.CheckBox();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.btnConfigSet = new System.Windows.Forms.Button();
            this.btnConfigRead = new System.Windows.Forms.Button();
            this.SFDialog = new System.Windows.Forms.SaveFileDialog();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.Location = new System.Drawing.Point(43, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(207, 52);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Text 읽어오기";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(265, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Text 저장하기";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxConfigData
            // 
            this.tboxConfigData.Enabled = false;
            this.tboxConfigData.Location = new System.Drawing.Point(43, 98);
            this.tboxConfigData.Multiline = true;
            this.tboxConfigData.Name = "tboxConfigData";
            this.tboxConfigData.Size = new System.Drawing.Size(441, 112);
            this.tboxConfigData.TabIndex = 2;
            this.tboxConfigData.TextChanged += new System.EventHandler(this.tboxConfigData_TextChanged);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.numData);
            this.GroupBox.Controls.Add(this.cboxData);
            this.GroupBox.Controls.Add(this.tboxData);
            this.GroupBox.Controls.Add(this.Label2);
            this.GroupBox.Controls.Add(this.Label3);
            this.GroupBox.Controls.Add(this.Label);
            this.GroupBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox.Location = new System.Drawing.Point(43, 233);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(441, 203);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Config";
            // 
            // numData
            // 
            this.numData.Location = new System.Drawing.Point(198, 151);
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(120, 35);
            this.numData.TabIndex = 5;
            this.numData.ValueChanged += new System.EventHandler(this.numData_ValueChanged);
            // 
            // cboxData
            // 
            this.cboxData.AutoSize = true;
            this.cboxData.Location = new System.Drawing.Point(222, 92);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(87, 28);
            this.cboxData.TabIndex = 4;
            this.cboxData.Text = "CB1";
            this.cboxData.UseVisualStyleBackColor = true;
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(174, 30);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(144, 35);
            this.tboxData.TabIndex = 3;
            this.tboxData.TextChanged += new System.EventHandler(this.tboxData_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(172, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "2. Check Box:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 153);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(134, 24);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "3. Number:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(15, 41);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(102, 24);
            this.Label.TabIndex = 0;
            this.Label.Text = "1. Text:";
            // 
            // btnConfigSet
            // 
            this.btnConfigSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConfigSet.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfigSet.Location = new System.Drawing.Point(277, 453);
            this.btnConfigSet.Name = "btnConfigSet";
            this.btnConfigSet.Size = new System.Drawing.Size(207, 52);
            this.btnConfigSet.TabIndex = 4;
            this.btnConfigSet.Text = "Config 설정하기";
            this.btnConfigSet.UseVisualStyleBackColor = false;
            this.btnConfigSet.Click += new System.EventHandler(this.btnConfigSet_Click);
            // 
            // btnConfigRead
            // 
            this.btnConfigRead.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConfigRead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfigRead.Location = new System.Drawing.Point(43, 453);
            this.btnConfigRead.Name = "btnConfigRead";
            this.btnConfigRead.Size = new System.Drawing.Size(207, 52);
            this.btnConfigRead.TabIndex = 5;
            this.btnConfigRead.Text = "Config 가져오기";
            this.btnConfigRead.UseVisualStyleBackColor = false;
            this.btnConfigRead.Click += new System.EventHandler(this.btnConfigRead_Click);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 528);
            this.Controls.Add(this.btnConfigRead);
            this.Controls.Add(this.btnConfigSet);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.tboxConfigData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboxConfigData;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnConfigSet;
        private System.Windows.Forms.Button btnConfigRead;
        private System.Windows.Forms.NumericUpDown numData;
        private System.Windows.Forms.CheckBox cboxData;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.SaveFileDialog SFDialog;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}

