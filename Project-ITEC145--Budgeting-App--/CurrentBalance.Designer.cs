﻿namespace Project_ITEC145__Budgeting_App__
{
    partial class CurrentBalance
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
            txtCurrentBalance = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(140, 7);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(209, 23);
            txtCurrentBalance.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 2;
            label1.Text = "Starting Balance:";
            // 
            // CurrentBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 118);
            ControlBox = false;
            Controls.Add(txtCurrentBalance);
            Controls.Add(label1);
            Name = "CurrentBalance";
            Text = "BudgetSheet V1 - Starting Balance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtCurrentBalance;
        private Label label1;
    }
}