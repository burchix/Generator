using Generator.Models;
using System;

namespace Generator
{
    partial class Generator
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
            this.generateButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.noOfVariablesLabel = new System.Windows.Forms.Label();
            this.noOfVariableUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxLengthClauseUpDown = new System.Windows.Forms.NumericUpDown();
            this.successLabel = new System.Windows.Forms.Label();
            this.generatorTypeLabel = new System.Windows.Forms.Label();
            this.generatorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fixedNoClausesUpDown = new System.Windows.Forms.NumericUpDown();
            this.lengthGroupBox = new System.Windows.Forms.GroupBox();
            this.fixedLengthClauseUpDown = new System.Windows.Forms.NumericUpDown();
            this.avgLengthClauseUpDown = new System.Windows.Forms.NumericUpDown();
            this.fixedLengthClauseRadioButton = new System.Windows.Forms.RadioButton();
            this.avgLengthClauseRadioButton = new System.Windows.Forms.RadioButton();
            this.maxLengthClauseRadioButton = new System.Windows.Forms.RadioButton();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.easyUnsatLabel = new System.Windows.Forms.Label();
            this.easySatLlabel = new System.Windows.Forms.Label();
            this.relativeNoClausesUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxNoClausesUpDown = new System.Windows.Forms.NumericUpDown();
            this.fixedNoClausesRadioButton = new System.Windows.Forms.RadioButton();
            this.relativeNoClausesRadioButton = new System.Windows.Forms.RadioButton();
            this.maxNoClausesRadioButton = new System.Windows.Forms.RadioButton();
            this.noClausesTrackBar = new System.Windows.Forms.TrackBar();
            this.extraGroupBox = new System.Windows.Forms.GroupBox();
            this.negPropUpDown = new System.Windows.Forms.NumericUpDown();
            this.negPropLabel = new System.Windows.Forms.Label();
            this.repetitionsLabel = new System.Windows.Forms.Label();
            this.repetitionsUpDown = new System.Windows.Forms.NumericUpDown();
            this.basicGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthClauseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedNoClausesUpDown)).BeginInit();
            this.lengthGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedLengthClauseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgLengthClauseUpDown)).BeginInit();
            this.numberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeNoClausesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNoClausesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noClausesTrackBar)).BeginInit();
            this.extraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negPropUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitionsUpDown)).BeginInit();
            this.basicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.BackColor = System.Drawing.Color.DarkRed;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.generateButton.Location = new System.Drawing.Point(640, 359);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(118, 59);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(7, 25);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(88, 20);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(168, 22);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(230, 26);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.Text = "outputFile";
            // 
            // noOfVariablesLabel
            // 
            this.noOfVariablesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noOfVariablesLabel.AutoSize = true;
            this.noOfVariablesLabel.Location = new System.Drawing.Point(7, 60);
            this.noOfVariablesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noOfVariablesLabel.Name = "noOfVariablesLabel";
            this.noOfVariablesLabel.Size = new System.Drawing.Size(153, 20);
            this.noOfVariablesLabel.TabIndex = 3;
            this.noOfVariablesLabel.Text = "Number of Variables";
            // 
            // noOfVariableUpDown
            // 
            this.noOfVariableUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noOfVariableUpDown.Location = new System.Drawing.Point(168, 58);
            this.noOfVariableUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noOfVariableUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.noOfVariableUpDown.Name = "noOfVariableUpDown";
            this.noOfVariableUpDown.Size = new System.Drawing.Size(230, 26);
            this.noOfVariableUpDown.TabIndex = 4;
            // 
            // maxLengthClauseUpDown
            // 
            this.maxLengthClauseUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLengthClauseUpDown.Location = new System.Drawing.Point(511, 27);
            this.maxLengthClauseUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxLengthClauseUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxLengthClauseUpDown.Name = "maxLengthClauseUpDown";
            this.maxLengthClauseUpDown.Size = new System.Drawing.Size(226, 26);
            this.maxLengthClauseUpDown.TabIndex = 6;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(772, 698);
            this.successLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLabel.MaximumSize = new System.Drawing.Size(1500, 1538);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 20);
            this.successLabel.TabIndex = 7;
            // 
            // generatorTypeLabel
            // 
            this.generatorTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatorTypeLabel.AutoSize = true;
            this.generatorTypeLabel.Location = new System.Drawing.Point(7, 25);
            this.generatorTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generatorTypeLabel.Name = "generatorTypeLabel";
            this.generatorTypeLabel.Size = new System.Drawing.Size(120, 20);
            this.generatorTypeLabel.TabIndex = 8;
            this.generatorTypeLabel.Text = "Generator Type";
            // 
            // generatorTypeComboBox
            // 
            this.generatorTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatorTypeComboBox.Location = new System.Drawing.Point(179, 22);
            this.generatorTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generatorTypeComboBox.Name = "generatorTypeComboBox";
            this.generatorTypeComboBox.Size = new System.Drawing.Size(147, 28);
            this.generatorTypeComboBox.TabIndex = 9;
            // 
            // fixedNoClausesUpDown
            // 
            this.fixedNoClausesUpDown.Location = new System.Drawing.Point(511, 25);
            this.fixedNoClausesUpDown.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.fixedNoClausesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fixedNoClausesUpDown.Name = "fixedNoClausesUpDown";
            this.fixedNoClausesUpDown.Size = new System.Drawing.Size(226, 26);
            this.fixedNoClausesUpDown.TabIndex = 15;
            this.fixedNoClausesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fixedNoClausesUpDown.Visible = false;
            // 
            // lengthGroupBox
            // 
            this.lengthGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthGroupBox.Controls.Add(this.fixedLengthClauseUpDown);
            this.lengthGroupBox.Controls.Add(this.avgLengthClauseUpDown);
            this.lengthGroupBox.Controls.Add(this.fixedLengthClauseRadioButton);
            this.lengthGroupBox.Controls.Add(this.avgLengthClauseRadioButton);
            this.lengthGroupBox.Controls.Add(this.maxLengthClauseRadioButton);
            this.lengthGroupBox.Controls.Add(this.maxLengthClauseUpDown);
            this.lengthGroupBox.Location = new System.Drawing.Point(12, 283);
            this.lengthGroupBox.Name = "lengthGroupBox";
            this.lengthGroupBox.Size = new System.Drawing.Size(744, 69);
            this.lengthGroupBox.TabIndex = 17;
            this.lengthGroupBox.TabStop = false;
            this.lengthGroupBox.Text = "Length of Clause Settings";
            // 
            // fixedLengthClauseUpDown
            // 
            this.fixedLengthClauseUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fixedLengthClauseUpDown.Location = new System.Drawing.Point(511, 27);
            this.fixedLengthClauseUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fixedLengthClauseUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fixedLengthClauseUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fixedLengthClauseUpDown.Name = "fixedLengthClauseUpDown";
            this.fixedLengthClauseUpDown.Size = new System.Drawing.Size(226, 26);
            this.fixedLengthClauseUpDown.TabIndex = 11;
            this.fixedLengthClauseUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fixedLengthClauseUpDown.Visible = false;
            // 
            // avgLengthClauseUpDown
            // 
            this.avgLengthClauseUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgLengthClauseUpDown.Location = new System.Drawing.Point(511, 27);
            this.avgLengthClauseUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avgLengthClauseUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avgLengthClauseUpDown.Name = "avgLengthClauseUpDown";
            this.avgLengthClauseUpDown.Size = new System.Drawing.Size(226, 26);
            this.avgLengthClauseUpDown.TabIndex = 10;
            this.avgLengthClauseUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avgLengthClauseUpDown.Visible = false;
            // 
            // fixedLengthClauseRadioButton
            // 
            this.fixedLengthClauseRadioButton.AutoSize = true;
            this.fixedLengthClauseRadioButton.Location = new System.Drawing.Point(11, 29);
            this.fixedLengthClauseRadioButton.Name = "fixedLengthClauseRadioButton";
            this.fixedLengthClauseRadioButton.Size = new System.Drawing.Size(72, 24);
            this.fixedLengthClauseRadioButton.TabIndex = 9;
            this.fixedLengthClauseRadioButton.Text = "Fixed";
            this.fixedLengthClauseRadioButton.UseVisualStyleBackColor = true;
            this.fixedLengthClauseRadioButton.CheckedChanged += new System.EventHandler(this.fixedLengthClauseRadioButton_CheckedChanged);
            // 
            // avgLengthClauseRadioButton
            // 
            this.avgLengthClauseRadioButton.AutoSize = true;
            this.avgLengthClauseRadioButton.Location = new System.Drawing.Point(272, 29);
            this.avgLengthClauseRadioButton.Name = "avgLengthClauseRadioButton";
            this.avgLengthClauseRadioButton.Size = new System.Drawing.Size(93, 24);
            this.avgLengthClauseRadioButton.TabIndex = 8;
            this.avgLengthClauseRadioButton.Text = "Average";
            this.avgLengthClauseRadioButton.UseVisualStyleBackColor = true;
            this.avgLengthClauseRadioButton.CheckedChanged += new System.EventHandler(this.avgLengthClauseRadioButton_CheckedChanged);
            // 
            // maxLengthClauseRadioButton
            // 
            this.maxLengthClauseRadioButton.AutoSize = true;
            this.maxLengthClauseRadioButton.Checked = true;
            this.maxLengthClauseRadioButton.Location = new System.Drawing.Point(151, 29);
            this.maxLengthClauseRadioButton.Name = "maxLengthClauseRadioButton";
            this.maxLengthClauseRadioButton.Size = new System.Drawing.Size(63, 24);
            this.maxLengthClauseRadioButton.TabIndex = 7;
            this.maxLengthClauseRadioButton.TabStop = true;
            this.maxLengthClauseRadioButton.Text = "Max";
            this.maxLengthClauseRadioButton.UseVisualStyleBackColor = true;
            this.maxLengthClauseRadioButton.CheckedChanged += new System.EventHandler(this.maxlengthClauseRadioButton_CheckedChanged);
            // 
            // numberGroupBox
            // 
            this.numberGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberGroupBox.Controls.Add(this.easyUnsatLabel);
            this.numberGroupBox.Controls.Add(this.easySatLlabel);
            this.numberGroupBox.Controls.Add(this.relativeNoClausesUpDown);
            this.numberGroupBox.Controls.Add(this.maxNoClausesUpDown);
            this.numberGroupBox.Controls.Add(this.fixedNoClausesRadioButton);
            this.numberGroupBox.Controls.Add(this.relativeNoClausesRadioButton);
            this.numberGroupBox.Controls.Add(this.maxNoClausesRadioButton);
            this.numberGroupBox.Controls.Add(this.noClausesTrackBar);
            this.numberGroupBox.Controls.Add(this.fixedNoClausesUpDown);
            this.numberGroupBox.Location = new System.Drawing.Point(12, 144);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(744, 133);
            this.numberGroupBox.TabIndex = 18;
            this.numberGroupBox.TabStop = false;
            this.numberGroupBox.Text = "Number of Clauses Settings";
            // 
            // easyUnsatLabel
            // 
            this.easyUnsatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyUnsatLabel.AutoSize = true;
            this.easyUnsatLabel.Location = new System.Drawing.Point(638, 104);
            this.easyUnsatLabel.Name = "easyUnsatLabel";
            this.easyUnsatLabel.Size = new System.Drawing.Size(100, 20);
            this.easyUnsatLabel.TabIndex = 22;
            this.easyUnsatLabel.Text = "easy UNSAT";
            // 
            // easySatLlabel
            // 
            this.easySatLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easySatLlabel.AutoSize = true;
            this.easySatLlabel.Location = new System.Drawing.Point(7, 104);
            this.easySatLlabel.Name = "easySatLlabel";
            this.easySatLlabel.Size = new System.Drawing.Size(77, 20);
            this.easySatLlabel.TabIndex = 21;
            this.easySatLlabel.Text = "easy SAT";
            // 
            // relativeNoClausesUpDown
            // 
            this.relativeNoClausesUpDown.DecimalPlaces = 2;
            this.relativeNoClausesUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.relativeNoClausesUpDown.Location = new System.Drawing.Point(511, 25);
            this.relativeNoClausesUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.relativeNoClausesUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.relativeNoClausesUpDown.Name = "relativeNoClausesUpDown";
            this.relativeNoClausesUpDown.Size = new System.Drawing.Size(226, 26);
            this.relativeNoClausesUpDown.TabIndex = 20;
            this.relativeNoClausesUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.relativeNoClausesUpDown.Visible = false;
            this.relativeNoClausesUpDown.ValueChanged += new System.EventHandler(this.relativeNoClausesUpDown_ValueChanged);
            // 
            // maxNoClausesUpDown
            // 
            this.maxNoClausesUpDown.Location = new System.Drawing.Point(511, 25);
            this.maxNoClausesUpDown.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.maxNoClausesUpDown.Name = "maxNoClausesUpDown";
            this.maxNoClausesUpDown.Size = new System.Drawing.Size(226, 26);
            this.maxNoClausesUpDown.TabIndex = 19;
            // 
            // fixedNoClausesRadioButton
            // 
            this.fixedNoClausesRadioButton.AutoSize = true;
            this.fixedNoClausesRadioButton.Location = new System.Drawing.Point(11, 25);
            this.fixedNoClausesRadioButton.Name = "fixedNoClausesRadioButton";
            this.fixedNoClausesRadioButton.Size = new System.Drawing.Size(72, 24);
            this.fixedNoClausesRadioButton.TabIndex = 18;
            this.fixedNoClausesRadioButton.Text = "Fixed";
            this.fixedNoClausesRadioButton.UseVisualStyleBackColor = true;
            this.fixedNoClausesRadioButton.CheckedChanged += new System.EventHandler(this.fixedNoClausesRadioButton_CheckedChanged);
            // 
            // relativeNoClausesRadioButton
            // 
            this.relativeNoClausesRadioButton.AutoSize = true;
            this.relativeNoClausesRadioButton.Location = new System.Drawing.Point(272, 25);
            this.relativeNoClausesRadioButton.Name = "relativeNoClausesRadioButton";
            this.relativeNoClausesRadioButton.Size = new System.Drawing.Size(91, 24);
            this.relativeNoClausesRadioButton.TabIndex = 17;
            this.relativeNoClausesRadioButton.Text = "Relative";
            this.relativeNoClausesRadioButton.UseVisualStyleBackColor = true;
            this.relativeNoClausesRadioButton.CheckedChanged += new System.EventHandler(this.relativeNoClausesRadioButton_CheckedChanged);
            // 
            // maxNoClausesRadioButton
            // 
            this.maxNoClausesRadioButton.AutoSize = true;
            this.maxNoClausesRadioButton.Checked = true;
            this.maxNoClausesRadioButton.Location = new System.Drawing.Point(151, 25);
            this.maxNoClausesRadioButton.Name = "maxNoClausesRadioButton";
            this.maxNoClausesRadioButton.Size = new System.Drawing.Size(63, 24);
            this.maxNoClausesRadioButton.TabIndex = 16;
            this.maxNoClausesRadioButton.TabStop = true;
            this.maxNoClausesRadioButton.Text = "Max";
            this.maxNoClausesRadioButton.UseVisualStyleBackColor = true;
            this.maxNoClausesRadioButton.CheckedChanged += new System.EventHandler(this.maxNoClausesRadioButton_CheckedChanged);
            // 
            // noClausesTrackBar
            // 
            this.noClausesTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noClausesTrackBar.Enabled = false;
            this.noClausesTrackBar.Location = new System.Drawing.Point(6, 56);
            this.noClausesTrackBar.Maximum = 800;
            this.noClausesTrackBar.Minimum = 200;
            this.noClausesTrackBar.Name = "noClausesTrackBar";
            this.noClausesTrackBar.Size = new System.Drawing.Size(732, 69);
            this.noClausesTrackBar.TabIndex = 0;
            this.noClausesTrackBar.Value = 200;
            this.noClausesTrackBar.Scroll += new System.EventHandler(this.noClausesTrackBar_Scroll);
            // 
            // extraGroupBox
            // 
            this.extraGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extraGroupBox.Controls.Add(this.negPropUpDown);
            this.extraGroupBox.Controls.Add(this.negPropLabel);
            this.extraGroupBox.Controls.Add(this.repetitionsLabel);
            this.extraGroupBox.Controls.Add(this.repetitionsUpDown);
            this.extraGroupBox.Controls.Add(this.generatorTypeLabel);
            this.extraGroupBox.Controls.Add(this.generatorTypeComboBox);
            this.extraGroupBox.Location = new System.Drawing.Point(423, 12);
            this.extraGroupBox.Name = "extraGroupBox";
            this.extraGroupBox.Size = new System.Drawing.Size(333, 126);
            this.extraGroupBox.TabIndex = 19;
            this.extraGroupBox.TabStop = false;
            this.extraGroupBox.Text = "Additional Settings";
            // 
            // negPropUpDown
            // 
            this.negPropUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negPropUpDown.DecimalPlaces = 2;
            this.negPropUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.negPropUpDown.Location = new System.Drawing.Point(179, 90);
            this.negPropUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.negPropUpDown.Name = "negPropUpDown";
            this.negPropUpDown.Size = new System.Drawing.Size(147, 26);
            this.negPropUpDown.TabIndex = 23;
            this.negPropUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // negPropLabel
            // 
            this.negPropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negPropLabel.AutoSize = true;
            this.negPropLabel.Location = new System.Drawing.Point(7, 92);
            this.negPropLabel.Name = "negPropLabel";
            this.negPropLabel.Size = new System.Drawing.Size(149, 20);
            this.negPropLabel.TabIndex = 22;
            this.negPropLabel.Text = "Negation Propability";
            // 
            // repetitionsLabel
            // 
            this.repetitionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repetitionsLabel.AutoSize = true;
            this.repetitionsLabel.Location = new System.Drawing.Point(7, 60);
            this.repetitionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repetitionsLabel.Name = "repetitionsLabel";
            this.repetitionsLabel.Size = new System.Drawing.Size(165, 20);
            this.repetitionsLabel.TabIndex = 21;
            this.repetitionsLabel.Text = "Number of Repetitons";
            // 
            // repetitionsUpDown
            // 
            this.repetitionsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repetitionsUpDown.Location = new System.Drawing.Point(179, 58);
            this.repetitionsUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.repetitionsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repetitionsUpDown.Name = "repetitionsUpDown";
            this.repetitionsUpDown.Size = new System.Drawing.Size(148, 26);
            this.repetitionsUpDown.TabIndex = 20;
            this.repetitionsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // basicGroupBox
            // 
            this.basicGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicGroupBox.Controls.Add(this.fileNameLabel);
            this.basicGroupBox.Controls.Add(this.noOfVariablesLabel);
            this.basicGroupBox.Controls.Add(this.fileNameTextBox);
            this.basicGroupBox.Controls.Add(this.noOfVariableUpDown);
            this.basicGroupBox.Location = new System.Drawing.Point(12, 12);
            this.basicGroupBox.Name = "basicGroupBox";
            this.basicGroupBox.Size = new System.Drawing.Size(405, 126);
            this.basicGroupBox.TabIndex = 20;
            this.basicGroupBox.TabStop = false;
            this.basicGroupBox.Text = "Basic Settings";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.Controls.Add(this.basicGroupBox);
            this.Controls.Add(this.extraGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.lengthGroupBox);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.generateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Generator";
            this.Text = "Simple DIMACS Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthClauseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedNoClausesUpDown)).EndInit();
            this.lengthGroupBox.ResumeLayout(false);
            this.lengthGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedLengthClauseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgLengthClauseUpDown)).EndInit();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeNoClausesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNoClausesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noClausesTrackBar)).EndInit();
            this.extraGroupBox.ResumeLayout(false);
            this.extraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negPropUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitionsUpDown)).EndInit();
            this.basicGroupBox.ResumeLayout(false);
            this.basicGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label noOfVariablesLabel;
        private System.Windows.Forms.NumericUpDown noOfVariableUpDown;
        private System.Windows.Forms.NumericUpDown maxLengthClauseUpDown;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label generatorTypeLabel;
        private System.Windows.Forms.ComboBox generatorTypeComboBox;
        private System.Windows.Forms.NumericUpDown fixedNoClausesUpDown;
        private System.Windows.Forms.GroupBox lengthGroupBox;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.TrackBar noClausesTrackBar;
        private System.Windows.Forms.GroupBox extraGroupBox;
        private System.Windows.Forms.Label repetitionsLabel;
        private System.Windows.Forms.NumericUpDown repetitionsUpDown;
        private System.Windows.Forms.GroupBox basicGroupBox;
        private System.Windows.Forms.RadioButton fixedLengthClauseRadioButton;
        private System.Windows.Forms.RadioButton avgLengthClauseRadioButton;
        private System.Windows.Forms.RadioButton maxLengthClauseRadioButton;
        private System.Windows.Forms.RadioButton fixedNoClausesRadioButton;
        private System.Windows.Forms.RadioButton relativeNoClausesRadioButton;
        private System.Windows.Forms.RadioButton maxNoClausesRadioButton;
        private System.Windows.Forms.NumericUpDown maxNoClausesUpDown;
        private System.Windows.Forms.NumericUpDown avgLengthClauseUpDown;
        private System.Windows.Forms.NumericUpDown fixedLengthClauseUpDown;
        private System.Windows.Forms.NumericUpDown relativeNoClausesUpDown;
        private System.Windows.Forms.NumericUpDown negPropUpDown;
        private System.Windows.Forms.Label negPropLabel;
        private System.Windows.Forms.Label easyUnsatLabel;
        private System.Windows.Forms.Label easySatLlabel;
    }
}

