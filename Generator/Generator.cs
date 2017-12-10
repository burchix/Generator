using Generator.Interfaces;
using Generator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Generator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
            generatorTypeComboBox.DataSource = Enum.GetValues(typeof(GeneratorTypeEnum));
        }

        private void Generator_Load(object sender, EventArgs e)
        {
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var noOfClauseTuple = getNoOfClausesType();
            var lengthOfClausesTuple = getLengthOfClauseType();
            var generationModel = new GenerationModel
            {
                GeneratorType = (GeneratorTypeEnum)generatorTypeComboBox.SelectedItem,
                FileName = fileNameTextBox.Text,
                NoOfVariables = (int)noOfVariableUpDown.Value,
                NoOfRepetitions = (int)repetitionsUpDown.Value,
                LengthOfClauseType = lengthOfClausesTuple.Item1,
                LengthOfClauseValue = lengthOfClausesTuple.Item2,
                NoOfClausesType = noOfClauseTuple.Item1,
                NoOfClausesValue = noOfClauseTuple.Item2,
            };
            var generatorImpl = new GeneratorImpl(generationModel);
            var result = generatorImpl.generate();

            var message = true ? "Your dimacs was succesfully generated" : "There was a problem during generation of your dimacs";
            MessageBox.Show(message);
        }

        private Tuple<NoOfClausesTypeEnum, int> getNoOfClausesType()
        {
            return fixedNoClausesRadioButton.Checked 
                ? new Tuple<NoOfClausesTypeEnum, int>(NoOfClausesTypeEnum.Fixed, (int)fixedNoClausesUpDown.Value)
                : maxNoClausesRadioButton.Checked 
                    ? new Tuple<NoOfClausesTypeEnum, int>(NoOfClausesTypeEnum.Max, (int)maxNoClausesUpDown.Value)
                    : relativeNoClausesRadioButton.Checked 
                        ? new Tuple<NoOfClausesTypeEnum, int>(NoOfClausesTypeEnum.Relative, (int)relativeNoClausesUpDown.Value)
                        : new Tuple<NoOfClausesTypeEnum, int>(NoOfClausesTypeEnum.Unknown, 0);
        }

        private Tuple<LengthOfClauseTypeEnum, int> getLengthOfClauseType()
        {
            return maxLengthClauseRadioButton.Checked 
                ? new Tuple<LengthOfClauseTypeEnum, int>(LengthOfClauseTypeEnum.Max, (int)maxLengthClauseUpDown.Value)
                : fixedLengthClauseRadioButton.Checked
                    ? new Tuple<LengthOfClauseTypeEnum, int>(LengthOfClauseTypeEnum.Fixed, (int)fixedLengthClauseUpDown.Value)
                    : avgLengthClauseRadioButton.Checked 
                        ? new Tuple<LengthOfClauseTypeEnum, int>(LengthOfClauseTypeEnum.Avg, (int) avgLengthClauseUpDown.Value)
                        :  new Tuple<LengthOfClauseTypeEnum, int>(LengthOfClauseTypeEnum.Unknown, 0);
        }

        private void maxNoClausesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            maxNoClausesUpDown.Visible = true;
            fixedNoClausesUpDown.Visible = false;
            relativeNoClausesUpDown.Visible = false;
            noClausesTrackBar.Enabled = false;
        }

        private void fixedNoClausesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            maxNoClausesUpDown.Visible = false;
            fixedNoClausesUpDown.Visible = true;
            relativeNoClausesUpDown.Visible = false;
            noClausesTrackBar.Enabled = false;
        }

        private void relativeNoClausesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            maxNoClausesUpDown.Visible = false;
            fixedNoClausesUpDown.Visible = false;
            relativeNoClausesUpDown.Visible = true;
            noClausesTrackBar.Enabled = true;
        }

        private void relativeNoClausesUpDown_ValueChanged(object sender, EventArgs e)
        {
            noClausesTrackBar.Value = (int)(relativeNoClausesUpDown.Value * 100);
        }

        private void noClausesTrackBar_Scroll(object sender, EventArgs e)
        {
            relativeNoClausesUpDown.Value = (decimal)noClausesTrackBar.Value / 100;
        }

        private void fixedLengthClauseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fixedLengthClauseUpDown.Visible = true;
            maxLengthClauseUpDown.Visible = false;
            avgLengthClauseUpDown.Visible = false;
        }

        private void maxlengthClauseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fixedLengthClauseUpDown.Visible = false;
            maxLengthClauseUpDown.Visible = true;
            avgLengthClauseUpDown.Visible = false;
        }

        private void avgLengthClauseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fixedLengthClauseUpDown.Visible = false;
            maxLengthClauseUpDown.Visible = false;
            avgLengthClauseUpDown.Visible = true;
        }
    }
}
