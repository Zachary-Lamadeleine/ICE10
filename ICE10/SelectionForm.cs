using System;

namespace ICE10
{
    enum Career
    {
        Army,
        Psion,
        Rogue,
        Telepath
    }

    public partial class SelectionForm : Form
    {
        // Class Variables
        Random random = new Random();

        string[] Careers = Enum.GetNames<Career>();

        int[][] CareerStats =
        [
            [35, 35, 30, 30, 25, 25], // Army
            [30, 35, 30, 25, 35, 25], // Psion
            [35, 30, 30, 35, 25, 25], // Rogue
            [25, 30, 30, 35, 25, 35]  // Telepath
        ];

        // Declaring Primary Stat TetBox Array
        TextBox[] PrimaryStatTextBoxes;

        // Declaring Secondary Stat TextBox Array
        TextBox[] SecondaryStatTextBoxes;

        string SelectedCareer;

        string SelectedSpecies = "Human";


        /// <summary>
        /// The Constructor for SelectionForm
        /// </summary>
        public SelectionForm()
        {
            InitializeComponent();

            // Populate the ComboBox with career options
            ComboBox_Career.Items.Clear();
            ComboBox_Career.Items.AddRange(Careers);

            // Initialize Primary Stat TextBox Array
            PrimaryStatTextBoxes =
            [
                TextBox_AGL,
                TextBox_STR,
                TextBox_VGR,
                TextBox_PER,
                TextBox_INT,
                TextBox_WIL
            ];

            // Initialize Secondary Stat TextBox Array
            SecondaryStatTextBoxes =
            [
                TextBox_AWA,
                TextBox_TOU,
                TextBox_RES
            ];

        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Random Generation is Destructive. Are you sure?", "Confirm Random Generation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ComboBox_Career.SelectedIndex = -1;

                SelectedCareer = "Random";

                foreach (TextBox stat in PrimaryStatTextBoxes)
                {
                    stat.Text = Roll6d10DropLowest().ToString();
                }

                ComputeSecondaryAttributes();

                Button_Next.Enabled = true;
            }

        }

        private void ComputeSecondaryAttributes()
        {
            TextBox_AWA.Text = (Convert.ToInt32(TextBox_AGL.Text) + Convert.ToInt32(TextBox_PER.Text)).ToString();
            TextBox_TOU.Text = (Convert.ToInt32(TextBox_STR.Text) + Convert.ToInt32(TextBox_VGR.Text)).ToString();
            TextBox_RES.Text = (Convert.ToInt32(TextBox_INT.Text) + Convert.ToInt32(TextBox_WIL.Text)).ToString();
        }

        private void ComboBox_Career_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the ComboBox has been cleared, then return
            if (ComboBox_Career.SelectedIndex < 0) { return; }

            SelectedCareer = ComboBox_Career.SelectedItem.ToString();

            for (int attribute = 0; attribute < PrimaryStatTextBoxes.Length; attribute++)
            {
                PrimaryStatTextBoxes[attribute].Text = CareerStats[ComboBox_Career.SelectedIndex][attribute].ToString();
            }

            Button_Next.Enabled = true;

            ComputeSecondaryAttributes();
        }

        /// <summary>
        /// Deprecated: Rolls 5d10 and returns the total
        /// </summary>
        /// <returns></returns>
        int Roll5d10()
        {
            int total = 0;
            for (int die = 0; die < 5; die++)
            {
                total += random.Next(1, 11);
            }
            return total;
        }

        /// <summary>
        /// Rolls 6d10, drops the lowest die, and returns the total of the remaining dice
        /// </summary>
        /// <returns></returns>
        int Roll6d10DropLowest()
        {
            int[] rolls = new int[6];
            for (int die = 0; die < 6; die++)
            {
                rolls[die] = random.Next(1, 11);
            }

            Array.Sort(rolls);

            int total = 0;
            for (int die = 1; die < 6; die++)
            {
                total += rolls[die];
            }
            return total;
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ComboBox_Career.SelectedIndex = -1;

                foreach (var stat in PrimaryStatTextBoxes)
                {
                    stat.Text = string.Empty;
                }

                foreach (var stat in SecondaryStatTextBoxes)
                {
                    stat.Text = string.Empty;
                }

                Button_Next.Enabled = false;
            }
        }

        private void CheckBox_ShowRandomButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ShowRandomButton.Checked)
            {
                Button_Random.Show();
            }
            else
            {
                Button_Random.Hide();
            }

        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            Settings.Default.AGL = TextBox_AGL.Text;
            Settings.Default.STR = TextBox_STR.Text;
            Settings.Default.VGR = TextBox_VGR.Text;
            Settings.Default.PER = TextBox_PER.Text;
            Settings.Default.INT = TextBox_INT.Text;
            Settings.Default.WIL = TextBox_WIL.Text;
            Settings.Default.Career = SelectedCareer;
            Settings.Default.Species = SelectedSpecies;
            Settings.Default.CharacterName = TextBox_Name.Text;

            Program.Forms[(int)FormType.Next].Show();
            Hide();
        }

        /// <summary>
        /// This event handler updates the SelectedSpecies variable when a RadioButton is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Species_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure the sender is a RadioButton
            var radioButton = sender as RadioButton;

            // set the SelectedSpecies variable to the text of the selected RadioButton
            SelectedSpecies = radioButton.Text;

        }

        private void SelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }
    }
}
