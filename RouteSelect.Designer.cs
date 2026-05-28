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
            SuspendLayout();
            // 
            // comboBoxStopsList
            // 
            comboBoxStopsList.FormattingEnabled = true;
            comboBoxStopsList.Location = new Point(114, 59);
            comboBoxStopsList.Margin = new Padding(3, 4, 3, 4);
            comboBoxStopsList.Name = "comboBoxStopsList";
            comboBoxStopsList.Size = new Size(138, 28);
            comboBoxStopsList.TabIndex = 0;
            // 
            // checkBoxNearestDT
            // 
            checkBoxNearestDT.AutoSize = true;
            checkBoxNearestDT.Location = new Point(309, 61);
            checkBoxNearestDT.Margin = new Padding(3, 4, 3, 4);
            checkBoxNearestDT.Name = "checkBoxNearestDT";
            checkBoxNearestDT.Size = new Size(159, 24);
            checkBoxNearestDT.TabIndex = 1;
            checkBoxNearestDT.Text = "Найближчий рейс";
            checkBoxNearestDT.UseVisualStyleBackColor = true;
            checkBoxNearestDT.CheckedChanged += checkBoxNearestDT_CheckedChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(114, 125);
            dateTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(258, 27);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(386, 125);
            dateTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(255, 27);
            dateTimePickerTo.TabIndex = 3;
            dateTimePickerTo.Value = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(639, 183);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 45);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxRoutes
            // 
            listBoxRoutes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxRoutes.FormattingEnabled = true;
            listBoxRoutes.Location = new Point(12, 359);
            listBoxRoutes.Margin = new Padding(3, 4, 3, 4);
            listBoxRoutes.Name = "listBoxRoutes";
            listBoxRoutes.Size = new Size(888, 224);
            listBoxRoutes.TabIndex = 6;
            listBoxRoutes.SelectedIndexChanged += listBoxRoutes_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 21);
            panel1.TabIndex = 7;
            // 
            // buttonGoToPurchase
            // 
            buttonGoToPurchase.Location = new Point(639, 252);
            buttonGoToPurchase.Name = "buttonGoToPurchase";
            buttonGoToPurchase.Size = new Size(159, 45);
            buttonGoToPurchase.TabIndex = 0;
            buttonGoToPurchase.Text = "Оформлення квитка";
            buttonGoToPurchase.UseVisualStyleBackColor = true;
            buttonGoToPurchase.Click += buttonGoToPurchase_Click;
            // 
            // RouteSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonGoToPurchase);
            Controls.Add(panel1);
            Controls.Add(listBoxRoutes);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(checkBoxNearestDT);
            Controls.Add(comboBoxStopsList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RouteSelect";
            Text = "RouteSelect";
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
    }
}