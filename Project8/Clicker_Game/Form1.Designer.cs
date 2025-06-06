﻿using System;
using System.Windows.Forms;

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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTickPoint1 = new System.Windows.Forms.Label();
            this.lblTickPoint = new System.Windows.Forms.Label();
            this.btn1Add = new System.Windows.Forms.Button();
            this.btn5Add = new System.Windows.Forms.Button();
            this.btn50Add = new System.Windows.Forms.Button();
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
            this.GroupBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox.Location = new System.Drawing.Point(26, 34);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(723, 191);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "점수";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Pink;
            this.lblTotal.Location = new System.Drawing.Point(6, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(711, 99);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "1168";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTickPoint1
            // 
            this.lblTickPoint1.AutoSize = true;
            this.lblTickPoint1.Location = new System.Drawing.Point(6, 31);
            this.lblTickPoint1.Name = "lblTickPoint1";
            this.lblTickPoint1.Size = new System.Drawing.Size(132, 24);
            this.lblTickPoint1.TabIndex = 1;
            this.lblTickPoint1.Text = "Tick Point:";
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
            // btn1Add
            // 
            this.btn1Add.Location = new System.Drawing.Point(26, 248);
            this.btn1Add.Name = "btn1Add";
            this.btn1Add.Size = new System.Drawing.Size(187, 51);
            this.btn1Add.TabIndex = 1;
            this.btn1Add.Text = "+1";
            this.btn1Add.UseVisualStyleBackColor = true;
            this.btn1Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn5Add
            // 
            this.btn5Add.Location = new System.Drawing.Point(26, 305);
            this.btn5Add.Name = "btn5Add";
            this.btn5Add.Size = new System.Drawing.Size(187, 50);
            this.btn5Add.TabIndex = 2;
            this.btn5Add.Text = "+5";
            this.btn5Add.UseVisualStyleBackColor = true;
            this.btn5Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn50Add
            // 
            this.btn50Add.Location = new System.Drawing.Point(26, 361);
            this.btn50Add.Name = "btn50Add";
            this.btn50Add.Size = new System.Drawing.Size(187, 53);
            this.btn50Add.TabIndex = 3;
            this.btn50Add.Text = "+50";
            this.btn50Add.UseVisualStyleBackColor = true;
            this.btn50Add.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Controls.Add(this.btn50Add);
            this.Controls.Add(this.btn5Add);
            this.Controls.Add(this.btn1Add);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btn1Add;
        private System.Windows.Forms.Button btn5Add;
        private System.Windows.Forms.Button btn50Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

