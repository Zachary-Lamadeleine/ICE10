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
    }
}