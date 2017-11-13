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
            this.label1 = new System.Windows.Forms.Label();
            this.noOfVariableUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maxLengthOfClauseUpDown = new System.Windows.Forms.NumericUpDown();
            this.successLabel = new System.Windows.Forms.Label();
            this.generatorTypeLabel = new System.Windows.Forms.Label();
            this.generatorTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthOfClauseUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.DarkRed;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.generateButton.Location = new System.Drawing.Point(521, 404);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(107, 63);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(130, 12);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.Text = "outputFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Variables";
            // 
            // noOfVariableUpDown
            // 
            this.noOfVariableUpDown.Location = new System.Drawing.Point(130, 39);
            this.noOfVariableUpDown.Name = "noOfVariableUpDown";
            this.noOfVariableUpDown.Size = new System.Drawing.Size(151, 20);
            this.noOfVariableUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Length Of Clause";
            // 
            // maxLengthOfClauseUpDown
            // 
            this.maxLengthOfClauseUpDown.Location = new System.Drawing.Point(130, 71);
            this.maxLengthOfClauseUpDown.Name = "maxLengthOfClauseUpDown";
            this.maxLengthOfClauseUpDown.Size = new System.Drawing.Size(151, 20);
            this.maxLengthOfClauseUpDown.TabIndex = 6;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(515, 454);
            this.successLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 13);
            this.successLabel.TabIndex = 7;
            // 
            // generatorTypeLabel
            // 
            this.generatorTypeLabel.AutoSize = true;
            this.generatorTypeLabel.Location = new System.Drawing.Point(342, 18);
            this.generatorTypeLabel.Name = "generatorTypeLabel";
            this.generatorTypeLabel.Size = new System.Drawing.Size(81, 13);
            this.generatorTypeLabel.TabIndex = 8;
            this.generatorTypeLabel.Text = "Generator Type";
            // 
            // generatorTypeComboBox
            // 
            this.generatorTypeComboBox.Location = new System.Drawing.Point(430, 18);
            this.generatorTypeComboBox.Name = "generatorTypeComboBox";
            this.generatorTypeComboBox.Size = new System.Drawing.Size(198, 21);
            this.generatorTypeComboBox.TabIndex = 9;
            this.generatorTypeComboBox.DataSource = Enum.GetValues(typeof(GeneratorTypeEnum));
            //this.generatorTypeComboBox.SelectedIndex = (int)GeneratorTypeEnum.Standard;
            this.generatorTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.generatorTypeComboBox_SelectedIndexChanged);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 479);
            this.Controls.Add(this.generatorTypeComboBox);
            this.Controls.Add(this.generatorTypeLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.maxLengthOfClauseUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noOfVariableUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.generateButton);
            this.Name = "Generator";
            this.Text = "DIMACS Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noOfVariableUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLengthOfClauseUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown noOfVariableUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxLengthOfClauseUpDown;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label generatorTypeLabel;
        private System.Windows.Forms.ComboBox generatorTypeComboBox;
    }
}

