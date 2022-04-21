
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bottom = new System.Windows.Forms.Panel();
            this.middle = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.left.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(712, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel reservation ";
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
            this.middle.Location = new System.Drawing.Point(168, 118);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(789, 444);
            this.middle.TabIndex = 1;
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
    }
}