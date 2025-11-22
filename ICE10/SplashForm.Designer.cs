namespace ICE10
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label_Title = new Label();
            SplashTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.Font = new Font("Calibri", 50F, FontStyle.Bold);
            Label_Title.Location = new Point(12, 56);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(776, 86);
            Label_Title.TabIndex = 0;
            Label_Title.Text = "Character Generator";
            Label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SplashTimer
            // 
            SplashTimer.Enabled = true;
            SplashTimer.Interval = 2000;
            SplashTimer.Tick += SplashTimer_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Label_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            Opacity = 0.7D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Title;
        private System.Windows.Forms.Timer SplashTimer;
    }
}