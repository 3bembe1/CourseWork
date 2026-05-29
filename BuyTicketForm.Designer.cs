namespace CourseWork
{
    partial class BuyTicketForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonBuyTicket = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 127);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть ПІБ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 124);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 163);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "+380";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // buttonBuyTicket
            // 
            buttonBuyTicket.Location = new Point(498, 271);
            buttonBuyTicket.Margin = new Padding(3, 2, 3, 2);
            buttonBuyTicket.Name = "buttonBuyTicket";
            buttonBuyTicket.Size = new Size(142, 32);
            buttonBuyTicket.TabIndex = 4;
            buttonBuyTicket.Text = "Придбати квиток";
            buttonBuyTicket.UseVisualStyleBackColor = true;
            buttonBuyTicket.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 166);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 5;
            label2.Text = "Введіть номер телефона";
            // 
            // BuyTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(buttonBuyTicket);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BuyTicketForm";
            Text = "Оформлення квитка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonBuyTicket;
        private Label label2;
    }
}