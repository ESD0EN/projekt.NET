using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace projekcik
{
    public partial class Form4 : Form
    {
        MongoClient mongo;
        IMongoDatabase db;
        IMongoCollection<BsonDocument> collection;
        
        public Form4(MongoClient mongo)
        {
            InitializeComponent();
            this.mongo = mongo;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            db = mongo.GetDatabase("ProjektC#");
            collection = db.GetCollection<BsonDocument>("Student");
            loadData();
        }

        private void loadData()
        {
            var rows = collection.Find(new BsonDocument()).ToList();
            try
            {
                foreach(BsonElement column in rows[0]) 
                {
                    if(column.Value.BsonType == BsonType.Document)
                    {
                        BsonDocument nestedCollection = column.Value.ToBsonDocument();
                        foreach(BsonElement nestedColumn in nestedCollection)
                        {
                            dataStudent.Columns.Add(nestedColumn.Name + "Document.", nestedColumn.Name);
                        }
                        continue;
                    }
                    dataStudent.Columns.Add(column.Name, column.Name);
                }
            }
            catch(ArgumentOutOfRangeException) 
            {
                MessageBox.Show("W kolekcji: " + collection.CollectionNamespace + " bazy: " + db.DatabaseNamespace + " nie  ma żadnych rekordów", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(Close));
                return;
            }
            foreach(BsonDocument student in rows)
            {
                int row = dataStudent.Rows.Add();
                int rowID = 0;

                foreach(BsonElement value in student)
                {
                    if(value.Value.BsonType == BsonType.Document)
                    {
                        BsonDocument nestedValues = value.Value.ToBsonDocument();
                        foreach(BsonElement nestedValue in nestedValues)
                        {
                            dataStudent.Rows[row].Cells[rowID++].Value = nestedValue.Value;
                        }
                        continue;
                    }
                    try
                    {
                        dataStudent.Rows[row].Cells[rowID++].Value = value.Value;
                    }
                    catch (Exception)
                    {
                        dataStudent.Columns.Add(value.Name, value.Name);
                        dataStudent.Rows[row].Cells[--rowID].Value = value.Value;
                    }
                    
                }
            }
        }
        private void Rfs()
        {
            dataStudent.Rows.Clear();
            dataStudent.Columns.Clear();
            dataStudent.Refresh();
            loadData();
        }
        private void rfsB_Click(object sender, EventArgs e)
        {
            Rfs();
        }

        private void delB_Click(object sender, EventArgs e)
        {
            var accept = MessageBox.Show("Czy chcesz usunąć ten rekord?", "Usuwanie rekordu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string delID;
            if(accept == DialogResult.Yes)
            {
                foreach(DataGridViewCell cell in dataStudent.SelectedCells) 
                {
                    delID = dataStudent.Rows[cell.RowIndex].Cells[0].Value.ToString();

                    var delFiltr = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(delID));
                    collection.DeleteOne(delFiltr);
                    MessageBox.Show("Usunięto rekord");
                    Rfs();
                }
            }
        }

        private void dataStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 0)
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;

                string cell = dataStudent.Columns[col].Name;
                string recID = dataStudent.Rows[row].Cells[0].Value.ToString();
                var filtr = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(recID));
                var query = Builders<BsonDocument>.Update.Set(cell, dataStudent.Rows[row].Cells[e.ColumnIndex].Value.ToString());
                collection.UpdateOne(filtr, query);
            }
        }
    }
}
