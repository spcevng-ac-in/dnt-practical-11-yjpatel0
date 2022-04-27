using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoNotepad
{
    public partial class replaceForm : Form
    {
        public string findString = null;
        public string replaceString = null;
        public DialogResult resultOfDialog = DialogResult.Cancel;
        public replaceForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void replacebutton_Click(object sender, EventArgs e)
        {
            findString = findtextBox.Text;
            replaceString = replacetextBox.Text;
            //resultOfDialog = DialogResult.OK;
            //findWord = findText.Text;
            //replaceWord = replaceText.Text;
            this.Hide();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            resultOfDialog = DialogResult.Cancel;
            this.Hide();
        }
        public String getFindWord()
        {
            return findString;
        }
    }
}