namespace PICCalculators
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.FOSCTB = new System.Windows.Forms.TextBox();
            this.DesiredDelayTB = new System.Windows.Forms.TextBox();
            this.foscCB = new System.Windows.Forms.ComboBox();
            this.DesiredDelayCB = new System.Windows.Forms.ComboBox();
            this.RegisterSizeCB = new System.Windows.Forms.ComboBox();
            this.PrescalerTB = new System.Windows.Forms.TextBox();
            this.FormulasBT = new System.Windows.Forms.Button();
            this.RegisterSizeTB = new System.Windows.Forms.TextBox();
            this.FOSCTBP = new System.Windows.Forms.Panel();
            this.FOSCCBP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrescalerTBP = new System.Windows.Forms.Panel();
            this.DesiredDelayLB = new System.Windows.Forms.Label();
            this.DesiredDelayCBP = new System.Windows.Forms.Panel();
            this.DesiredDelayTBP = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterSizeCBP = new System.Windows.Forms.Panel();
            this.RegisterSizeTBP = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.InternalClockCBP = new System.Windows.Forms.Panel();
            this.InternalClockCB = new System.Windows.Forms.ComboBox();
            this.CalculatedP = new System.Windows.Forms.Panel();
            this.InstructionFrequencyGB = new System.Windows.Forms.GroupBox();
            this.InstructionFrequencyTB = new System.Windows.Forms.TextBox();
            this.DelayCountGB = new System.Windows.Forms.GroupBox();
            this.DelayCountTB = new System.Windows.Forms.TextBox();
            this.TimerFrequencyGB = new System.Windows.Forms.GroupBox();
            this.TimerFrequencyTB = new System.Windows.Forms.TextBox();
            this.TimerPeriodGB = new System.Windows.Forms.GroupBox();
            this.TimerPeriodTB = new System.Windows.Forms.TextBox();
            this.MaxDelayGB = new System.Windows.Forms.GroupBox();
            this.MaxDelayTB = new System.Windows.Forms.TextBox();
            this.MinDelayGB = new System.Windows.Forms.GroupBox();
            this.MinDelayTB = new System.Windows.Forms.TextBox();
            this.TickCounterGB = new System.Windows.Forms.GroupBox();
            this.TickCounterTB = new System.Windows.Forms.TextBox();
            this.RegisterValueGB = new System.Windows.Forms.GroupBox();
            this.RegisterValueTB = new System.Windows.Forms.TextBox();
            this.HideCalculatedPBT = new System.Windows.Forms.Button();
            this.GenerateBT = new System.Windows.Forms.Button();
            this.ManualModeBT = new System.Windows.Forms.Button();
            this.FOSCTBP.SuspendLayout();
            this.FOSCCBP.SuspendLayout();
            this.PrescalerTBP.SuspendLayout();
            this.DesiredDelayCBP.SuspendLayout();
            this.DesiredDelayTBP.SuspendLayout();
            this.RegisterSizeCBP.SuspendLayout();
            this.RegisterSizeTBP.SuspendLayout();
            this.InternalClockCBP.SuspendLayout();
            this.CalculatedP.SuspendLayout();
            this.InstructionFrequencyGB.SuspendLayout();
            this.DelayCountGB.SuspendLayout();
            this.TimerFrequencyGB.SuspendLayout();
            this.TimerPeriodGB.SuspendLayout();
            this.MaxDelayGB.SuspendLayout();
            this.MinDelayGB.SuspendLayout();
            this.TickCounterGB.SuspendLayout();
            this.RegisterValueGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // FOSCTB
            // 
            this.FOSCTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOSCTB.Location = new System.Drawing.Point(6, 6);
            this.FOSCTB.Name = "FOSCTB";
            this.FOSCTB.Size = new System.Drawing.Size(100, 26);
            this.FOSCTB.TabIndex = 0;
            this.FOSCTB.TextChanged += new System.EventHandler(this.foscTB_TextChanged);
            // 
            // DesiredDelayTB
            // 
            this.DesiredDelayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredDelayTB.Location = new System.Drawing.Point(6, 6);
            this.DesiredDelayTB.Name = "DesiredDelayTB";
            this.DesiredDelayTB.Size = new System.Drawing.Size(100, 26);
            this.DesiredDelayTB.TabIndex = 2;
            this.DesiredDelayTB.TextChanged += new System.EventHandler(this.ddTB_TextChanged);
            // 
            // foscCB
            // 
            this.foscCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foscCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foscCB.FormattingEnabled = true;
            this.foscCB.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz",
            "GHz",
            "THz",
            "PHz"});
            this.foscCB.Location = new System.Drawing.Point(4, 5);
            this.foscCB.Name = "foscCB";
            this.foscCB.Size = new System.Drawing.Size(157, 28);
            this.foscCB.TabIndex = 4;
            this.foscCB.SelectedIndexChanged += new System.EventHandler(this.foscCB_SelectedIndexChanged);
            // 
            // DesiredDelayCB
            // 
            this.DesiredDelayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesiredDelayCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredDelayCB.FormattingEnabled = true;
            this.DesiredDelayCB.Items.AddRange(new object[] {
            "s",
            "ms",
            "us",
            "ns",
            "ps"});
            this.DesiredDelayCB.Location = new System.Drawing.Point(4, 5);
            this.DesiredDelayCB.Name = "DesiredDelayCB";
            this.DesiredDelayCB.Size = new System.Drawing.Size(157, 28);
            this.DesiredDelayCB.TabIndex = 5;
            this.DesiredDelayCB.SelectedIndexChanged += new System.EventHandler(this.ddCB_SelectedIndexChanged);
            // 
            // RegisterSizeCB
            // 
            this.RegisterSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegisterSizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSizeCB.FormattingEnabled = true;
            this.RegisterSizeCB.Items.AddRange(new object[] {
            "Bits",
            "Nibbles ( 4 Bits)",
            "Bytes (2 Nibbles)",
            "Kilobytes",
            "Megabytes",
            "Gigabytes",
            "Terabytes",
            "Petabytes"});
            this.RegisterSizeCB.Location = new System.Drawing.Point(4, 5);
            this.RegisterSizeCB.Name = "RegisterSizeCB";
            this.RegisterSizeCB.Size = new System.Drawing.Size(157, 28);
            this.RegisterSizeCB.TabIndex = 15;
            this.RegisterSizeCB.SelectedIndexChanged += new System.EventHandler(this.RegisterSizeCB_SelectedIndexChanged);
            // 
            // PrescalerTB
            // 
            this.PrescalerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescalerTB.Location = new System.Drawing.Point(6, 6);
            this.PrescalerTB.Name = "PrescalerTB";
            this.PrescalerTB.Size = new System.Drawing.Size(100, 26);
            this.PrescalerTB.TabIndex = 10;
            this.PrescalerTB.TextChanged += new System.EventHandler(this.PrescalerTB_TextChanged);
            // 
            // FormulasBT
            // 
            this.FormulasBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormulasBT.Location = new System.Drawing.Point(162, 301);
            this.FormulasBT.Name = "FormulasBT";
            this.FormulasBT.Size = new System.Drawing.Size(130, 48);
            this.FormulasBT.TabIndex = 17;
            this.FormulasBT.Text = "View Formulas";
            this.FormulasBT.UseVisualStyleBackColor = true;
            this.FormulasBT.Click += new System.EventHandler(this.FormulasBT_Click);
            // 
            // RegisterSizeTB
            // 
            this.RegisterSizeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSizeTB.Location = new System.Drawing.Point(6, 6);
            this.RegisterSizeTB.Name = "RegisterSizeTB";
            this.RegisterSizeTB.Size = new System.Drawing.Size(100, 26);
            this.RegisterSizeTB.TabIndex = 12;
            this.RegisterSizeTB.TextChanged += new System.EventHandler(this.RegisterSizeTB_TextChanged);
            // 
            // FOSCTBP
            // 
            this.FOSCTBP.Controls.Add(this.FOSCTB);
            this.FOSCTBP.Location = new System.Drawing.Point(12, 32);
            this.FOSCTBP.Name = "FOSCTBP";
            this.FOSCTBP.Size = new System.Drawing.Size(112, 38);
            this.FOSCTBP.TabIndex = 18;
            // 
            // FOSCCBP
            // 
            this.FOSCCBP.Controls.Add(this.foscCB);
            this.FOSCCBP.Location = new System.Drawing.Point(126, 32);
            this.FOSCCBP.Name = "FOSCCBP";
            this.FOSCCBP.Size = new System.Drawing.Size(166, 38);
            this.FOSCCBP.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOSC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prescaler";
            // 
            // PrescalerTBP
            // 
            this.PrescalerTBP.Controls.Add(this.PrescalerTB);
            this.PrescalerTBP.Location = new System.Drawing.Point(12, 105);
            this.PrescalerTBP.Name = "PrescalerTBP";
            this.PrescalerTBP.Size = new System.Drawing.Size(112, 38);
            this.PrescalerTBP.TabIndex = 21;
            // 
            // DesiredDelayLB
            // 
            this.DesiredDelayLB.AutoSize = true;
            this.DesiredDelayLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredDelayLB.Location = new System.Drawing.Point(14, 155);
            this.DesiredDelayLB.Name = "DesiredDelayLB";
            this.DesiredDelayLB.Size = new System.Drawing.Size(108, 20);
            this.DesiredDelayLB.TabIndex = 26;
            this.DesiredDelayLB.Text = "Desired Delay";
            // 
            // DesiredDelayCBP
            // 
            this.DesiredDelayCBP.Controls.Add(this.DesiredDelayCB);
            this.DesiredDelayCBP.Location = new System.Drawing.Point(126, 178);
            this.DesiredDelayCBP.Name = "DesiredDelayCBP";
            this.DesiredDelayCBP.Size = new System.Drawing.Size(166, 38);
            this.DesiredDelayCBP.TabIndex = 25;
            // 
            // DesiredDelayTBP
            // 
            this.DesiredDelayTBP.Controls.Add(this.DesiredDelayTB);
            this.DesiredDelayTBP.Location = new System.Drawing.Point(12, 178);
            this.DesiredDelayTBP.Name = "DesiredDelayTBP";
            this.DesiredDelayTBP.Size = new System.Drawing.Size(112, 38);
            this.DesiredDelayTBP.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Register Size";
            // 
            // RegisterSizeCBP
            // 
            this.RegisterSizeCBP.Controls.Add(this.RegisterSizeCB);
            this.RegisterSizeCBP.Location = new System.Drawing.Point(126, 251);
            this.RegisterSizeCBP.Name = "RegisterSizeCBP";
            this.RegisterSizeCBP.Size = new System.Drawing.Size(166, 38);
            this.RegisterSizeCBP.TabIndex = 28;
            // 
            // RegisterSizeTBP
            // 
            this.RegisterSizeTBP.Controls.Add(this.RegisterSizeTB);
            this.RegisterSizeTBP.Location = new System.Drawing.Point(12, 251);
            this.RegisterSizeTBP.Name = "RegisterSizeTBP";
            this.RegisterSizeTBP.Size = new System.Drawing.Size(112, 38);
            this.RegisterSizeTBP.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Internal Clock";
            // 
            // InternalClockCBP
            // 
            this.InternalClockCBP.Controls.Add(this.InternalClockCB);
            this.InternalClockCBP.Location = new System.Drawing.Point(162, 105);
            this.InternalClockCBP.Name = "InternalClockCBP";
            this.InternalClockCBP.Size = new System.Drawing.Size(112, 38);
            this.InternalClockCBP.TabIndex = 30;
            // 
            // InternalClockCB
            // 
            this.InternalClockCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InternalClockCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalClockCB.FormattingEnabled = true;
            this.InternalClockCB.Items.AddRange(new object[] {
            "FOSC",
            "FOSC/2",
            "FOSC/4"});
            this.InternalClockCB.Location = new System.Drawing.Point(6, 5);
            this.InternalClockCB.Name = "InternalClockCB";
            this.InternalClockCB.Size = new System.Drawing.Size(100, 28);
            this.InternalClockCB.TabIndex = 5;
            this.InternalClockCB.SelectedIndexChanged += new System.EventHandler(this.InternalClockCB_SelectedIndexChanged);
            // 
            // CalculatedP
            // 
            this.CalculatedP.Controls.Add(this.InstructionFrequencyGB);
            this.CalculatedP.Controls.Add(this.DelayCountGB);
            this.CalculatedP.Controls.Add(this.TimerFrequencyGB);
            this.CalculatedP.Controls.Add(this.TimerPeriodGB);
            this.CalculatedP.Controls.Add(this.MaxDelayGB);
            this.CalculatedP.Controls.Add(this.MinDelayGB);
            this.CalculatedP.Controls.Add(this.TickCounterGB);
            this.CalculatedP.Controls.Add(this.RegisterValueGB);
            this.CalculatedP.Location = new System.Drawing.Point(357, 9);
            this.CalculatedP.Name = "CalculatedP";
            this.CalculatedP.Size = new System.Drawing.Size(412, 396);
            this.CalculatedP.TabIndex = 32;
            this.CalculatedP.Visible = false;
            // 
            // InstructionFrequencyGB
            // 
            this.InstructionFrequencyGB.Controls.Add(this.InstructionFrequencyTB);
            this.InstructionFrequencyGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionFrequencyGB.Location = new System.Drawing.Point(6, 346);
            this.InstructionFrequencyGB.Name = "InstructionFrequencyGB";
            this.InstructionFrequencyGB.Size = new System.Drawing.Size(401, 43);
            this.InstructionFrequencyGB.TabIndex = 33;
            this.InstructionFrequencyGB.TabStop = false;
            this.InstructionFrequencyGB.Text = "Instruction Frequency";
            // 
            // InstructionFrequencyTB
            // 
            this.InstructionFrequencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionFrequencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionFrequencyTB.Location = new System.Drawing.Point(12, 21);
            this.InstructionFrequencyTB.Name = "InstructionFrequencyTB";
            this.InstructionFrequencyTB.ReadOnly = true;
            this.InstructionFrequencyTB.Size = new System.Drawing.Size(383, 15);
            this.InstructionFrequencyTB.TabIndex = 0;
            // 
            // DelayCountGB
            // 
            this.DelayCountGB.Controls.Add(this.DelayCountTB);
            this.DelayCountGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayCountGB.Location = new System.Drawing.Point(6, 297);
            this.DelayCountGB.Name = "DelayCountGB";
            this.DelayCountGB.Size = new System.Drawing.Size(401, 43);
            this.DelayCountGB.TabIndex = 1;
            this.DelayCountGB.TabStop = false;
            this.DelayCountGB.Text = "Delay Count";
            // 
            // DelayCountTB
            // 
            this.DelayCountTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayCountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayCountTB.Location = new System.Drawing.Point(12, 21);
            this.DelayCountTB.Name = "DelayCountTB";
            this.DelayCountTB.ReadOnly = true;
            this.DelayCountTB.Size = new System.Drawing.Size(383, 15);
            this.DelayCountTB.TabIndex = 0;
            // 
            // TimerFrequencyGB
            // 
            this.TimerFrequencyGB.Controls.Add(this.TimerFrequencyTB);
            this.TimerFrequencyGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerFrequencyGB.Location = new System.Drawing.Point(6, 248);
            this.TimerFrequencyGB.Name = "TimerFrequencyGB";
            this.TimerFrequencyGB.Size = new System.Drawing.Size(401, 43);
            this.TimerFrequencyGB.TabIndex = 1;
            this.TimerFrequencyGB.TabStop = false;
            this.TimerFrequencyGB.Text = "Timer Frequency";
            // 
            // TimerFrequencyTB
            // 
            this.TimerFrequencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimerFrequencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerFrequencyTB.Location = new System.Drawing.Point(12, 21);
            this.TimerFrequencyTB.Name = "TimerFrequencyTB";
            this.TimerFrequencyTB.ReadOnly = true;
            this.TimerFrequencyTB.Size = new System.Drawing.Size(383, 15);
            this.TimerFrequencyTB.TabIndex = 0;
            // 
            // TimerPeriodGB
            // 
            this.TimerPeriodGB.Controls.Add(this.TimerPeriodTB);
            this.TimerPeriodGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPeriodGB.Location = new System.Drawing.Point(6, 199);
            this.TimerPeriodGB.Name = "TimerPeriodGB";
            this.TimerPeriodGB.Size = new System.Drawing.Size(401, 43);
            this.TimerPeriodGB.TabIndex = 1;
            this.TimerPeriodGB.TabStop = false;
            this.TimerPeriodGB.Text = "Timer Period";
            // 
            // TimerPeriodTB
            // 
            this.TimerPeriodTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimerPeriodTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPeriodTB.Location = new System.Drawing.Point(12, 21);
            this.TimerPeriodTB.Name = "TimerPeriodTB";
            this.TimerPeriodTB.ReadOnly = true;
            this.TimerPeriodTB.Size = new System.Drawing.Size(383, 15);
            this.TimerPeriodTB.TabIndex = 0;
            // 
            // MaxDelayGB
            // 
            this.MaxDelayGB.Controls.Add(this.MaxDelayTB);
            this.MaxDelayGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDelayGB.Location = new System.Drawing.Point(6, 150);
            this.MaxDelayGB.Name = "MaxDelayGB";
            this.MaxDelayGB.Size = new System.Drawing.Size(401, 43);
            this.MaxDelayGB.TabIndex = 1;
            this.MaxDelayGB.TabStop = false;
            this.MaxDelayGB.Text = "Maximum Delay";
            // 
            // MaxDelayTB
            // 
            this.MaxDelayTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxDelayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDelayTB.Location = new System.Drawing.Point(12, 20);
            this.MaxDelayTB.Name = "MaxDelayTB";
            this.MaxDelayTB.ReadOnly = true;
            this.MaxDelayTB.Size = new System.Drawing.Size(383, 15);
            this.MaxDelayTB.TabIndex = 0;
            // 
            // MinDelayGB
            // 
            this.MinDelayGB.Controls.Add(this.MinDelayTB);
            this.MinDelayGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDelayGB.Location = new System.Drawing.Point(6, 101);
            this.MinDelayGB.Name = "MinDelayGB";
            this.MinDelayGB.Size = new System.Drawing.Size(401, 43);
            this.MinDelayGB.TabIndex = 1;
            this.MinDelayGB.TabStop = false;
            this.MinDelayGB.Text = "Minimum Delay";
            // 
            // MinDelayTB
            // 
            this.MinDelayTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinDelayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDelayTB.Location = new System.Drawing.Point(12, 21);
            this.MinDelayTB.Name = "MinDelayTB";
            this.MinDelayTB.ReadOnly = true;
            this.MinDelayTB.Size = new System.Drawing.Size(383, 15);
            this.MinDelayTB.TabIndex = 0;
            // 
            // TickCounterGB
            // 
            this.TickCounterGB.Controls.Add(this.TickCounterTB);
            this.TickCounterGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickCounterGB.Location = new System.Drawing.Point(6, 52);
            this.TickCounterGB.Name = "TickCounterGB";
            this.TickCounterGB.Size = new System.Drawing.Size(401, 43);
            this.TickCounterGB.TabIndex = 1;
            this.TickCounterGB.TabStop = false;
            this.TickCounterGB.Text = "Tick Counter";
            // 
            // TickCounterTB
            // 
            this.TickCounterTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TickCounterTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickCounterTB.Location = new System.Drawing.Point(12, 21);
            this.TickCounterTB.Name = "TickCounterTB";
            this.TickCounterTB.ReadOnly = true;
            this.TickCounterTB.Size = new System.Drawing.Size(383, 15);
            this.TickCounterTB.TabIndex = 0;
            // 
            // RegisterValueGB
            // 
            this.RegisterValueGB.Controls.Add(this.RegisterValueTB);
            this.RegisterValueGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterValueGB.Location = new System.Drawing.Point(6, 3);
            this.RegisterValueGB.Name = "RegisterValueGB";
            this.RegisterValueGB.Size = new System.Drawing.Size(401, 43);
            this.RegisterValueGB.TabIndex = 0;
            this.RegisterValueGB.TabStop = false;
            this.RegisterValueGB.Text = "Register Value";
            // 
            // RegisterValueTB
            // 
            this.RegisterValueTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegisterValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterValueTB.Location = new System.Drawing.Point(12, 20);
            this.RegisterValueTB.Name = "RegisterValueTB";
            this.RegisterValueTB.ReadOnly = true;
            this.RegisterValueTB.Size = new System.Drawing.Size(383, 15);
            this.RegisterValueTB.TabIndex = 0;
            // 
            // HideCalculatedPBT
            // 
            this.HideCalculatedPBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HideCalculatedPBT.BackgroundImage")));
            this.HideCalculatedPBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HideCalculatedPBT.Location = new System.Drawing.Point(318, 178);
            this.HideCalculatedPBT.Name = "HideCalculatedPBT";
            this.HideCalculatedPBT.Size = new System.Drawing.Size(39, 65);
            this.HideCalculatedPBT.TabIndex = 33;
            this.HideCalculatedPBT.UseVisualStyleBackColor = true;
            this.HideCalculatedPBT.Visible = false;
            this.HideCalculatedPBT.Click += new System.EventHandler(this.HideCalculatedPBT_Click);
            // 
            // GenerateBT
            // 
            this.GenerateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBT.Location = new System.Drawing.Point(12, 301);
            this.GenerateBT.Name = "GenerateBT";
            this.GenerateBT.Size = new System.Drawing.Size(126, 48);
            this.GenerateBT.TabIndex = 16;
            this.GenerateBT.Text = "Generate";
            this.GenerateBT.UseVisualStyleBackColor = true;
            this.GenerateBT.Click += new System.EventHandler(this.GenerateBT_Click);
            // 
            // ManualModeBT
            // 
            this.ManualModeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualModeBT.Location = new System.Drawing.Point(88, 355);
            this.ManualModeBT.Name = "ManualModeBT";
            this.ManualModeBT.Size = new System.Drawing.Size(126, 48);
            this.ManualModeBT.TabIndex = 34;
            this.ManualModeBT.Text = "Manual Mode";
            this.ManualModeBT.UseVisualStyleBackColor = true;
            this.ManualModeBT.Click += new System.EventHandler(this.ManualModeBT_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 410);
            this.Controls.Add(this.ManualModeBT);
            this.Controls.Add(this.HideCalculatedPBT);
            this.Controls.Add(this.CalculatedP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InternalClockCBP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterSizeCBP);
            this.Controls.Add(this.RegisterSizeTBP);
            this.Controls.Add(this.DesiredDelayLB);
            this.Controls.Add(this.DesiredDelayCBP);
            this.Controls.Add(this.DesiredDelayTBP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrescalerTBP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FOSCCBP);
            this.Controls.Add(this.FOSCTBP);
            this.Controls.Add(this.FormulasBT);
            this.Controls.Add(this.GenerateBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Timer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Timer Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.FOSCTBP.ResumeLayout(false);
            this.FOSCTBP.PerformLayout();
            this.FOSCCBP.ResumeLayout(false);
            this.PrescalerTBP.ResumeLayout(false);
            this.PrescalerTBP.PerformLayout();
            this.DesiredDelayCBP.ResumeLayout(false);
            this.DesiredDelayTBP.ResumeLayout(false);
            this.DesiredDelayTBP.PerformLayout();
            this.RegisterSizeCBP.ResumeLayout(false);
            this.RegisterSizeTBP.ResumeLayout(false);
            this.RegisterSizeTBP.PerformLayout();
            this.InternalClockCBP.ResumeLayout(false);
            this.CalculatedP.ResumeLayout(false);
            this.InstructionFrequencyGB.ResumeLayout(false);
            this.InstructionFrequencyGB.PerformLayout();
            this.DelayCountGB.ResumeLayout(false);
            this.DelayCountGB.PerformLayout();
            this.TimerFrequencyGB.ResumeLayout(false);
            this.TimerFrequencyGB.PerformLayout();
            this.TimerPeriodGB.ResumeLayout(false);
            this.TimerPeriodGB.PerformLayout();
            this.MaxDelayGB.ResumeLayout(false);
            this.MaxDelayGB.PerformLayout();
            this.MinDelayGB.ResumeLayout(false);
            this.MinDelayGB.PerformLayout();
            this.TickCounterGB.ResumeLayout(false);
            this.TickCounterGB.PerformLayout();
            this.RegisterValueGB.ResumeLayout(false);
            this.RegisterValueGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FOSCTB;
        private System.Windows.Forms.TextBox DesiredDelayTB;
        private System.Windows.Forms.ComboBox foscCB;
        private System.Windows.Forms.ComboBox DesiredDelayCB;
        private System.Windows.Forms.ComboBox RegisterSizeCB;
        private System.Windows.Forms.TextBox PrescalerTB;
        private System.Windows.Forms.Button FormulasBT;
        private System.Windows.Forms.TextBox RegisterSizeTB;
        private System.Windows.Forms.Panel FOSCTBP;
        private System.Windows.Forms.Panel FOSCCBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PrescalerTBP;
        private System.Windows.Forms.Label DesiredDelayLB;
        private System.Windows.Forms.Panel DesiredDelayCBP;
        private System.Windows.Forms.Panel DesiredDelayTBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel RegisterSizeCBP;
        private System.Windows.Forms.Panel RegisterSizeTBP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel InternalClockCBP;
        private System.Windows.Forms.ComboBox InternalClockCB;
        private System.Windows.Forms.Panel CalculatedP;
        private System.Windows.Forms.GroupBox RegisterValueGB;
        private System.Windows.Forms.GroupBox InstructionFrequencyGB;
        private System.Windows.Forms.TextBox InstructionFrequencyTB;
        private System.Windows.Forms.GroupBox DelayCountGB;
        private System.Windows.Forms.TextBox DelayCountTB;
        private System.Windows.Forms.GroupBox TimerFrequencyGB;
        private System.Windows.Forms.TextBox TimerFrequencyTB;
        private System.Windows.Forms.GroupBox TimerPeriodGB;
        private System.Windows.Forms.TextBox TimerPeriodTB;
        private System.Windows.Forms.GroupBox MaxDelayGB;
        private System.Windows.Forms.TextBox MaxDelayTB;
        private System.Windows.Forms.GroupBox MinDelayGB;
        private System.Windows.Forms.TextBox MinDelayTB;
        private System.Windows.Forms.GroupBox TickCounterGB;
        private System.Windows.Forms.TextBox TickCounterTB;
        private System.Windows.Forms.TextBox RegisterValueTB;
        private System.Windows.Forms.Button HideCalculatedPBT;
        private System.Windows.Forms.Button GenerateBT;
        private System.Windows.Forms.Button ManualModeBT;
    }
}

