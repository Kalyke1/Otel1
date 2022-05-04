
namespace Otel1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bottom = new System.Windows.Forms.Panel();
            this.middle = new System.Windows.Forms.Panel();
            this.txtChildCount = new System.Windows.Forms.TextBox();
            this.txtAdultCount = new System.Windows.Forms.TextBox();
            this.dtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dtCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.otelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIsBreakfast = new System.Windows.Forms.CheckBox();
            this.cbIsDinner = new System.Windows.Forms.CheckBox();
            this.header.SuspendLayout();
            this.left.SuspendLayout();
            this.middle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(12, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(945, 100);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 66F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Reservation ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 424);
            this.listBox1.TabIndex = 1;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.left.Controls.Add(this.button1);
            this.left.Controls.Add(this.listBox1);
            this.left.Location = new System.Drawing.Point(12, 108);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(150, 480);
            this.left.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottom.Location = new System.Drawing.Point(12, 568);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(945, 20);
            this.bottom.TabIndex = 0;
            // 
            // middle
            // 
            this.middle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.middle.Controls.Add(this.cbIsDinner);
            this.middle.Controls.Add(this.cbIsBreakfast);
            this.middle.Controls.Add(this.txtChildCount);
            this.middle.Controls.Add(this.txtAdultCount);
            this.middle.Controls.Add(this.dtCheckOutDate);
            this.middle.Controls.Add(this.dtCheckInDate);
            this.middle.Controls.Add(this.txtPhoneNumber);
            this.middle.Controls.Add(this.txtSurName);
            this.middle.Controls.Add(this.label11);
            this.middle.Controls.Add(this.label10);
            this.middle.Controls.Add(this.label9);
            this.middle.Controls.Add(this.label8);
            this.middle.Controls.Add(this.label7);
            this.middle.Controls.Add(this.label6);
            this.middle.Controls.Add(this.label5);
            this.middle.Controls.Add(this.label4);
            this.middle.Controls.Add(this.label3);
            this.middle.Controls.Add(this.label2);
            this.middle.Controls.Add(this.cboRoom);
            this.middle.Controls.Add(this.txtFirstName);
            this.middle.Location = new System.Drawing.Point(168, 118);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(789, 444);
            this.middle.TabIndex = 1;
            // 
            // txtChildCount
            // 
            this.txtChildCount.Location = new System.Drawing.Point(168, 220);
            this.txtChildCount.Name = "txtChildCount";
            this.txtChildCount.Size = new System.Drawing.Size(171, 23);
            this.txtChildCount.TabIndex = 17;
            // 
            // txtAdultCount
            // 
            this.txtAdultCount.Location = new System.Drawing.Point(168, 198);
            this.txtAdultCount.Name = "txtAdultCount";
            this.txtAdultCount.Size = new System.Drawing.Size(171, 23);
            this.txtAdultCount.TabIndex = 16;
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.Location = new System.Drawing.Point(168, 153);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.Size = new System.Drawing.Size(171, 23);
            this.dtCheckOutDate.TabIndex = 15;
            // 
            // dtCheckInDate
            // 
            this.dtCheckInDate.Location = new System.Drawing.Point(168, 123);
            this.dtCheckInDate.Name = "dtCheckInDate";
            this.dtCheckInDate.Size = new System.Drawing.Size(171, 23);
            this.dtCheckInDate.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 89);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(171, 23);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(168, 67);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(171, 23);
            this.txtSurName.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Akşamyemeği dahil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kahvaltı dahil";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "ODA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Çocuk Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yetişkin Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soy Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(168, 262);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(171, 23);
            this.cboRoom.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // cbIsBreakfast
            // 
            this.cbIsBreakfast.AutoSize = true;
            this.cbIsBreakfast.Location = new System.Drawing.Point(168, 306);
            this.cbIsBreakfast.Name = "cbIsBreakfast";
            this.cbIsBreakfast.Size = new System.Drawing.Size(15, 14);
            this.cbIsBreakfast.TabIndex = 18;
            this.cbIsBreakfast.UseVisualStyleBackColor = true;
            // 
            // cbIsDinner
            // 
            this.cbIsDinner.AutoSize = true;
            this.cbIsDinner.Location = new System.Drawing.Point(168, 324);
            this.cbIsDinner.Name = "cbIsDinner";
            this.cbIsDinner.Size = new System.Drawing.Size(15, 14);
            this.cbIsDinner.TabIndex = 19;
            this.cbIsDinner.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 600);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.left);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.header);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.left.ResumeLayout(false);
            this.middle.ResumeLayout(false);
            this.middle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel middle;
        private System.Windows.Forms.BindingSource otelBindingSource;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtCheckInDate;
        private System.Windows.Forms.DateTimePicker dtCheckOutDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox txtAdultCount;
        private System.Windows.Forms.TextBox txtChildCount;
        private System.Windows.Forms.CheckBox cbIsDinner;
        private System.Windows.Forms.CheckBox cbIsBreakfast;
    }
}