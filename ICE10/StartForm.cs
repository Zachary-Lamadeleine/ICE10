using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE10
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void LoadCharacter_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Load Character";
            dialog.Filter = "Character Files (*.chr)|*.chr|All Files (*.*)|*.*";
            dialog.InitialDirectory = Program.DownloadsFolder;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                Program.HasLoadedCharacter = Program.LoadCharacter(dialog.FileName);
             
                Program.Forms[(int)FormType.Selection].Show();
                Hide();
            }
        }

        private void NewCharacter_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Selection].Show();
            Hide();
        }
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }
    }
}
