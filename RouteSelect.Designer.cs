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
            SuspendLayout();
            // 
            // comboBoxStopsList
            // 
            comboBoxStopsList.FormattingEnabled = true;
            comboBoxStopsList.Location = new Point(100, 44);
            comboBoxStopsList.Name = "comboBoxStopsList";
            comboBoxStopsList.Size = new Size(121, 23);
            comboBoxStopsList.TabIndex = 0;
            // 
            // checkBoxNearestDT
            // 
            checkBoxNearestDT.AutoSize = true;
            checkBoxNearestDT.Location = new Point(270, 46);
            checkBoxNearestDT.Name = "checkBoxNearestDT";
            checkBoxNearestDT.Size = new Size(128, 19);
            checkBoxNearestDT.TabIndex = 1;
            checkBoxNearestDT.Text = "Найближчий рейс";
            checkBoxNearestDT.UseVisualStyleBackColor = true;
            checkBoxNearestDT.CheckedChanged += checkBoxNearestDT_CheckedChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(100, 94);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(200, 23);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(338, 94);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(200, 23);
            dateTimePickerTo.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(559, 159);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxRoutes
            // 
            listBoxRoutes.FormattingEnabled = true;
            listBoxRoutes.Location = new Point(12, 269);
            listBoxRoutes.Name = "listBoxRoutes";
            listBoxRoutes.Size = new Size(776, 169);
            listBoxRoutes.TabIndex = 6;
            // 
            // RouteSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxRoutes);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(checkBoxNearestDT);
            Controls.Add(comboBoxStopsList);
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
    }
}