namespace projekcik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.link = new System.Windows.Forms.TextBox();
            this.kodB = new System.Windows.Forms.Button();
            this.wysB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.kod = new System.Windows.Forms.RichTextBox();
            this.wys = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(56, 12);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(418, 20);
            this.link.TabIndex = 0;
            this.link.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.link_KeyPress);
            // 
            // kodB
            // 
            this.kodB.Location = new System.Drawing.Point(503, 8);
            this.kodB.Name = "kodB";
            this.kodB.Size = new System.Drawing.Size(75, 23);
            this.kodB.TabIndex = 1;
            this.kodB.Text = "Kod strony";
            this.kodB.UseVisualStyleBackColor = true;
            this.kodB.Click += new System.EventHandler(this.kodB_Click);
            // 
            // wysB
            // 
            this.wysB.Location = new System.Drawing.Point(585, 8);
            this.wysB.Name = "wysB";
            this.wysB.Size = new System.Drawing.Size(93, 23);
            this.wysB.TabIndex = 2;
            this.wysB.Text = "Wyświetl stronę";
            this.wysB.UseVisualStyleBackColor = true;
            this.wysB.Click += new System.EventHandler(this.wysB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(684, 8);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(88, 23);
            this.saveB.TabIndex = 3;
            this.saveB.Text = "Zapisz do pliku";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // kod
            // 
            this.kod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kod.Location = new System.Drawing.Point(2, 124);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(387, 397);
            this.kod.TabIndex = 4;
            this.kod.Text = "";
            // 
            // wys
            // 
            this.wys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wys.Location = new System.Drawing.Point(395, 124);
            this.wys.MinimumSize = new System.Drawing.Size(20, 20);
            this.wys.Name = "wys";
            this.wys.Size = new System.Drawing.Size(395, 397);
            this.wys.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Link";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(418, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Historia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wys);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.wysB);
            this.Controls.Add(this.kodB);
            this.Controls.Add(this.link);
            this.Name = "Form1";
            this.Text = "HTML";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button kodB;
        private System.Windows.Forms.Button wysB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.RichTextBox kod;
        private System.Windows.Forms.WebBrowser wys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

