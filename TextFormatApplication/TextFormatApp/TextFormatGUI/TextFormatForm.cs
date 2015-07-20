using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextFormatLib;

namespace TextFormatGUI
{
    public partial class TextFormatForm : Form
    {
        TextFormatOptions formatOptions = new TextFormatOptions();
        public TextFormatForm()
        {
            InitializeComponent();
        }

        private void richTextBoxInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBoxInput.Text == "Enter your text here........")
            {
                richTextBoxInput.Text = "";
                richTextBoxInput.ForeColor = Color.Black;
            }
        }

        private void capitalizeBtn_Click(object sender, EventArgs e)
        {
                formatOptions.CapitalizeInput();
                richTextBoxInput.Text = formatOptions.getCurrentInput();
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            formatOptions.setInput(richTextBoxInput.Text);
            lineCountValueLbl.Text = formatOptions.NumberOfLinesInInput().ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
                if(startLineTxtBox.Text != "")
                formatOptions.UpdateEachLineWithSpecificStartString(startLineTxtBox.Text);
                if( endLineTxtBox.Text != "")
                    formatOptions.UpdateEachLineWithSpecificEndString(endLineTxtBox.Text);
                richTextBoxInput.Text = formatOptions.getCurrentInput();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = string.Empty;
            formatOptions.setInput(richTextBoxInput.Text);
            endLineTxtBox.Text = "";
            startLineTxtBox.Text = "";
            richTextBoxInput.ForeColor = Color.Gray;
            richTextBoxInput.Text = "Enter your text here........";
        }
    }
}
