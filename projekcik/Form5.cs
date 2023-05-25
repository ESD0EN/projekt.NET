using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekcik
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape1 = new System.Drawing.Drawing2D.GraphicsPath();
            shape1.AddEllipse(0, 0, this.Width, this.Height);
  
            this.Region = new System.Drawing.Region(shape1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
