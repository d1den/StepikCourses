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
using testProgSqLite.Models;
using System.Runtime.Remoting.Contexts;

namespace testProgSqLite
{
    public partial class Form1 : Form
    {
        /*private DataTable table = new DataTable();
        private SQLiteConnection connect;
        private SQLiteCommand dbCommnad; */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*connect = new SQLiteConnection("Data Source=Transaction.db; Version=3");
            connect.Open();
            //dbCommnad.Connection = connect;
            string sqlQuery = "SELECT name FROM incomeCategories";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            */

            /*using(LibraryContext db = new LibraryContext())
            {
                Book book = new Book();
                book.Name = "Анна Каренина";
                book.Author = "Толстой";
                db.Books.Add(book);
                db.SaveChanges();
            }*/
            using (LibraryContext context = new LibraryContext())
            {
                Cat category = new Cat { Id = 1, Name = "Транспорт" };
                context.Cats.Add(category);
                context.SaveChanges();
                /*context.Сategories.Add(new Сategory { Name = "Продукты" });
                context.Сategories.Add(new Сategory { Name = "Еда в кафе" });
                context.Сategories.Add(new Сategory { Name = "Отдых" });
                */
                /*context.IncomeExpenses.Add(new IncomeExpense { CategoryID = 1, Type = "Расход", Sum = 30.23M, Comment = "dad" });
                context.IncomeExpenses.Add(new IncomeExpense { CategoryID = 1, Type = "Доход", Sum = 60.23M, Comment = "daвфвфцd" });
                context.IncomeExpenses.Add(new IncomeExpense { CategoryID = 2, Type = "Расход", Sum = 670.23M, Comment = "Ресторан сегодня" });
                context.IncomeExpenses.Add(new IncomeExpense { CategoryID = 3, Type = "Расход", Sum = 10.23M, Comment = "Кино" });
                */
                /*
                foreach (Book b in context.Books) // Перебор всех
                {
                    richTextBox1.Text += String.Format("{0}\t{1}\t{2}\n", b.Id, b.Name, b.Author);
                }
                */
                /*
                Book someBook = context.Books.Where(c => c.Name == "Война и мир").FirstOrDefault(); // Выполнение поиска по данным БД
                context.Books.Remove(someBook); //удаление
                */
                /*
                Book someBook = context.Books.FirstOrDefault(); // Выполнение поиска по данным БД
                someBook.Name = "Update value"; // Обновление данных
                context.SaveChanges();
                foreach (Book b in context.Books) // Перебор всех
                {
                    richTextBox1.Text += String.Format("{0}\t{1}\t{2}\n", b.Id, b.Name, b.Author);
                }
                */
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //connect.Close();
        }

    }
}
