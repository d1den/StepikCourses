using Microsoft.EntityFrameworkCore.Internal;
using SQLite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TrContext context = new TrContext("new"))
            {
                /*
                // Запрос из нескольких таблиц
                var result = context.Buys.Join(context.Categories, 
                    b => b.CategoryId, c => c.Id,
                    (b, c) => new { name = b.Name, categ = c.Name, sum = b.Sum });
                foreach(var str in result)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", str.name, str.categ, str.sum);
                }
                */
                var buy = context.Buys.OrderBy(b => b.CategoryId);
                List<Buy> buys = new List<Buy>();
                foreach (Buy b in buy)
                {
                    if(int.Parse(b.Date.Split('.')[1])>3)
                        Console.WriteLine("{0}\t{1}", b.Name, b.Date);
                }

            }

        }
    }
}
