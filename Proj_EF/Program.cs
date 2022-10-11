using Proj_EF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactController c = new ContactController();
            //c.InsertContact();
            c.SelectAll();
            //c.SelectOne();
            //c.DeleteOne();
        }
    }
}
