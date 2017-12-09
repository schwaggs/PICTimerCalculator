using System;

namespace PICCalculators
{
    partial class ManualTimer
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
            this.components = new System.ComponentModel.Container();
            this.PrescalerTT = new System.Windows.Forms.ToolTip(this.components);
            this.PrescalerTRB = new System.Windows.Forms.TrackBar();
            this.PrescalerLB = new System.Windows.Forms.Label();
            this.PrescalerGB = new System.Windows.Forms.GroupBox();
            this.FOSCGB = new System.Windows.Forms.GroupBox();
            this.FOSCTRB = new System.Windows.Forms.TrackBar();
            this.FOSCLB = new System.Windows.Forms.Label();
            this.DesiredDelayGB = new System.Windows.Forms.GroupBox();
            this.DesiredDelayTB = new System.Windows.Forms.TextBox();
            this.RegisterSizeLB = new System.Windows.Forms.Label();
            this.RegisterSizeGB = new System.Windows.Forms.GroupBox();
            this.RegisterSizeTRB = new System.Windows.Forms.TrackBar();
            this.ClockDividerGB = new System.Windows.Forms.GroupBox();
            this.ClockDividerTRB = new System.Windows.Forms.TrackBar();
            this.ClockDividerLB = new System.Windows.Forms.Label();
            this.FOSCTT = new System.Windows.Forms.ToolTip(this.components);
            this.ClockDividerTT = new System.Windows.Forms.ToolTip(this.components);
            this.RegisterSizeTT = new System.Windows.Forms.ToolTip(this.components);
            this.RegisterValueGB = new System.Windows.Forms.GroupBox();
            this.RegisterValueTB = new System.Windows.Forms.TextBox();
            this.TickCounterGB = new System.Windows.Forms.GroupBox();
            this.TickCounterTB = new System.Windows.Forms.TextBox();
            this.MinDelayGB = new System.Windows.Forms.GroupBox();
            this.MinDelayTB = new System.Windows.Forms.TextBox();
            this.MaxDelayGB = new System.Windows.Forms.GroupBox();
            this.MaxDelayTB = new System.Windows.Forms.TextBox();
            this.TimerPeriodGB = new System.Windows.Forms.GroupBox();
            this.TimerPeriodTB = new System.Windows.Forms.TextBox();
            this.TimerFrequencyGB = new System.Windows.Forms.GroupBox();
            this.TimerFrequencyTB = new System.Windows.Forms.TextBox();
            this.DelayCountGB = new System.Windows.Forms.GroupBox();
            this.DelayCountTB = new System.Windows.Forms.TextBox();
            this.InstructionFrequencyGB = new System.Windows.Forms.GroupBox();
            this.InstructionFrequencyTB = new System.Windows.Forms.TextBox();
            this.CalculatedP = new System.Windows.Forms.Panel();
            this.RegisterValueHexTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrescalerTRB)).BeginInit();
            this.PrescalerGB.SuspendLayout();
            this.FOSCGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOSCTRB)).BeginInit();
            this.DesiredDelayGB.SuspendLayout();
            this.RegisterSizeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSizeTRB)).BeginInit();
            this.ClockDividerGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockDividerTRB)).BeginInit();
            this.RegisterValueGB.SuspendLayout();
            this.TickCounterGB.SuspendLayout();
            this.MinDelayGB.SuspendLayout();
            this.MaxDelayGB.SuspendLayout();
            this.TimerPeriodGB.SuspendLayout();
            this.TimerFrequencyGB.SuspendLayout();
            this.DelayCountGB.SuspendLayout();
            this.InstructionFrequencyGB.SuspendLayout();
            this.CalculatedP.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrescalerTRB
            // 
            this.PrescalerTRB.LargeChange = 1;
            this.PrescalerTRB.Location = new System.Drawing.Point(6, 19);
            this.PrescalerTRB.Maximum = 8;
            this.PrescalerTRB.Name = "PrescalerTRB";
            this.PrescalerTRB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PrescalerTRB.Size = new System.Drawing.Size(45, 258);
            this.PrescalerTRB.TabIndex = 0;
            this.PrescalerTRB.Scroll += new System.EventHandler(this.PrescalerTRB_Scroll);
            this.PrescalerTRB.ValueChanged += new System.EventHandler(this.PrescalerTRB_ValueChanged);
            this.PrescalerTRB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrescalerTRB_MouseUp);
            // 
            // PrescalerLB
            // 
            this.PrescalerLB.AutoSize = true;
            this.PrescalerLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescalerLB.Location = new System.Drawing.Point(184, 351);
            this.PrescalerLB.Name = "PrescalerLB";
            this.PrescalerLB.Size = new System.Drawing.Size(74, 37);
            this.PrescalerLB.TabIndex = 1;
            this.PrescalerLB.Text = "256";
            this.PrescalerLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrescalerGB
            // 
            this.PrescalerGB.Controls.Add(this.PrescalerTRB);
            this.PrescalerGB.Location = new System.Drawing.Point(182, 65);
            this.PrescalerGB.Name = "PrescalerGB";
            this.PrescalerGB.Size = new System.Drawing.Size(79, 283);
            this.PrescalerGB.TabIndex = 2;
            this.PrescalerGB.TabStop = false;
            this.PrescalerGB.Text = "Prescaler";
            // 
            // FOSCGB
            // 
            this.FOSCGB.Controls.Add(this.FOSCTRB);
            this.FOSCGB.Location = new System.Drawing.Point(5, 65);
            this.FOSCGB.Name = "FOSCGB";
            this.FOSCGB.Size = new System.Drawing.Size(80, 283);
            this.FOSCGB.TabIndex = 4;
            this.FOSCGB.TabStop = false;
            this.FOSCGB.Text = "FOSC (MHz)";
            // 
            // FOSCTRB
            // 
            this.FOSCTRB.LargeChange = 1;
            this.FOSCTRB.Location = new System.Drawing.Point(6, 19);
            this.FOSCTRB.Maximum = 8;
            this.FOSCTRB.Name = "FOSCTRB";
            this.FOSCTRB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FOSCTRB.Size = new System.Drawing.Size(45, 258);
            this.FOSCTRB.TabIndex = 0;
            this.FOSCTRB.Scroll += new System.EventHandler(this.FOSCTRB_Scroll);
            this.FOSCTRB.ValueChanged += new System.EventHandler(this.FOSCTRB_ValueChanged);
            this.FOSCTRB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FOSCTRB_MouseUp);
            // 
            // FOSCLB
            // 
            this.FOSCLB.AutoSize = true;
            this.FOSCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOSCLB.Location = new System.Drawing.Point(11, 351);
            this.FOSCLB.Name = "FOSCLB";
            this.FOSCLB.Size = new System.Drawing.Size(74, 37);
            this.FOSCLB.TabIndex = 3;
            this.FOSCLB.Text = "256";
            this.FOSCLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesiredDelayGB
            // 
            this.DesiredDelayGB.Controls.Add(this.DesiredDelayTB);
            this.DesiredDelayGB.Location = new System.Drawing.Point(5, 12);
            this.DesiredDelayGB.Name = "DesiredDelayGB";
            this.DesiredDelayGB.Size = new System.Drawing.Size(144, 47);
            this.DesiredDelayGB.TabIndex = 6;
            this.DesiredDelayGB.TabStop = false;
            this.DesiredDelayGB.Text = "Desired Delay (s)";
            // 
            // DesiredDelayTB
            // 
            this.DesiredDelayTB.Location = new System.Drawing.Point(6, 19);
            this.DesiredDelayTB.Name = "DesiredDelayTB";
            this.DesiredDelayTB.Size = new System.Drawing.Size(131, 20);
            this.DesiredDelayTB.TabIndex = 0;
            this.DesiredDelayTB.TextChanged += new System.EventHandler(this.DesiredDelayTB_TextChanged);
            // 
            // RegisterSizeLB
            // 
            this.RegisterSizeLB.AutoSize = true;
            this.RegisterSizeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSizeLB.Location = new System.Drawing.Point(286, 351);
            this.RegisterSizeLB.Name = "RegisterSizeLB";
            this.RegisterSizeLB.Size = new System.Drawing.Size(74, 37);
            this.RegisterSizeLB.TabIndex = 5;
            this.RegisterSizeLB.Text = "256";
            this.RegisterSizeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterSizeGB
            // 
            this.RegisterSizeGB.Controls.Add(this.RegisterSizeTRB);
            this.RegisterSizeGB.Location = new System.Drawing.Point(267, 65);
            this.RegisterSizeGB.Name = "RegisterSizeGB";
            this.RegisterSizeGB.Size = new System.Drawing.Size(112, 283);
            this.RegisterSizeGB.TabIndex = 8;
            this.RegisterSizeGB.TabStop = false;
            this.RegisterSizeGB.Text = "Register Size (Bits)";
            // 
            // RegisterSizeTRB
            // 
            this.RegisterSizeTRB.LargeChange = 1;
            this.RegisterSizeTRB.Location = new System.Drawing.Point(6, 19);
            this.RegisterSizeTRB.Maximum = 5;
            this.RegisterSizeTRB.Minimum = 3;
            this.RegisterSizeTRB.Name = "RegisterSizeTRB";
            this.RegisterSizeTRB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RegisterSizeTRB.Size = new System.Drawing.Size(45, 258);
            this.RegisterSizeTRB.TabIndex = 0;
            this.RegisterSizeTRB.Value = 3;
            this.RegisterSizeTRB.Scroll += new System.EventHandler(this.RegisterSizeTRB_Scroll);
            this.RegisterSizeTRB.ValueChanged += new System.EventHandler(this.RegisterSizeTRB_ValueChanged);
            this.RegisterSizeTRB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterSizeTRB_MouseUp);
            // 
            // ClockDividerGB
            // 
            this.ClockDividerGB.Controls.Add(this.ClockDividerTRB);
            this.ClockDividerGB.Location = new System.Drawing.Point(91, 65);
            this.ClockDividerGB.Name = "ClockDividerGB";
            this.ClockDividerGB.Size = new System.Drawing.Size(85, 283);
            this.ClockDividerGB.TabIndex = 10;
            this.ClockDividerGB.TabStop = false;
            this.ClockDividerGB.Text = "Clock Divider";
            // 
            // ClockDividerTRB
            // 
            this.ClockDividerTRB.LargeChange = 1;
            this.ClockDividerTRB.Location = new System.Drawing.Point(6, 19);
            this.ClockDividerTRB.Maximum = 2;
            this.ClockDividerTRB.Name = "ClockDividerTRB";
            this.ClockDividerTRB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ClockDividerTRB.Size = new System.Drawing.Size(45, 258);
            this.ClockDividerTRB.TabIndex = 0;
            this.ClockDividerTRB.Scroll += new System.EventHandler(this.ClockDividerTRB_Scroll);
            this.ClockDividerTRB.ValueChanged += new System.EventHandler(this.ClockDividerTRB_ValueChanged);
            this.ClockDividerTRB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClockDividerTRB_MouseUp);
            // 
            // ClockDividerLB
            // 
            this.ClockDividerLB.AutoSize = true;
            this.ClockDividerLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockDividerLB.Location = new System.Drawing.Point(99, 351);
            this.ClockDividerLB.Name = "ClockDividerLB";
            this.ClockDividerLB.Size = new System.Drawing.Size(74, 37);
            this.ClockDividerLB.TabIndex = 9;
            this.ClockDividerLB.Text = "256";
            this.ClockDividerLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterValueGB
            // 
            this.RegisterValueGB.Controls.Add(this.RegisterValueHexTB);
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
            this.RegisterValueTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterValueTB.Location = new System.Drawing.Point(12, 20);
            this.RegisterValueTB.Name = "RegisterValueTB";
            this.RegisterValueTB.Size = new System.Drawing.Size(194, 15);
            this.RegisterValueTB.TabIndex = 0;
            this.RegisterValueTB.TextChanged += new System.EventHandler(this.RegisterValueTB_TextChanged);
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
            this.TickCounterTB.Size = new System.Drawing.Size(383, 15);
            this.TickCounterTB.TabIndex = 0;
            this.TickCounterTB.TextChanged += new System.EventHandler(this.TickCounterTB_TextChanged);
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
            this.MinDelayGB.Text = "Minimum Delay (s)";
            // 
            // MinDelayTB
            // 
            this.MinDelayTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinDelayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDelayTB.Location = new System.Drawing.Point(12, 21);
            this.MinDelayTB.Name = "MinDelayTB";
            this.MinDelayTB.Size = new System.Drawing.Size(383, 15);
            this.MinDelayTB.TabIndex = 0;
            this.MinDelayTB.TextChanged += new System.EventHandler(this.MinDelayTB_TextChanged);
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
            this.MaxDelayGB.Text = "Maximum Delay (s)";
            // 
            // MaxDelayTB
            // 
            this.MaxDelayTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxDelayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDelayTB.Location = new System.Drawing.Point(12, 20);
            this.MaxDelayTB.Name = "MaxDelayTB";
            this.MaxDelayTB.Size = new System.Drawing.Size(383, 15);
            this.MaxDelayTB.TabIndex = 0;
            this.MaxDelayTB.TextChanged += new System.EventHandler(this.MaxDelayTB_TextChanged);
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
            this.TimerPeriodGB.Text = "Timer Period (s)";
            // 
            // TimerPeriodTB
            // 
            this.TimerPeriodTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimerPeriodTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPeriodTB.Location = new System.Drawing.Point(12, 21);
            this.TimerPeriodTB.Name = "TimerPeriodTB";
            this.TimerPeriodTB.Size = new System.Drawing.Size(383, 15);
            this.TimerPeriodTB.TabIndex = 0;
            this.TimerPeriodTB.TextChanged += new System.EventHandler(this.TimerPeriodTB_TextChanged);
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
            this.TimerFrequencyGB.Text = "Timer Frequency (Hz)";
            // 
            // TimerFrequencyTB
            // 
            this.TimerFrequencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimerFrequencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerFrequencyTB.Location = new System.Drawing.Point(12, 21);
            this.TimerFrequencyTB.Name = "TimerFrequencyTB";
            this.TimerFrequencyTB.Size = new System.Drawing.Size(383, 15);
            this.TimerFrequencyTB.TabIndex = 0;
            this.TimerFrequencyTB.TextChanged += new System.EventHandler(this.TimerFrequencyTB_TextChanged);
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
            this.DelayCountTB.Size = new System.Drawing.Size(383, 15);
            this.DelayCountTB.TabIndex = 0;
            this.DelayCountTB.TextChanged += new System.EventHandler(this.DelayCountTB_TextChanged);
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
            this.InstructionFrequencyGB.Text = "Instruction Frequency (Hz)";
            // 
            // InstructionFrequencyTB
            // 
            this.InstructionFrequencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionFrequencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionFrequencyTB.Location = new System.Drawing.Point(12, 21);
            this.InstructionFrequencyTB.Name = "InstructionFrequencyTB";
            this.InstructionFrequencyTB.Size = new System.Drawing.Size(383, 15);
            this.InstructionFrequencyTB.TabIndex = 0;
            this.InstructionFrequencyTB.TextChanged += new System.EventHandler(this.InstructionFrequencyTB_TextChanged);
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
            this.CalculatedP.Location = new System.Drawing.Point(423, 12);
            this.CalculatedP.Name = "CalculatedP";
            this.CalculatedP.Size = new System.Drawing.Size(412, 396);
            this.CalculatedP.TabIndex = 34;
            // 
            // RegisterValueHexTB
            // 
            this.RegisterValueHexTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegisterValueHexTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterValueHexTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterValueHexTB.Location = new System.Drawing.Point(212, 20);
            this.RegisterValueHexTB.Name = "RegisterValueHexTB";
            this.RegisterValueHexTB.Size = new System.Drawing.Size(183, 15);
            this.RegisterValueHexTB.TabIndex = 1;
            // 
            // ManualTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 410);
            this.Controls.Add(this.CalculatedP);
            this.Controls.Add(this.ClockDividerGB);
            this.Controls.Add(this.ClockDividerLB);
            this.Controls.Add(this.RegisterSizeGB);
            this.Controls.Add(this.DesiredDelayGB);
            this.Controls.Add(this.RegisterSizeLB);
            this.Controls.Add(this.FOSCGB);
            this.Controls.Add(this.FOSCLB);
            this.Controls.Add(this.PrescalerGB);
            this.Controls.Add(this.PrescalerLB);
            this.Name = "ManualTimer";
            this.Text = "Manual Timer Mode";
            ((System.ComponentModel.ISupportInitialize)(this.PrescalerTRB)).EndInit();
            this.PrescalerGB.ResumeLayout(false);
            this.PrescalerGB.PerformLayout();
            this.FOSCGB.ResumeLayout(false);
            this.FOSCGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOSCTRB)).EndInit();
            this.DesiredDelayGB.ResumeLayout(false);
            this.DesiredDelayGB.PerformLayout();
            this.RegisterSizeGB.ResumeLayout(false);
            this.RegisterSizeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSizeTRB)).EndInit();
            this.ClockDividerGB.ResumeLayout(false);
            this.ClockDividerGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockDividerTRB)).EndInit();
            this.RegisterValueGB.ResumeLayout(false);
            this.RegisterValueGB.PerformLayout();
            this.TickCounterGB.ResumeLayout(false);
            this.TickCounterGB.PerformLayout();
            this.MinDelayGB.ResumeLayout(false);
            this.MinDelayGB.PerformLayout();
            this.MaxDelayGB.ResumeLayout(false);
            this.MaxDelayGB.PerformLayout();
            this.TimerPeriodGB.ResumeLayout(false);
            this.TimerPeriodGB.PerformLayout();
            this.TimerFrequencyGB.ResumeLayout(false);
            this.TimerFrequencyGB.PerformLayout();
            this.DelayCountGB.ResumeLayout(false);
            this.DelayCountGB.PerformLayout();
            this.InstructionFrequencyGB.ResumeLayout(false);
            this.InstructionFrequencyGB.PerformLayout();
            this.CalculatedP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip PrescalerTT;
        private System.Windows.Forms.TrackBar PrescalerTRB;
        private System.Windows.Forms.Label PrescalerLB;
        private System.Windows.Forms.GroupBox PrescalerGB;
        private System.Windows.Forms.GroupBox FOSCGB;
        private System.Windows.Forms.TrackBar FOSCTRB;
        private System.Windows.Forms.Label FOSCLB;
        private System.Windows.Forms.GroupBox DesiredDelayGB;
        private System.Windows.Forms.TextBox DesiredDelayTB;
        private System.Windows.Forms.Label RegisterSizeLB;
        private System.Windows.Forms.GroupBox RegisterSizeGB;
        private System.Windows.Forms.TrackBar RegisterSizeTRB;
        private System.Windows.Forms.GroupBox ClockDividerGB;
        private System.Windows.Forms.TrackBar ClockDividerTRB;
        private System.Windows.Forms.Label ClockDividerLB;
        private System.Windows.Forms.ToolTip FOSCTT;
        private System.Windows.Forms.ToolTip ClockDividerTT;
        private System.Windows.Forms.ToolTip RegisterSizeTT;
        private System.Windows.Forms.GroupBox RegisterValueGB;
        private System.Windows.Forms.TextBox RegisterValueTB;
        private System.Windows.Forms.GroupBox TickCounterGB;
        private System.Windows.Forms.TextBox TickCounterTB;
        private System.Windows.Forms.GroupBox MinDelayGB;
        private System.Windows.Forms.TextBox MinDelayTB;
        private System.Windows.Forms.GroupBox MaxDelayGB;
        private System.Windows.Forms.TextBox MaxDelayTB;
        private System.Windows.Forms.GroupBox TimerPeriodGB;
        private System.Windows.Forms.TextBox TimerPeriodTB;
        private System.Windows.Forms.GroupBox TimerFrequencyGB;
        private System.Windows.Forms.TextBox TimerFrequencyTB;
        private System.Windows.Forms.GroupBox DelayCountGB;
        private System.Windows.Forms.TextBox DelayCountTB;
        private System.Windows.Forms.GroupBox InstructionFrequencyGB;
        private System.Windows.Forms.TextBox InstructionFrequencyTB;
        private System.Windows.Forms.Panel CalculatedP;
        private System.Windows.Forms.TextBox RegisterValueHexTB;
    }
}