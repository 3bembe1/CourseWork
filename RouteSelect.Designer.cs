namespace CourseWork
{
    partial class RouteSelect
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
            comboBoxStopsList = new ComboBox();
            checkBoxNearestDT = new CheckBox();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            buttonSearch = new Button();
            listBoxRoutes = new ListBox();
            panel1 = new Panel();
            buttonGoToPurchase = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxStopsList
            // 
            comboBoxStopsList.FormattingEnabled = true;
            comboBoxStopsList.Location = new Point(172, 53);
            comboBoxStopsList.Name = "comboBoxStopsList";
            comboBoxStopsList.Size = new Size(121, 23);
            comboBoxStopsList.TabIndex = 0;
            // 
            // checkBoxNearestDT
            // 
            checkBoxNearestDT.AutoSize = true;
            checkBoxNearestDT.Location = new Point(320, 55);
            checkBoxNearestDT.Name = "checkBoxNearestDT";
            checkBoxNearestDT.Size = new Size(128, 19);
            checkBoxNearestDT.TabIndex = 1;
            checkBoxNearestDT.Text = "Найближчий рейс";
            checkBoxNearestDT.UseVisualStyleBackColor = true;
            checkBoxNearestDT.CheckedChanged += checkBoxNearestDT_CheckedChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(172, 94);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(226, 23);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(417, 94);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(224, 23);
            dateTimePickerTo.TabIndex = 3;
            dateTimePickerTo.Value = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(559, 137);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 34);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxRoutes
            // 
            listBoxRoutes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxRoutes.FormattingEnabled = true;
            listBoxRoutes.Location = new Point(10, 269);
            listBoxRoutes.Name = "listBoxRoutes";
            listBoxRoutes.Size = new Size(778, 169);
            listBoxRoutes.TabIndex = 6;
            listBoxRoutes.SelectedIndexChanged += listBoxRoutes_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 248);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 16);
            panel1.TabIndex = 7;
            // 
            // buttonGoToPurchase
            // 
            buttonGoToPurchase.Location = new Point(559, 189);
            buttonGoToPurchase.Margin = new Padding(3, 2, 3, 2);
            buttonGoToPurchase.Name = "buttonGoToPurchase";
            buttonGoToPurchase.Size = new Size(139, 34);
            buttonGoToPurchase.TabIndex = 0;
            buttonGoToPurchase.Text = "Оформлення квитка";
            buttonGoToPurchase.UseVisualStyleBackColor = true;
            buttonGoToPurchase.Click += buttonGoToPurchase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 55);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 8;
            label1.Text = "Виберіть населений пункт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 9;
            label2.Text = "Виберіть проміжок часу";
            // 
            // RouteSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGoToPurchase);
            Controls.Add(panel1);
            Controls.Add(listBoxRoutes);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(checkBoxNearestDT);
            Controls.Add(comboBoxStopsList);
            Name = "RouteSelect";
            Text = "Вибір рейса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStopsList;
        private CheckBox checkBoxNearestDT;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonSearch;
        private ListBox listBoxRoutes;
        private Panel panel1;
        private Button buttonGoToPurchase;
        private Label label1;
        private Label label2;
    }
}