using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static List<Prod> BubbleSort(List<Prod> mas)
		{
			Prod temp;
			for (int i = 0; i < mas.Count; i++)
			{ for (int j = i + 1; j < mas.Count; j++)
				{ if (mas[i].price > mas[j].price)
					{
						temp = mas[i];
						mas[i] = mas[j];
						mas[j] = temp;
					}
				}
			}
			return mas;
		}
		static void Main(string[] args)
		{

			Prod kupalnik = new Prod();
			kupalnik.name = "Kupalnik";
			kupalnik.description = "хороший купальник";
			kupalnik.size = "M";
			kupalnik.price = 132.70f;
			kupalnik.image = "тут должна быть картинка";

			Prod plavki = new Prod();
			plavki.name = "Plavki";
			plavki.description = "модные";
			plavki.size = "L";
			plavki.price = 200f;
		plavki.image = "тут должна быть картинка";

			Prod ochki = new Prod();
			ochki.name = "Ochki";
			ochki.description = "зеркальные";
			ochki.size = "one size";
			ochki.price = 400f;
			ochki.image = "тут должна быть картинка";

			Prod kalabashki = new Prod();
			kalabashki.name = "Kalabashki";
			kalabashki.description = "четкие";
			kalabashki.size = "one size";
			kalabashki.price = 300f;
			kalabashki.image = "тут должна быть картинка";

			List<Prod> products = new List<Prod>();
			products.Add(kupalnik);
			products.Add(plavki);
			products.Add(ochki);
			products.Add(kalabashki);
			PrintProducts(products);
			BubbleSort(products);
			Console.WriteLine("После сортировки:");
			PrintProducts(products);
			Console.ReadKey();
		}
		static void PrintProducts(List<Prod> production)
		{
			for (int i = 0; i < production.Count; i++)
			{
				string name = production[i].name;
				string description = production[i].description;
				string size = production[i].size;
				float price = production[i].price;
				string image = production[i].image;
				Console.WriteLine("producty");
				Console.WriteLine("Название:"+name);
				Console.WriteLine("Описание:" + description);
				Console.WriteLine("Размер:" + size);
				Console.WriteLine("Цена:" + price);
				Console.WriteLine("Картинка:" + image);
			}
			
			}
		
	}
	}

