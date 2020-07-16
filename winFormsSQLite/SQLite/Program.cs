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
            /*
            List<int> ls1 = new List<int> { 1, 2, 3, 2};
            List<int> ls2 = new List<int> { 1, 2, 3 };
            var x = ls1.OrderBy(p => p);
            foreach(var key in x)
            {
                Console.WriteLine(key);
            }
            */
            using (TrContext context = new TrContext("new"))
            {
                /*
                // Запрос из нескольких таблиц
                var result = context.Buys.Join(context.Categories, 
                    b => b.CategoryId, c => c.Id,
                    (b, c) => new { name = b.Name, categ = c.Name, sum = b.Sum });
                List<new { string name, string categ, double sum } > = 
                foreach (var key in result)
                {
                    foreach (var str in key)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", str.name, str.categ, str.sum);
                    }
                }
                
                var buy = context.Buys.OrderBy(b => b.Date);
                foreach (Buy b in buy)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", b.CategoryId, b.Name, b.Date);
                }
                */
            }
        }
    }
}
