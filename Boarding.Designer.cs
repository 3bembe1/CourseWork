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
            label1.Location = new Point(86, 72);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Виберіть рейс:";
            // 
            // comboBoxRoutes
            // 
            comboBoxRoutes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoutes.FormattingEnabled = true;
            comboBoxRoutes.Location = new Point(192, 68);
            comboBoxRoutes.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoutes.Name = "comboBoxRoutes";
            comboBoxRoutes.Size = new Size(635, 28);
            comboBoxRoutes.TabIndex = 1;
            comboBoxRoutes.SelectionChangeCommitted += comboBoxRoutes_SelectionChangeCommitted;
            // 
            // listBoxTickets
            // 
            listBoxTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTickets.Font = new Font("Courier New", 9F);
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.Location = new Point(14, 283);
            listBoxTickets.Margin = new Padding(3, 4, 3, 4);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.Size = new Size(886, 293);
            listBoxTickets.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 261);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 13);
            panel1.TabIndex = 3;
            // 
            // buttonFile
            // 
            buttonFile.Enabled = false;
            buttonFile.Location = new Point(664, 139);
            buttonFile.Margin = new Padding(3, 4, 3, 4);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(163, 77);
            buttonFile.TabIndex = 4;
            buttonFile.Text = "Отримати посадкову відомість";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // Boarding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonFile);
            Controls.Add(panel1);
            Controls.Add(listBoxTickets);
            Controls.Add(comboBoxRoutes);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
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