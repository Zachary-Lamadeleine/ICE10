namespace ICE10
{
    public enum FormType
    {
        Splash,
        Start,
        Next,
        Final,
        About
    }

    public enum ToastType
    {
        Success,
        Danger,
        Warning,
        Info
    }


    internal static class Program
    {
        // Declaring Form Variables
        public static SplashForm SplashForm;
        public static SelectionForm SelectionForm;
        public static NextForm NextForm;
        public static FinalForm FinalForm;
        public static AboutForm AboutForm;

        // Declaring a List of Type Form
        public static List<Form> Forms;

        // Declaring a bool that will help us exit
        public static bool IsExiting = false;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Initializing the Form Variables
            // by instantiating objects of the related form types
            SplashForm = new SplashForm();
            SelectionForm = new SelectionForm();
            NextForm = new NextForm();
            FinalForm = new FinalForm();
            AboutForm = new AboutForm();

            // Initializing the Forms List
            Forms =
            [
                SplashForm,
                SelectionForm,
                NextForm,
                FinalForm,
                AboutForm
            ];

            Application.Run(SplashForm);
        }

        public static void ConfirmExit(FormClosingEventArgs e)
        {
            if (IsExiting)
            {
                return;
            }

            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                IsExiting = true;
                Application.Exit();
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

    }
}