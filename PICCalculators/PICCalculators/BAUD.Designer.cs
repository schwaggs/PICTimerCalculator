namespace PICCalculators
{
    partial class BAUD
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
            this.CalculatedP = new System.Windows.Forms.Panel();
            this.MinDelayGB = new System.Windows.Forms.GroupBox();
            this.ActualBAUDTB = new System.Windows.Forms.TextBox();
            this.TickCounterGB = new System.Windows.Forms.GroupBox();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.RegisterValueGB = new System.Windows.Forms.GroupBox();
            this.SPBRGTB = new System.Windows.Forms.TextBox();
            this.FOSCLB = new System.Windows.Forms.Label();
            this.FOSCCBP = new System.Windows.Forms.Panel();
            this.FOSCCB = new System.Windows.Forms.ComboBox();
            this.FOSCTBP = new System.Windows.Forms.Panel();
            this.FOSCTB = new System.Windows.Forms.TextBox();
            this.CONFLB = new System.Windows.Forms.Label();
            this.DesiredBAUDLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateBT = new System.Windows.Forms.Button();
            this.CONFTB = new System.Windows.Forms.TextBox();
            this.CONFP = new System.Windows.Forms.Panel();
            this.DesiredBAUDTB = new System.Windows.Forms.TextBox();
            this.DesiredBAUDP = new System.Windows.Forms.Panel();
            this.CalculatedP.SuspendLayout();
            this.MinDelayGB.SuspendLayout();
            this.TickCounterGB.SuspendLayout();
            this.RegisterValueGB.SuspendLayout();
            this.FOSCCBP.SuspendLayout();
            this.FOSCTBP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.CONFP.SuspendLayout();
            this.DesiredBAUDP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatedP
            // 
            this.CalculatedP.Controls.Add(this.MinDelayGB);
            this.CalculatedP.Controls.Add(this.TickCounterGB);
            this.CalculatedP.Controls.Add(this.RegisterValueGB);
            this.CalculatedP.Location = new System.Drawing.Point(308, 35);
            this.CalculatedP.Name = "CalculatedP";
            this.CalculatedP.Size = new System.Drawing.Size(189, 151);
            this.CalculatedP.TabIndex = 35;
            this.CalculatedP.Visible = false;
            // 
            // MinDelayGB
            // 
            this.MinDelayGB.Controls.Add(this.ActualBAUDTB);
            this.MinDelayGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDelayGB.Location = new System.Drawing.Point(6, 101);
            this.MinDelayGB.Name = "MinDelayGB";
            this.MinDelayGB.Size = new System.Drawing.Size(171, 43);
            this.MinDelayGB.TabIndex = 1;
            this.MinDelayGB.TabStop = false;
            this.MinDelayGB.Text = "Actual Baud Rate (Bits/s)";
            // 
            // ActualBAUDTB
            // 
            this.ActualBAUDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActualBAUDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualBAUDTB.Location = new System.Drawing.Point(12, 21);
            this.ActualBAUDTB.Name = "ActualBAUDTB";
            this.ActualBAUDTB.ReadOnly = true;
            this.ActualBAUDTB.Size = new System.Drawing.Size(153, 15);
            this.ActualBAUDTB.TabIndex = 0;
            // 
            // TickCounterGB
            // 
            this.TickCounterGB.Controls.Add(this.ErrorTB);
            this.TickCounterGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickCounterGB.Location = new System.Drawing.Point(6, 52);
            this.TickCounterGB.Name = "TickCounterGB";
            this.TickCounterGB.Size = new System.Drawing.Size(171, 43);
            this.TickCounterGB.TabIndex = 1;
            this.TickCounterGB.TabStop = false;
            this.TickCounterGB.Text = "Error (%)";
            // 
            // ErrorTB
            // 
            this.ErrorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTB.Location = new System.Drawing.Point(12, 21);
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.ReadOnly = true;
            this.ErrorTB.Size = new System.Drawing.Size(153, 15);
            this.ErrorTB.TabIndex = 0;
            // 
            // RegisterValueGB
            // 
            this.RegisterValueGB.Controls.Add(this.SPBRGTB);
            this.RegisterValueGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterValueGB.Location = new System.Drawing.Point(6, 3);
            this.RegisterValueGB.Name = "RegisterValueGB";
            this.RegisterValueGB.Size = new System.Drawing.Size(171, 43);
            this.RegisterValueGB.TabIndex = 0;
            this.RegisterValueGB.TabStop = false;
            this.RegisterValueGB.Text = "SPBRG";
            // 
            // SPBRGTB
            // 
            this.SPBRGTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SPBRGTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SPBRGTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPBRGTB.Location = new System.Drawing.Point(12, 20);
            this.SPBRGTB.Name = "SPBRGTB";
            this.SPBRGTB.ReadOnly = true;
            this.SPBRGTB.Size = new System.Drawing.Size(153, 15);
            this.SPBRGTB.TabIndex = 0;
            // 
            // FOSCLB
            // 
            this.FOSCLB.AutoSize = true;
            this.FOSCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOSCLB.Location = new System.Drawing.Point(8, 12);
            this.FOSCLB.Name = "FOSCLB";
            this.FOSCLB.Size = new System.Drawing.Size(53, 20);
            this.FOSCLB.TabIndex = 38;
            this.FOSCLB.Text = "FOSC";
            // 
            // FOSCCBP
            // 
            this.FOSCCBP.Controls.Add(this.FOSCCB);
            this.FOSCCBP.Location = new System.Drawing.Point(126, 35);
            this.FOSCCBP.Name = "FOSCCBP";
            this.FOSCCBP.Size = new System.Drawing.Size(166, 38);
            this.FOSCCBP.TabIndex = 37;
            // 
            // FOSCCB
            // 
            this.FOSCCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FOSCCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOSCCB.FormattingEnabled = true;
            this.FOSCCB.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz",
            "GHz",
            "THz",
            "PHz"});
            this.FOSCCB.Location = new System.Drawing.Point(4, 5);
            this.FOSCCB.Name = "FOSCCB";
            this.FOSCCB.Size = new System.Drawing.Size(157, 28);
            this.FOSCCB.TabIndex = 4;
            this.FOSCCB.SelectedIndexChanged += new System.EventHandler(this.FOSCCB_SelectedIndexChanged);
            // 
            // FOSCTBP
            // 
            this.FOSCTBP.Controls.Add(this.FOSCTB);
            this.FOSCTBP.Location = new System.Drawing.Point(12, 35);
            this.FOSCTBP.Name = "FOSCTBP";
            this.FOSCTBP.Size = new System.Drawing.Size(112, 38);
            this.FOSCTBP.TabIndex = 36;
            // 
            // FOSCTB
            // 
            this.FOSCTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOSCTB.Location = new System.Drawing.Point(6, 6);
            this.FOSCTB.Name = "FOSCTB";
            this.FOSCTB.Size = new System.Drawing.Size(100, 26);
            this.FOSCTB.TabIndex = 0;
            this.FOSCTB.TextChanged += new System.EventHandler(this.FOSCTB_TextChanged);
            // 
            // CONFLB
            // 
            this.CONFLB.AutoSize = true;
            this.CONFLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFLB.Location = new System.Drawing.Point(8, 88);
            this.CONFLB.Name = "CONFLB";
            this.CONFLB.Size = new System.Drawing.Size(53, 20);
            this.CONFLB.TabIndex = 41;
            this.CONFLB.Text = "CONF";
            // 
            // DesiredBAUDLB
            // 
            this.DesiredBAUDLB.AutoSize = true;
            this.DesiredBAUDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredBAUDLB.Location = new System.Drawing.Point(138, 88);
            this.DesiredBAUDLB.Name = "DesiredBAUDLB";
            this.DesiredBAUDLB.Size = new System.Drawing.Size(145, 20);
            this.DesiredBAUDLB.TabIndex = 42;
            this.DesiredBAUDLB.Text = "Desired Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 129);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONF Values";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 95);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Mode: Synchronous";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "BRGH: X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "SYNC: 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(130, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mode: Asynchronous";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "BRGH: 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "SYNC: 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(255, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 95);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "64";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mode: Asynchronous";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "BRGH: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SYNC: 0";
            // 
            // CalculateBT
            // 
            this.CalculateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBT.Location = new System.Drawing.Point(63, 156);
            this.CalculateBT.Name = "CalculateBT";
            this.CalculateBT.Size = new System.Drawing.Size(126, 34);
            this.CalculateBT.TabIndex = 45;
            this.CalculateBT.Text = "Calculate";
            this.CalculateBT.UseVisualStyleBackColor = true;
            this.CalculateBT.Click += new System.EventHandler(this.CalculateBT_Click);
            // 
            // CONFTB
            // 
            this.CONFTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFTB.Location = new System.Drawing.Point(6, 6);
            this.CONFTB.Name = "CONFTB";
            this.CONFTB.Size = new System.Drawing.Size(100, 26);
            this.CONFTB.TabIndex = 0;
            this.CONFTB.TextChanged += new System.EventHandler(this.CONFTB_TextChanged);
            // 
            // CONFP
            // 
            this.CONFP.Controls.Add(this.CONFTB);
            this.CONFP.Location = new System.Drawing.Point(12, 111);
            this.CONFP.Name = "CONFP";
            this.CONFP.Size = new System.Drawing.Size(112, 38);
            this.CONFP.TabIndex = 37;
            // 
            // DesiredBAUDTB
            // 
            this.DesiredBAUDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredBAUDTB.Location = new System.Drawing.Point(6, 6);
            this.DesiredBAUDTB.Name = "DesiredBAUDTB";
            this.DesiredBAUDTB.Size = new System.Drawing.Size(100, 26);
            this.DesiredBAUDTB.TabIndex = 0;
            this.DesiredBAUDTB.TextChanged += new System.EventHandler(this.DesiredBAUDTB_TextChanged);
            // 
            // DesiredBAUDP
            // 
            this.DesiredBAUDP.Controls.Add(this.DesiredBAUDTB);
            this.DesiredBAUDP.Location = new System.Drawing.Point(142, 111);
            this.DesiredBAUDP.Name = "DesiredBAUDP";
            this.DesiredBAUDP.Size = new System.Drawing.Size(112, 38);
            this.DesiredBAUDP.TabIndex = 37;
            // 
            // BAUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 340);
            this.Controls.Add(this.DesiredBAUDP);
            this.Controls.Add(this.CONFP);
            this.Controls.Add(this.CalculateBT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DesiredBAUDLB);
            this.Controls.Add(this.CONFLB);
            this.Controls.Add(this.FOSCLB);
            this.Controls.Add(this.FOSCCBP);
            this.Controls.Add(this.FOSCTBP);
            this.Controls.Add(this.CalculatedP);
            this.Name = "BAUD";
            this.Text = "BAUD Calculator";
            this.Load += new System.EventHandler(this.BAUD_Load);
            this.CalculatedP.ResumeLayout(false);
            this.MinDelayGB.ResumeLayout(false);
            this.MinDelayGB.PerformLayout();
            this.TickCounterGB.ResumeLayout(false);
            this.TickCounterGB.PerformLayout();
            this.RegisterValueGB.ResumeLayout(false);
            this.RegisterValueGB.PerformLayout();
            this.FOSCCBP.ResumeLayout(false);
            this.FOSCTBP.ResumeLayout(false);
            this.FOSCTBP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.CONFP.ResumeLayout(false);
            this.CONFP.PerformLayout();
            this.DesiredBAUDP.ResumeLayout(false);
            this.DesiredBAUDP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CalculatedP;
        private System.Windows.Forms.GroupBox MinDelayGB;
        private System.Windows.Forms.TextBox ActualBAUDTB;
        private System.Windows.Forms.GroupBox TickCounterGB;
        private System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.GroupBox RegisterValueGB;
        private System.Windows.Forms.TextBox SPBRGTB;
        private System.Windows.Forms.Label FOSCLB;
        private System.Windows.Forms.Panel FOSCCBP;
        private System.Windows.Forms.ComboBox FOSCCB;
        private System.Windows.Forms.Panel FOSCTBP;
        private System.Windows.Forms.TextBox FOSCTB;
        private System.Windows.Forms.Label CONFLB;
        private System.Windows.Forms.Label DesiredBAUDLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateBT;
        private System.Windows.Forms.TextBox CONFTB;
        private System.Windows.Forms.Panel CONFP;
        private System.Windows.Forms.TextBox DesiredBAUDTB;
        private System.Windows.Forms.Panel DesiredBAUDP;
    }
}