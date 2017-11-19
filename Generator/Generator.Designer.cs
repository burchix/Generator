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
            this.maxLengthOfClauseLabel = new System.Windows.Forms.Label();
            this.maxLengthOfClauseUpDown = new System.Windows.Forms.NumericUpDown();
            this.successLabel = new System.Windows.Forms.Label();
            this.generatorTypeLabel = new System.Windows.Forms.Label();
            this.generatorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.discreteRadioButton = new System.Windows.Forms.RadioButton();
            this.continousRadioButton = new System.Windows.Forms.RadioButton();
            this.discreteComboBox = new System.Windows.Forms.ComboBox();
            this.continousComboBox = new System.Windows.Forms.ComboBox();
            this.noOfClausesLabel = new System.Windows.Forms.Label();
            this.noOfClausesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthOfClauseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfClausesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.BackColor = System.Drawing.Color.DarkRed;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.generateButton.Location = new System.Drawing.Point(787, 218);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(160, 97);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(20, 10);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(88, 20);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(195, 10);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(224, 26);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.Text = "outputFile";
            // 
            // noOfVariablesLabel
            // 
            this.noOfVariablesLabel.AutoSize = true;
            this.noOfVariablesLabel.Location = new System.Drawing.Point(20, 50);
            this.noOfVariablesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noOfVariablesLabel.Name = "noOfVariablesLabel";
            this.noOfVariablesLabel.Size = new System.Drawing.Size(153, 20);
            this.noOfVariablesLabel.TabIndex = 3;
            this.noOfVariablesLabel.Text = "Number of Variables";
            // 
            // noOfVariableUpDown
            // 
            this.noOfVariableUpDown.Location = new System.Drawing.Point(195, 50);
            this.noOfVariableUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noOfVariableUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.noOfVariableUpDown.Name = "noOfVariableUpDown";
            this.noOfVariableUpDown.Size = new System.Drawing.Size(226, 26);
            this.noOfVariableUpDown.TabIndex = 4;
            // 
            // maxLengthOfClauseLabel
            // 
            this.maxLengthOfClauseLabel.AutoSize = true;
            this.maxLengthOfClauseLabel.Location = new System.Drawing.Point(20, 90);
            this.maxLengthOfClauseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLengthOfClauseLabel.Name = "maxLengthOfClauseLabel";
            this.maxLengthOfClauseLabel.Size = new System.Drawing.Size(166, 20);
            this.maxLengthOfClauseLabel.TabIndex = 5;
            this.maxLengthOfClauseLabel.Text = "Max Length Of Clause";
            // 
            // maxLengthOfClauseUpDown
            // 
            this.maxLengthOfClauseUpDown.Location = new System.Drawing.Point(195, 90);
            this.maxLengthOfClauseUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxLengthOfClauseUpDown.Name = "maxLengthOfClauseUpDown";
            this.maxLengthOfClauseUpDown.Size = new System.Drawing.Size(226, 26);
            this.maxLengthOfClauseUpDown.TabIndex = 6;
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
            this.generatorTypeLabel.AutoSize = true;
            this.generatorTypeLabel.Location = new System.Drawing.Point(522, 10);
            this.generatorTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generatorTypeLabel.Name = "generatorTypeLabel";
            this.generatorTypeLabel.Size = new System.Drawing.Size(120, 20);
            this.generatorTypeLabel.TabIndex = 8;
            this.generatorTypeLabel.Text = "Generator Type";
            // 
            // generatorTypeComboBox
            // 
            this.generatorTypeComboBox.Location = new System.Drawing.Point(650, 10);
            this.generatorTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generatorTypeComboBox.Name = "generatorTypeComboBox";
            this.generatorTypeComboBox.Size = new System.Drawing.Size(295, 28);
            this.generatorTypeComboBox.TabIndex = 9;
            // 
            // discreteRadioButton
            // 
            this.discreteRadioButton.AutoSize = true;
            this.discreteRadioButton.Checked = true;
            this.discreteRadioButton.Location = new System.Drawing.Point(465, 50);
            this.discreteRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discreteRadioButton.Name = "discreteRadioButton";
            this.discreteRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discreteRadioButton.Size = new System.Drawing.Size(177, 24);
            this.discreteRadioButton.TabIndex = 10;
            this.discreteRadioButton.TabStop = true;
            this.discreteRadioButton.Text = "Discrete Distribution";
            this.discreteRadioButton.UseVisualStyleBackColor = true;
            this.discreteRadioButton.CheckedChanged += new System.EventHandler(this.discreteRadioButton_CheckedChanged);
            // 
            // continousRadioButton
            // 
            this.continousRadioButton.AutoSize = true;
            this.continousRadioButton.Location = new System.Drawing.Point(452, 90);
            this.continousRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continousRadioButton.Name = "continousRadioButton";
            this.continousRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.continousRadioButton.Size = new System.Drawing.Size(190, 24);
            this.continousRadioButton.TabIndex = 11;
            this.continousRadioButton.Text = "Continous Distribution";
            this.continousRadioButton.UseVisualStyleBackColor = true;
            this.continousRadioButton.CheckedChanged += new System.EventHandler(this.continousRadioButton_CheckedChanged);
            // 
            // discreteComboBox
            // 
            this.discreteComboBox.FormattingEnabled = true;
            this.discreteComboBox.Location = new System.Drawing.Point(650, 50);
            this.discreteComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discreteComboBox.Name = "discreteComboBox";
            this.discreteComboBox.Size = new System.Drawing.Size(295, 28);
            this.discreteComboBox.TabIndex = 12;
            // 
            // continousComboBox
            // 
            this.continousComboBox.Enabled = false;
            this.continousComboBox.FormattingEnabled = true;
            this.continousComboBox.Location = new System.Drawing.Point(650, 90);
            this.continousComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continousComboBox.Name = "continousComboBox";
            this.continousComboBox.Size = new System.Drawing.Size(295, 28);
            this.continousComboBox.TabIndex = 13;
            // 
            // noOfClausesLabel
            // 
            this.noOfClausesLabel.AutoSize = true;
            this.noOfClausesLabel.Location = new System.Drawing.Point(20, 130);
            this.noOfClausesLabel.Name = "noOfClausesLabel";
            this.noOfClausesLabel.Size = new System.Drawing.Size(144, 20);
            this.noOfClausesLabel.TabIndex = 14;
            this.noOfClausesLabel.Text = "Number of Clauses";
            // 
            // noOfClausesNumericUpDown
            // 
            this.noOfClausesNumericUpDown.Location = new System.Drawing.Point(195, 130);
            this.noOfClausesNumericUpDown.Maximum = new decimal(new int[] {
            750000,
            0,
            0,
            0});
            this.noOfClausesNumericUpDown.Name = "noOfClausesNumericUpDown";
            this.noOfClausesNumericUpDown.Size = new System.Drawing.Size(224, 26);
            this.noOfClausesNumericUpDown.TabIndex = 15;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 329);
            this.Controls.Add(this.noOfClausesNumericUpDown);
            this.Controls.Add(this.noOfClausesLabel);
            this.Controls.Add(this.continousComboBox);
            this.Controls.Add(this.discreteComboBox);
            this.Controls.Add(this.continousRadioButton);
            this.Controls.Add(this.discreteRadioButton);
            this.Controls.Add(this.generatorTypeComboBox);
            this.Controls.Add(this.generatorTypeLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.maxLengthOfClauseUpDown);
            this.Controls.Add(this.maxLengthOfClauseLabel);
            this.Controls.Add(this.noOfVariableUpDown);
            this.Controls.Add(this.noOfVariablesLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.generateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Generator";
            this.Text = "DIMACS Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthOfClauseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfClausesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label noOfVariablesLabel;
        private System.Windows.Forms.NumericUpDown noOfVariableUpDown;
        private System.Windows.Forms.Label maxLengthOfClauseLabel;
        private System.Windows.Forms.NumericUpDown maxLengthOfClauseUpDown;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label generatorTypeLabel;
        private System.Windows.Forms.ComboBox generatorTypeComboBox;
        private System.Windows.Forms.RadioButton discreteRadioButton;
        private System.Windows.Forms.RadioButton continousRadioButton;
        private System.Windows.Forms.ComboBox discreteComboBox;
        private System.Windows.Forms.ComboBox continousComboBox;
        private System.Windows.Forms.Label noOfClausesLabel;
        private System.Windows.Forms.NumericUpDown noOfClausesNumericUpDown;
    }
}

