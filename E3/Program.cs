﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3.Model;
using static System.Console;


namespace E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FreshLiveDB db = new FreshLiveDB())
            {
                // 增加
                ProductClass pc = new ProductClass()
                {
                    Name = "C#班"
                };

                db.ProductClass.Add(pc);
                db.SaveChanges();



            }


            ReadLine();

        }
    }
}
