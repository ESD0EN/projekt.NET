using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace projekcik
{
    public partial class MainForm : Form
    {
        MongoClient mongo = new MongoClient("mongodb+srv://dbuser19720:321@cluster0.bsc5d.mongodb.net");

        public MainForm()
        {
            InitializeComponent();
        }

        private void oKIENKOToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "CASCADE":
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case "VERTICAL":
                    LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "ZAMKNIJ WSZYSTKIE":
                    foreach (Form f in MdiChildren)
                    {
                        f.Close();
                    }
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "OKIENKO" && e.ClickedItem.Text != "BAZICZKA")
            {
                Form f = null;
                switch (e.ClickedItem.Text)
                {
                    case "HTML":
                        f = new Form1();
                        break;
                    case "WISIELEC":
                        f = new Form2();
                        break;
                    case "AUTOR":
                        f = new Form5();
                        break;

                }
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bAZICZKAToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form f = null;
            switch(e.ClickedItem.Text)
            {
                case "DODAJ STUDENTA":
                    f = new Form3(mongo);
                    break;
                case "ZOBACZ":
                    f = new Form4(mongo);
                    break;
            }
            f.MdiParent = this;
            f.Show();
        }
    }
}
