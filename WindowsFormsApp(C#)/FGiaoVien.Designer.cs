﻿namespace WindowsFormsApp_C__
{
    partial class FGiaoVien
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ucThongTin1 = new UCThongTin();
            SuspendLayout();
            // 
            // ucThongTin1
            // 
            ucThongTin1.Location = new Point(10, -25);
            ucThongTin1.Name = "ucThongTin1";
            ucThongTin1.Size = new Size(1562, 645);
            ucThongTin1.TabIndex = 0;
            ucThongTin1.Load += ucThongTin1_Load;
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 604);
            Controls.Add(ucThongTin1);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UCThongTin ucThongTin1;
    }
}