using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace testProgSqLite
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection("Data Source=Transaction.db; Version=3");
            connect.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }
    }
}
