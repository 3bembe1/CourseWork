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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(160, 87);
            textBoxNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(114, 27);
            textBoxNumber.TabIndex = 0;
            textBoxNumber.TabStop = false;
            textBoxNumber.KeyPress += textBoxNumber_KeyPress;
            textBoxNumber.Leave += textBoxNumber_Leave;
            // 
            // listBoxStops
            // 
            listBoxStops.FormattingEnabled = true;
            listBoxStops.Location = new Point(160, 180);
            listBoxStops.Margin = new Padding(3, 4, 3, 4);
            listBoxStops.Name = "listBoxStops";
            listBoxStops.Size = new Size(137, 124);
            listBoxStops.TabIndex = 1;
            // 
            // dateTimePickerDepart
            // 
            dateTimePickerDepart.CustomFormat = "dd-MM-yyyy HH:mm";
            dateTimePickerDepart.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepart.Location = new Point(160, 356);
            dateTimePickerDepart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDepart.Name = "dateTimePickerDepart";
            dateTimePickerDepart.ShowUpDown = true;
            dateTimePickerDepart.Size = new Size(228, 27);
            dateTimePickerDepart.TabIndex = 2;
            // 
            // textBoxSeats
            // 
            textBoxSeats.Location = new Point(257, 497);
            textBoxSeats.Margin = new Padding(3, 4, 3, 4);
            textBoxSeats.Name = "textBoxSeats";
            textBoxSeats.Size = new Size(114, 27);
            textBoxSeats.TabIndex = 3;
            textBoxSeats.KeyPress += textBoxSeats_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(708, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 83);
            button1.TabIndex = 4;
            button1.Text = "Зберегти зміни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(424, 185);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 31);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(424, 240);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(86, 31);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "-";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(315, 185);
            buttonUp.Margin = new Padding(3, 4, 3, 4);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(86, 31);
            buttonUp.TabIndex = 7;
            buttonUp.Text = "^";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(315, 240);
            buttonDown.Margin = new Padding(3, 4, 3, 4);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(86, 31);
            buttonDown.TabIndex = 8;
            buttonDown.Text = "v";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // comboBoxStops
            // 
            comboBoxStops.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStops.FormattingEnabled = true;
            comboBoxStops.Location = new Point(541, 185);
            comboBoxStops.Margin = new Padding(3, 4, 3, 4);
            comboBoxStops.Name = "comboBoxStops";
            comboBoxStops.Size = new Size(138, 28);
            comboBoxStops.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 10;
            label1.Text = "Номер рейсу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 231);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Зупинки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 356);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 12;
            label3.Text = "Дата відправлення:";
            // 
            // Route_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Route_Edit";
            Text = "Редагування/додавання рейса";
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}