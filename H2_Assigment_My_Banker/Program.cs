using H2_Assigment_My_Banker.Controllers;
using H2_Assigment_My_Banker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController main = new MainController();
            main.Main();
		}
    }
}
