using H2_Assigment_My_Banker.Controller;
using H2_Assigment_My_Banker.Model;
using H2_Assigment_My_Banker.Model.Cards;
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
            Bank bank = new Bank("MinBank");
            Console.ReadLine();
		}
    }
}
