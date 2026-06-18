namespace CourseWork
{
    partial class Boarding
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
            label1 = new Label();
            comboBoxRoutes = new ComboBox();
            listBoxTickets = new ListBox();
            panel1 = new Panel();
            buttonFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 54);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Виберіть рейс:";
            // 
            // comboBoxRoutes
            // 
            comboBoxRoutes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoutes.FormattingEnabled = true;
            comboBoxRoutes.Location = new Point(168, 51);
            comboBoxRoutes.Name = "comboBoxRoutes";
            comboBoxRoutes.Size = new Size(556, 23);
            comboBoxRoutes.TabIndex = 1;
            comboBoxRoutes.SelectionChangeCommitted += comboBoxRoutes_SelectionChangeCommitted;
            // 
            // listBoxTickets
            // 
            listBoxTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTickets.Font = new Font("Courier New", 9F);
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.Location = new Point(12, 212);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.Size = new Size(776, 229);
            listBoxTickets.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 10);
            panel1.TabIndex = 3;
            // 
            // buttonFile
            // 
            buttonFile.Enabled = false;
            buttonFile.Location = new Point(649, 139);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(75, 23);
            buttonFile.TabIndex = 4;
            buttonFile.Text = "button1";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // Boarding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFile);
            Controls.Add(panel1);
            Controls.Add(listBoxTickets);
            Controls.Add(comboBoxRoutes);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Boarding";
            Text = "Посадкова відомість";
            KeyDown += Boarding_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxRoutes;
        private ListBox listBoxTickets;
        private Panel panel1;
        private Button buttonFile;
    }
}