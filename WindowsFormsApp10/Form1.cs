using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeHotKeys()
        {
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        }

        //private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Text = string.Empty;
        //    currentFilePath = null;
        //}

        //private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            currentFilePath = openFileDialog.FileName;
        //            richTextBox1.Text = System.IO.File.ReadAllText(currentFilePath);
        //        }
        //    }
        //}

        //private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(currentFilePath))
        //    {
        //        SaveAsToolStripMenuItem_Click(sender, e);
        //        return;
        //    }

        //    System.IO.File.WriteAllText(currentFilePath, richTextBox1.Text);
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            currentFilePath = saveFileDialog.FileName;
        //            System.IO.File.WriteAllText(currentFilePath, richTextBox1.Text);
        //        }
        //    }
        //}

        //private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Cut();
        //}

        //private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Copy();
        //}

        //private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Paste();
        //}

        //private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Undo();
        //}

        //private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Redo();
        //}

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            currentFilePath = null;
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    richTextBox1.Text = System.IO.File.ReadAllText(currentFilePath);
                }
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveAsToolStripMenuItem_Click_1(sender, e);
                return;
            }

            System.IO.File.WriteAllText(currentFilePath, richTextBox1.Text);
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(currentFilePath, richTextBox1.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
    }
}
