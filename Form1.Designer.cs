﻿
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class Form1
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
            this.resultDisplay1 = new Vsite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            this.SuspendLayout();
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(119, 76);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(477, 314);
            this.resultDisplay1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay1;
    }
}

