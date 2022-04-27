using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoNotepad
{
    public partial class notepadForm : Form
    {
        String fileName = null;
        bool flag = false;
        public notepadForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            String fileName = openFile.FileName;
            StreamReader reader = new StreamReader(fileName);
            string data = reader.ReadToEnd();
            notepadrichTextBox.Text = data;
            reader.Close();
        }

        private void notepadrichTextBox_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                DialogResult result = notepadsaveFileDialog.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                fileName = notepadsaveFileDialog.FileName;
            }
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(notepadrichTextBox.Text);
            writer.Close();
            flag = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                DialogResult result = notepadsaveFileDialog.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                fileName = notepadsaveFileDialog.FileName;
            }
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(notepadrichTextBox.Text);
            writer.Close();
            flag = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                DialogResult result = MessageBox.Show("Save File or Not ?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
                flag = false;
            }
            notepadrichTextBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                DialogResult result = MessageBox.Show("Save File or Not ?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
                flag = false;
            }
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceForm replace = new replaceForm();
            replace.ShowDialog();
            String findWord = replace.findString;
            String replaceWord = replace.replaceString;
            if (findWord != "")
            {
                notepadrichTextBox.Text = notepadrichTextBox.Text.Replace(findWord, replaceWord);
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Nothing to replace", "Done", MessageBoxButtons.OK);
        }



        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadrichTextBox.Undo();
        }

        private void reduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadrichTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadrichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(notepadrichTextBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                notepadrichTextBox.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }
    }

}