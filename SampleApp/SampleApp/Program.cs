using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello, Docker NetFramework");
            Foo();
        }

        static void Foo()
        {
            DataTable myGridView = new DataTable();
            myGridView.Columns.Add("something");
            myGridView.Columns.Add("something1");
            myGridView.Columns.Add("something2");
            myGridView.Columns.Add("something3");
            myGridView.Columns.Add("something4");
            myGridView.Columns.Add("something5");
            myGridView.Columns.Add("foobar");
            myGridView.Columns.Add("something6");
            myGridView.Columns.Add("something7");
            myGridView.Columns.Add("something8");
            myGridView.Columns.Add("something9");
            myGridView.Columns.Add("something10");

            string tmpColumnName = SetColumnName("something", myGridView);
            myGridView.Columns.Add(tmpColumnName);

            string tmpColumnName2 = SetColumnName("foobar", myGridView);
            myGridView.Columns.Add(tmpColumnName2);
        }

        static string SetColumnName(string name, DataTable grid)
        {
            int n = 0;
            string tmpColumnName = name + name 
                 + name;
            while (grid.Columns.Contains(tmpColumnName))
            {
                //Do something with column name index
                n++;
                tmpColumnName = name + n.ToString();
            }
            return tmpColumnName;
        }
    }
}
