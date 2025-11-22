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
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The event is triggered when the Back button is clicked. It shows the Selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Back_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Start].Show();
            Hide();
        }

        /// <summary>
        /// The event is triggered when the Next button is clicked. It shows the Final form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Final].Show();
            Hide();
        }

        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }
    }
}
