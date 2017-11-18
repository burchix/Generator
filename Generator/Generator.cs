using Generator.Interfaces;
using Generator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Troschuetz.Random.Distributions.Continuous;

namespace Generator
{
    public partial class Generator : Form
    {
        private IDimacsWriter _dimacsWriter;

        public Generator()
        {
            InitializeComponent();
            generatorTypeComboBox.DataSource = Enum.GetValues(typeof(GeneratorTypeEnum));
            discreteComboBox.DataSource = Enum.GetValues(typeof(DiscreteDistributionEnum))
                .Cast<DiscreteDistributionEnum>()
                .Where(v => v != DiscreteDistributionEnum.Unknown).ToList();
            continousComboBox.DataSource = Enum.GetValues(typeof(ContinousDistributionEnum))
                .Cast<ContinousDistributionEnum>()
                .Where(v => v != ContinousDistributionEnum.Unknown).ToList();
            _dimacsWriter = new DimacsWriter();
        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var generatorType = (GeneratorTypeEnum)generatorTypeComboBox.SelectedItem;
            var discreteType = discreteRadioButton.Checked 
                ? (DiscreteDistributionEnum)discreteComboBox.SelectedItem
                : DiscreteDistributionEnum.Unknown;
            var continousType = continousRadioButton.Checked 
                ? (ContinousDistributionEnum)continousComboBox.SelectedItem 
                : ContinousDistributionEnum.Unknown;
            var generatorImpl = new GeneratorImpl(generatorType, continousType, discreteType);
            var fileName = fileNameTextBox.Text;
            var noOfVariables = (int)noOfVariableUpDown.Value;
            var maxLength = (int)maxLengthOfClauseUpDown.Value;
            var dimacs = generatorImpl.generate(noOfVariables, maxLength);
            var result = _dimacsWriter.CreateDimacsFile(dimacs, fileName);
            successLabel.Text = result.ToString();
        }

        private void discreteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            discreteComboBox.Enabled = discreteRadioButton.Checked;
        }

        private void continousRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            continousComboBox.Enabled = continousRadioButton.Checked;
        }
    }
}
