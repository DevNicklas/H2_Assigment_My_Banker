using H2_Assigment_My_Banker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Controllers
{
    public class MainController
    {
        public void Main()
        {
            Bank bank = new Bank("MinBank");

            Console.ReadLine();
        }
    }
}
