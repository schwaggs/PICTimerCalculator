namespace PICCalculators
{
    partial class Main
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
            this.TimerCalcBT = new System.Windows.Forms.Button();
            this.BaudCalcBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerCalcBT
            // 
            this.TimerCalcBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimerCalcBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerCalcBT.Location = new System.Drawing.Point(41, 12);
            this.TimerCalcBT.Name = "TimerCalcBT";
            this.TimerCalcBT.Size = new System.Drawing.Size(208, 42);
            this.TimerCalcBT.TabIndex = 0;
            this.TimerCalcBT.Text = "Timer Calculator";
            this.TimerCalcBT.UseVisualStyleBackColor = true;
            this.TimerCalcBT.Click += new System.EventHandler(this.TimerCalcBT_Click);
            // 
            // BaudCalcBT
            // 
            this.BaudCalcBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BaudCalcBT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BaudCalcBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BaudCalcBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BaudCalcBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudCalcBT.Location = new System.Drawing.Point(41, 68);
            this.BaudCalcBT.Name = "BaudCalcBT";
            this.BaudCalcBT.Size = new System.Drawing.Size(208, 42);
            this.BaudCalcBT.TabIndex = 1;
            this.BaudCalcBT.Text = "BAUD Calculator";
            this.BaudCalcBT.UseVisualStyleBackColor = true;
            this.BaudCalcBT.Click += new System.EventHandler(this.BaudCalcBT_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 122);
            this.Controls.Add(this.BaudCalcBT);
            this.Controls.Add(this.TimerCalcBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "PIC Calculators";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TimerCalcBT;
        private System.Windows.Forms.Button BaudCalcBT;
    }
}