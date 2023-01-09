using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dessert
{
    internal class Dessert
    {
		private String name;
		private double weight;
		private int calories;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public Dessert(String name, double weight, int calories)
		{
			this.Name = name;
			this.Weight = weight;
			this.Calories = calories;
		}

		
		
	public override string ToString()
		{
			string ispis= Name + " weight=" + Weight + ", calories=" + Calories;
			return ispis;
		}

	public String getDessertType()
		{
			return "dessert";
		}
	}

	internal class Cake : Dessert
    {
		private bool containsGluten;
		private String cakeType;

		public Cake(bool containsGluten, String cakeType)
		{
			this.ContainsGluten = containsGluten;
			this.CakeType = cakeType;
		}

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

		public override string ToString()
		{
			String ispis= ", containsGluten=" + containsGluten + ", cakeType=" + cakeType;
			return ispis;
		}
		public string getDessertType()
		{
			string ispis= this.CakeType + " cake";
			return ispis;
		}
	}

	internal class Icecream : Dessert
	{
		private String flavour;
		private String color;

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }

        public IceCream( String flavour, String color)
		{
			
			this.Flavour = flavour;
			this.Color = color;
		}

		

	
	public override string ToString()
		{
			String ispis = ", flavour=" + Flavour + ", color=" + Color;
			return ispis;
		}

	
	public string getDessertType()
		{
			return "ice cream";
		}
	}
}
