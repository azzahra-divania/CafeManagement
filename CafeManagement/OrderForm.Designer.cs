﻿
namespace CafeManagement
{
    partial class OrderForm
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
            this.SuspendLayout();

            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "OrderForm";
            this.Text = "Spesifikasi Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);



            this.ResumeLayout(false);



        }

        #endregion

        protected System.Windows.Forms.Label lblDebug;
        protected System.Windows.Forms.Button btnNegative;
        protected System.Windows.Forms.Button btnAffirmative;
        protected System.Windows.Forms.TextBox tbQty;
        protected System.Windows.Forms.Label label1;
    }
}