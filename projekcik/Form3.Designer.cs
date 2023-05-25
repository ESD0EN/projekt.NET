namespace projekcik
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.imietxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazwtxtB = new System.Windows.Forms.TextBox();
            this.indtxtB = new System.Windows.Forms.TextBox();
            this.emailtxtB = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(124, 200);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // imietxtB
            // 
            this.imietxtB.Location = new System.Drawing.Point(136, 43);
            this.imietxtB.Name = "imietxtB";
            this.imietxtB.Size = new System.Drawing.Size(186, 20);
            this.imietxtB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indeks";
            // 
            // nazwtxtB
            // 
            this.nazwtxtB.Location = new System.Drawing.Point(136, 76);
            this.nazwtxtB.Name = "nazwtxtB";
            this.nazwtxtB.Size = new System.Drawing.Size(186, 20);
            this.nazwtxtB.TabIndex = 5;
            // 
            // indtxtB
            // 
            this.indtxtB.Location = new System.Drawing.Point(136, 109);
            this.indtxtB.Name = "indtxtB";
            this.indtxtB.Size = new System.Drawing.Size(186, 20);
            this.indtxtB.TabIndex = 6;
            // 
            // emailtxtB
            // 
            this.emailtxtB.Location = new System.Drawing.Point(136, 144);
            this.emailtxtB.Name = "emailtxtB";
            this.emailtxtB.Size = new System.Drawing.Size(186, 20);
            this.emailtxtB.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(59, 151);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "E-mail";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 247);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.emailtxtB);
            this.Controls.Add(this.indtxtB);
            this.Controls.Add(this.nazwtxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imietxtB);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "DODAWANIE STUDENTA";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox imietxtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazwtxtB;
        private System.Windows.Forms.TextBox indtxtB;
        private System.Windows.Forms.TextBox emailtxtB;
        private System.Windows.Forms.Label Email;
    }
}