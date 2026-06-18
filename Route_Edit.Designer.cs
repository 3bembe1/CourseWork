namespace CourseWork
{
    partial class Route_Edit
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
            textBoxNumber = new TextBox();
            listBoxStops = new ListBox();
            dateTimePickerDepart = new DateTimePicker();
            textBoxSeats = new TextBox();
            button1 = new Button();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            comboBoxStops = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(140, 65);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 0;
            textBoxNumber.TabStop = false;
            textBoxNumber.KeyPress += textBoxNumber_KeyPress;
            textBoxNumber.Leave += textBoxNumber_Leave;
            // 
            // listBoxStops
            // 
            listBoxStops.FormattingEnabled = true;
            listBoxStops.Location = new Point(140, 135);
            listBoxStops.Name = "listBoxStops";
            listBoxStops.Size = new Size(120, 94);
            listBoxStops.TabIndex = 1;
            // 
            // dateTimePickerDepart
            // 
            dateTimePickerDepart.CustomFormat = "dd-MM-yyyy HH:mm";
            dateTimePickerDepart.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepart.Location = new Point(141, 286);
            dateTimePickerDepart.Name = "dateTimePickerDepart";
            dateTimePickerDepart.ShowUpDown = true;
            dateTimePickerDepart.Size = new Size(200, 23);
            dateTimePickerDepart.TabIndex = 2;
            // 
            // textBoxSeats
            // 
            textBoxSeats.Location = new Point(225, 373);
            textBoxSeats.Name = "textBoxSeats";
            textBoxSeats.Size = new Size(100, 23);
            textBoxSeats.TabIndex = 3;
            textBoxSeats.KeyPress += textBoxSeats_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(614, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(289, 140);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(385, 140);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "-";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(289, 189);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(75, 23);
            buttonUp.TabIndex = 7;
            buttonUp.Text = "^";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(385, 189);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(75, 23);
            buttonDown.TabIndex = 8;
            buttonDown.Text = "v";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // comboBoxStops
            // 
            comboBoxStops.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStops.FormattingEnabled = true;
            comboBoxStops.Location = new Point(528, 141);
            comboBoxStops.Name = "comboBoxStops";
            comboBoxStops.Size = new Size(121, 23);
            comboBoxStops.TabIndex = 9;
            // 
            // Route_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStops);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(button1);
            Controls.Add(textBoxSeats);
            Controls.Add(dateTimePickerDepart);
            Controls.Add(listBoxStops);
            Controls.Add(textBoxNumber);
            Name = "Route_Edit";
            Text = "Route_Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber;
        private ListBox listBoxStops;
        private DateTimePicker dateTimePickerDepart;
        private TextBox textBoxSeats;
        private Button button1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonUp;
        private Button buttonDown;
        private ComboBox comboBoxStops;
    }
}