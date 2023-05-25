using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace projekcik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wysB_Click(object sender, EventArgs e)
        {
            wys.Navigate(link.Text);
        }

        private void kodB_Click(object sender, EventArgs e)
        {
            kod.Text = AdHTTML.ReadHtml(link.Text);
            comboBox1.Items.Add(link.Text);
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.html)|*.html|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) 
            { 
                kod.SaveFile(saveFileDialog.FileName);
            }
        }

        private void link_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.ConsoleKey.Enter) //if (e.KeyChar == (char)13)
            {
                kodB_Click(sender, e);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            size();
        }
        private void size()
        {
            kod.Width = this.Width / 2;
            wys.Width = this.Width / 2;
            wys.Location = new Point((this.Width / 2) + 20, wys.Location.Y);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem.ToString() != "") 
            {
                this.link.Text = this.comboBox1.SelectedItem.ToString();
            }
        }
    }
}
