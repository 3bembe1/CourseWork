namespace CourseWork
{
    partial class TicketReturn
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
            textBoxTicketNum = new TextBox();
            label1 = new Label();
            buttonSearch = new Button();
            textBoxPassengerName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxRouteNumber = new TextBox();
            textBoxStop = new TextBox();
            buttonTicketReturn = new Button();
            SuspendLayout();
            // 
            // textBoxTicketNum
            // 
            textBoxTicketNum.Location = new Point(273, 61);
            textBoxTicketNum.Name = "textBoxTicketNum";
            textBoxTicketNum.Size = new Size(140, 23);
            textBoxTicketNum.TabIndex = 0;
            textBoxTicketNum.KeyPress += textBoxTicketNum_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 64);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Введіть номер квитка:";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(553, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(158, 65);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Знайти квиток";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxPassengerName
            // 
            textBoxPassengerName.Location = new Point(140, 161);
            textBoxPassengerName.Name = "textBoxPassengerName";
            textBoxPassengerName.ReadOnly = true;
            textBoxPassengerName.Size = new Size(179, 23);
            textBoxPassengerName.TabIndex = 2;
            textBoxPassengerName.TabStop = false;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(140, 210);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.ReadOnly = true;
            textBoxPhoneNumber.Size = new Size(179, 23);
            textBoxPhoneNumber.TabIndex = 3;
            textBoxPhoneNumber.TabStop = false;
            // 
            // textBoxRouteNumber
            // 
            textBoxRouteNumber.Location = new Point(140, 263);
            textBoxRouteNumber.Name = "textBoxRouteNumber";
            textBoxRouteNumber.ReadOnly = true;
            textBoxRouteNumber.Size = new Size(179, 23);
            textBoxRouteNumber.TabIndex = 4;
            textBoxRouteNumber.TabStop = false;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(140, 320);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(179, 23);
            textBoxStop.TabIndex = 5;
            textBoxStop.TabStop = false;
            // 
            // buttonTicketReturn
            // 
            buttonTicketReturn.Enabled = false;
            buttonTicketReturn.Location = new Point(553, 345);
            buttonTicketReturn.Name = "buttonTicketReturn";
            buttonTicketReturn.Size = new Size(210, 74);
            buttonTicketReturn.TabIndex = 2;
            buttonTicketReturn.Text = "Повернути квиток";
            buttonTicketReturn.UseVisualStyleBackColor = true;
            buttonTicketReturn.Click += buttonTicketReturn_Click;
            // 
            // TicketReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTicketReturn);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxRouteNumber);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxPassengerName);
            Controls.Add(buttonSearch);
            Controls.Add(label1);
            Controls.Add(textBoxTicketNum);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "TicketReturn";
            Text = "Повернення квитка";
            KeyDown += TicketReturn_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTicketNum;
        private Label label1;
        private Button buttonSearch;
        private TextBox textBoxPassengerName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxRouteNumber;
        private TextBox textBoxStop;
        private Button buttonTicketReturn;
    }
}