namespace projekcik
{
    partial class Form4
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
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.rfsB = new System.Windows.Forms.Button();
            this.delB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(12, 12);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.Size = new System.Drawing.Size(643, 294);
            this.dataStudent.TabIndex = 0;
            this.dataStudent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellEndEdit);
            // 
            // rfsB
            // 
            this.rfsB.Location = new System.Drawing.Point(12, 321);
            this.rfsB.Name = "rfsB";
            this.rfsB.Size = new System.Drawing.Size(75, 23);
            this.rfsB.TabIndex = 1;
            this.rfsB.Text = "Odswież";
            this.rfsB.UseVisualStyleBackColor = true;
            this.rfsB.Click += new System.EventHandler(this.rfsB_Click);
            // 
            // delB
            // 
            this.delB.Location = new System.Drawing.Point(93, 321);
            this.delB.Name = "delB";
            this.delB.Size = new System.Drawing.Size(75, 23);
            this.delB.TabIndex = 2;
            this.delB.Text = "Usuń rekord";
            this.delB.UseVisualStyleBackColor = true;
            this.delB.Click += new System.EventHandler(this.delB_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 357);
            this.Controls.Add(this.delB);
            this.Controls.Add(this.rfsB);
            this.Controls.Add(this.dataStudent);
            this.Name = "Form4";
            this.Text = "STUDENCI";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.Button rfsB;
        private System.Windows.Forms.Button delB;
    }
}