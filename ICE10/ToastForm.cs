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
    public partial class ToastForm : Form
    {
        //Empty Constructor
        public ToastForm()
        {
            InitializeComponent();
        }

        //Paramaterized Constructor.
        public ToastForm(string message, ToastType type)
        {
            InitializeComponent();
            Label_Message.Text = message;

            switch (type)
            {
                case ToastType.Success:
                    BackColor = ColorTranslator.FromHtml("#198754");
                    break;
                case ToastType.Danger:
                    BackColor = ColorTranslator.FromHtml("#DC3545");
                    break;
                case ToastType.Warning:
                    BackColor = ColorTranslator.FromHtml("#FFC107");
                    break;
                case ToastType.Info:
                    BackColor = ColorTranslator.FromHtml("#0DCAF0");
                    break;
                default:
                    BackColor = ColorTranslator.FromHtml("#6C757D");
                    break;
            }
        }

        public static void ShowToast(string message, ToastType type = ToastType.Success)
        {
            const int padding = 20;
            ToastForm toast = new ToastForm(message, type);
            // Determine the area to center the toast in
            Rectangle area = Form.ActiveForm.Bounds;
            // Calculate the position to center the toast at the top of the area
            int x = area.Left + (area.Width - toast.Width) / 2;
            int y = area.Top + padding;
            // Set the location of the toast and show it
            toast.Location = new Point(x, y);
            toast.TopMost = true;
            toast.Show(Form.ActiveForm);
        }




        private void ToastForm_Shown(object sender, EventArgs e)
        {
            ToastTimer.Start();

        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            ToastTimer.Stop();
            Close();
        }
    }
}

