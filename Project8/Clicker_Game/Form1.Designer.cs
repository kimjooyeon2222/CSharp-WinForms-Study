namespace Clicker_Game
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.lblTickPoint = new System.Windows.Forms.Label();
            this.lblTickPoint1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn1add = new System.Windows.Forms.Button();
            this.btn3add = new System.Windows.Forms.Button();
            this.btn50add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.lblTotal);
            this.GroupBox.Controls.Add(this.lblTickPoint1);
            this.GroupBox.Controls.Add(this.lblTickPoint);
            this.GroupBox.Location = new System.Drawing.Point(26, 34);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(723, 191);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "점수";
            // 
            // lblTickPoint
            // 
            this.lblTickPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTickPoint.Location = new System.Drawing.Point(151, 31);
            this.lblTickPoint.Name = "lblTickPoint";
            this.lblTickPoint.Size = new System.Drawing.Size(566, 24);
            this.lblTickPoint.TabIndex = 0;
            this.lblTickPoint.Text = "0";
            this.lblTickPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTickPoint1
            // 
            this.lblTickPoint1.AutoSize = true;
            this.lblTickPoint1.Location = new System.Drawing.Point(6, 31);
            this.lblTickPoint1.Name = "lblTickPoint1";
            this.lblTickPoint1.Size = new System.Drawing.Size(121, 24);
            this.lblTickPoint1.TabIndex = 1;
            this.lblTickPoint1.Text = "Tick Point:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotal.Location = new System.Drawing.Point(6, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(711, 99);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "1168";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1add
            // 
            this.btn1add.Location = new System.Drawing.Point(26, 248);
            this.btn1add.Name = "btn1add";
            this.btn1add.Size = new System.Drawing.Size(187, 51);
            this.btn1add.TabIndex = 1;
            this.btn1add.Text = "+1";
            this.btn1add.UseVisualStyleBackColor = true;
            // 
            // btn3add
            // 
            this.btn3add.Location = new System.Drawing.Point(26, 305);
            this.btn3add.Name = "btn3add";
            this.btn3add.Size = new System.Drawing.Size(187, 50);
            this.btn3add.TabIndex = 2;
            this.btn3add.Text = "+3";
            this.btn3add.UseVisualStyleBackColor = true;
            // 
            // btn50add
            // 
            this.btn50add.Location = new System.Drawing.Point(26, 361);
            this.btn50add.Name = "btn50add";
            this.btn50add.Size = new System.Drawing.Size(187, 53);
            this.btn50add.TabIndex = 3;
            this.btn50add.Text = "+50";
            this.btn50add.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "(100)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "(500)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "(5000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn50add);
            this.Controls.Add(this.btn3add);
            this.Controls.Add(this.btn1add);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label lblTickPoint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTickPoint1;
        private System.Windows.Forms.Button btn1add;
        private System.Windows.Forms.Button btn3add;
        private System.Windows.Forms.Button btn50add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

