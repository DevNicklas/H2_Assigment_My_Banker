﻿using H2_Assigment_My_Banker.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Models
{
	public class CardHolder
	{
		private string _name;
		private byte _age;
		private List<Card> _cards = new List<Card>();

		public CardHolder(string name, byte age)
		{
			_name = name;
			_age = age;
		}

		public string Name { get { return _name;} }

		public byte Age { get { return _age; } }

        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }

    }
}
