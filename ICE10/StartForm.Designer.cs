namespace ICE10
{
    partial class StartForm
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
            NewCharacter = new Button();
            LoadCharacter = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // NewCharacter
            // 
            NewCharacter.BackColor = Color.ForestGreen;
            NewCharacter.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewCharacter.ForeColor = SystemColors.Control;
            NewCharacter.Location = new Point(67, 61);
            NewCharacter.Name = "NewCharacter";
            NewCharacter.Size = new Size(229, 85);
            NewCharacter.TabIndex = 0;
            NewCharacter.Text = "New Character";
            NewCharacter.UseVisualStyleBackColor = false;
            NewCharacter.Click += NewCharacter_Click;
            // 
            // LoadCharacter
            // 
            LoadCharacter.BackColor = Color.CornflowerBlue;
            LoadCharacter.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadCharacter.ForeColor = SystemColors.Control;
            LoadCharacter.Location = new Point(67, 172);
            LoadCharacter.Name = "LoadCharacter";
            LoadCharacter.Size = new Size(229, 85);
            LoadCharacter.TabIndex = 1;
            LoadCharacter.Text = "Load Character";
            LoadCharacter.UseVisualStyleBackColor = false;
            LoadCharacter.Click += LoadCharacter_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Gray;
            Exit.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ButtonHighlight;
            Exit.Location = new Point(67, 298);
            Exit.Name = "Exit";
            Exit.Size = new Size(229, 85);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(362, 459);
            Controls.Add(Exit);
            Controls.Add(LoadCharacter);
            Controls.Add(NewCharacter);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
        }

        #endregion

        private Button NewCharacter;
        private Button LoadCharacter;
        private Button Exit;
    }
}