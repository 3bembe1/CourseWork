namespace CourseWork
{
    partial class RoutesEdit
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
            comboBoxRoutes = new ComboBox();
            buttonRemove = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxRoutes
            // 
            comboBoxRoutes.FormattingEnabled = true;
            comboBoxRoutes.Location = new Point(254, 58);
            comboBoxRoutes.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoutes.Name = "comboBoxRoutes";
            comboBoxRoutes.Size = new Size(567, 28);
            comboBoxRoutes.TabIndex = 0;
            comboBoxRoutes.SelectedIndexChanged += comboBoxRoutes_SelectedIndexChanged;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Font = new Font("Segoe UI", 12F);
            buttonRemove.Location = new Point(90, 167);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(165, 83);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Видалення рейса";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(373, 167);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(165, 83);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редагування рейса";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(656, 167);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(165, 83);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Додавання рейса";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 61);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Виберіть рейс:";
            // 
            // RoutesEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonRemove);
            Controls.Add(comboBoxRoutes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoutesEdit";
            Text = "Редагування рейсів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRoutes;
        private Button buttonRemove;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label label1;
    }
}