using Generator.Interafces;
using Generator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class Generator : Form
    {
        private GeneratorTypeEnum _generatorType;
        private IDimacsWriter _dimacsWriter;

        public Generator()
        {
            InitializeComponent();
            generatorTypeComboBox.DataSource = Enum.GetValues(typeof(GeneratorTypeEnum));
            discreteComboBox.DataSource = Enum.GetValues(typeof(DiscreteDistributionEnum));
            continousComboBox.DataSource = Enum.GetValues(typeof(ContinousDistributionEnum));
            _generatorType = GeneratorTypeEnum.Standard;
            _dimacsWriter = new DimacsWriter();
        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var generatorImpl = new GeneratorImpl(_generatorType);
            var fileName = fileNameTextBox.Text;
            var noOfVariables = (int)noOfVariableUpDown.Value;
            var maxLength = (int)maxLengthOfClauseUpDown.Value;
            var dimacs = generatorImpl.generate(noOfVariables, maxLength);
            var result = _dimacsWriter.CreateDimacsFile(dimacs, fileName);
            successLabel.Text = result.ToString();
        }

        private void generatorTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _generatorType = (GeneratorTypeEnum) generatorTypeComboBox.SelectedItem;
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
