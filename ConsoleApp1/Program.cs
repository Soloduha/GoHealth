using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Entities;
using ConsoleApp1.DefaultData;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FillData data = new FillData();
            data.FillAllTables();
        }
    }
}
