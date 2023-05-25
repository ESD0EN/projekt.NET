using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class Form3 : Form
    {
        MongoClient mongo;
        IMongoDatabase db;
        IMongoCollection<BsonDocument> collection;
        public Form3(MongoClient mongo)
        {
            InitializeComponent();
            this.mongo = mongo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collection = db.GetCollection<BsonDocument>("Student");
            var dokument = new BsonDocument
            {
                {"Imię", imietxtB.Text},
                {"Nazwisko", nazwtxtB.Text},
                {"Indeks", indtxtB.Text},
                {"E-mail", emailtxtB.Text}
            };
            collection.InsertOne(dokument);
            Reset();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = mongo.GetDatabase("ProjektC#");
        }
        private void Reset()
        {
            imietxtB.Text = "";
            nazwtxtB.Text = "";
            indtxtB.Text = "";
            emailtxtB.Text = "";
        }
    }
}
