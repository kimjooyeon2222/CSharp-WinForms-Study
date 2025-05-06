namespace Delegate_Study
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDough2 = new System.Windows.Forms.RadioButton();
            this.rdoDough1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoEdge2 = new System.Windows.Forms.RadioButton();
            this.rdoEdge1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numEa = new System.Windows.Forms.NumericUpDown();
            this.cboxTopping2 = new System.Windows.Forms.CheckBox();
            this.cboxTopping3 = new System.Windows.Forms.CheckBox();
            this.cboxTopping1 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lboxOrder = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDough2);
            this.groupBox1.Controls.Add(this.rdoDough1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dough";
            // 
            // rdoDough2
            // 
            this.rdoDough2.AutoSize = true;
            this.rdoDough2.Location = new System.Drawing.Point(213, 34);
            this.rdoDough2.Name = "rdoDough2";
            this.rdoDough2.Size = new System.Drawing.Size(155, 28);
            this.rdoDough2.TabIndex = 1;
            this.rdoDough2.TabStop = true;
            this.rdoDough2.Text = "Thin ($11)";
            this.rdoDough2.UseVisualStyleBackColor = true;
            // 
            // rdoDough1
            // 
            this.rdoDough1.AutoSize = true;
            this.rdoDough1.Location = new System.Drawing.Point(12, 31);
            this.rdoDough1.Name = "rdoDough1";
            this.rdoDough1.Size = new System.Drawing.Size(186, 28);
            this.rdoDough1.TabIndex = 0;
            this.rdoDough1.TabStop = true;
            this.rdoDough1.Text = "original ($10)";
            this.rdoDough1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoEdge2);
            this.groupBox2.Controls.Add(this.rdoEdge1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(30, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge";
            // 
            // rdoEdge2
            // 
            this.rdoEdge2.AutoSize = true;
            this.rdoEdge2.Location = new System.Drawing.Point(213, 34);
            this.rdoEdge2.Name = "rdoEdge2";
            this.rdoEdge2.Size = new System.Drawing.Size(246, 28);
            this.rdoEdge2.TabIndex = 1;
            this.rdoEdge2.TabStop = true;
            this.rdoEdge2.Text = "Cheeze Crust ($2)";
            this.rdoEdge2.UseVisualStyleBackColor = true;
            // 
            // rdoEdge1
            // 
            this.rdoEdge1.AutoSize = true;
            this.rdoEdge1.Location = new System.Drawing.Point(12, 31);
            this.rdoEdge1.Name = "rdoEdge1";
            this.rdoEdge1.Size = new System.Drawing.Size(203, 28);
            this.rdoEdge1.TabIndex = 0;
            this.rdoEdge1.TabStop = true;
            this.rdoEdge1.Text = "Rich Gold ($1)";
            this.rdoEdge1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numEa);
            this.groupBox3.Controls.Add(this.cboxTopping2);
            this.groupBox3.Controls.Add(this.cboxTopping3);
            this.groupBox3.Controls.Add(this.cboxTopping1);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(30, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 154);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(407, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "(EA)";
            // 
            // numEa
            // 
            this.numEa.Location = new System.Drawing.Point(333, 95);
            this.numEa.Name = "numEa";
            this.numEa.Size = new System.Drawing.Size(68, 35);
            this.numEa.TabIndex = 3;
            // 
            // cboxTopping2
            // 
            this.cboxTopping2.AutoSize = true;
            this.cboxTopping2.Location = new System.Drawing.Point(12, 68);
            this.cboxTopping2.Name = "cboxTopping2";
            this.cboxTopping2.Size = new System.Drawing.Size(269, 28);
            this.cboxTopping2.TabIndex = 2;
            this.cboxTopping2.Text = "Potato (1ea $0.25 )";
            this.cboxTopping2.UseVisualStyleBackColor = true;
            // 
            // cboxTopping3
            // 
            this.cboxTopping3.AutoSize = true;
            this.cboxTopping3.Location = new System.Drawing.Point(12, 102);
            this.cboxTopping3.Name = "cboxTopping3";
            this.cboxTopping3.Size = new System.Drawing.Size(262, 28);
            this.cboxTopping3.TabIndex = 1;
            this.cboxTopping3.Text = "Cheeze (1ea $0.5 )";
            this.cboxTopping3.UseVisualStyleBackColor = true;
            // 
            // cboxTopping1
            // 
            this.cboxTopping1.AutoSize = true;
            this.cboxTopping1.Location = new System.Drawing.Point(12, 34);
            this.cboxTopping1.Name = "cboxTopping1";
            this.cboxTopping1.Size = new System.Drawing.Size(272, 28);
            this.cboxTopping1.TabIndex = 0;
            this.cboxTopping1.Text = "Sausage (1ea $0.5 )";
            this.cboxTopping1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.Location = new System.Drawing.Point(409, 397);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 51);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lboxOrder
            // 
            this.lboxOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lboxOrder.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.ItemHeight = 24;
            this.lboxOrder.Location = new System.Drawing.Point(42, 481);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(500, 364);
            this.lboxOrder.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 883);
            this.Controls.Add(this.lboxOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDough2;
        private System.Windows.Forms.RadioButton rdoDough1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoEdge2;
        private System.Windows.Forms.RadioButton rdoEdge1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cboxTopping2;
        private System.Windows.Forms.CheckBox cboxTopping3;
        private System.Windows.Forms.CheckBox cboxTopping1;
        private System.Windows.Forms.NumericUpDown numEa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lboxOrder;
    }
}

