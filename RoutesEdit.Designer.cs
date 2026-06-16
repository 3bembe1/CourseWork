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
            SuspendLayout();
            // 
            // comboBoxRoutes
            // 
            comboBoxRoutes.FormattingEnabled = true;
            comboBoxRoutes.Location = new Point(190, 47);
            comboBoxRoutes.Name = "comboBoxRoutes";
            comboBoxRoutes.Size = new Size(354, 23);
            comboBoxRoutes.TabIndex = 0;
            comboBoxRoutes.SelectedIndexChanged += comboBoxRoutes_SelectedIndexChanged;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(124, 125);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "button1";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(344, 125);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "button2";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(574, 125);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "button3";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // RoutesEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonRemove);
            Controls.Add(comboBoxRoutes);
            Name = "RoutesEdit";
            Text = "RoutesEdit";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxRoutes;
        private Button buttonRemove;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}