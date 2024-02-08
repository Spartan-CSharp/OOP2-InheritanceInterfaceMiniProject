using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;

namespace InheritanceMiniProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<IRentable> rentables = new List<IRentable>();
			List<IPurchaseable> purchaseables = new List<IPurchaseable>();

			BeachBallModel beachball = new BeachBallModel { BallSize = 15, ItemName = "Wilson Beach Ball", PurchasePrice = 25.00M, QuantityInStock = 10 };
			BookModel book = new BookModel { Author = "Charles Dickens", ItemName = "A Tale of Two Cities", NumberOfPages = 658, PurchasePrice = 7.99M, QuantityInStock = 3 };
			CarModel car = new CarModel { ItemName = "Chevy Malibu", NumberOfSeats = 4, PurchasePrice = 25000.00M, QuantityInStock = 7, RentalPrice = 125.00M, VehicleIdentificationNumber = "2C56DFG66734A" };
			ExcavatorModel excavator = new ExcavatorModel { ItemName = "Backhoe", QuantityInStock = 2, RentalPrice = 250.00M, VehicleIdentificationNumber = "14H34CAB23HE5" };
			_ = new InventoryItemModel { ItemName = "Widget", QuantityInStock = 25000 };
			MotorcycleModel motorcycle = new MotorcycleModel { ItemName = "Voodoo", PurchasePrice = 17000.00M, QuantityInStock = 1, RentalPrice = 99.75M, RideType = "Low Rider", VehicleIdentificationNumber = "2453DCGB7G45F" };
			SunscreenModel sunscreen = new SunscreenModel { BottleSize = 3.4, ItemName = "Neutrogena Sunscreen", PurchasePrice = 9.99M, QuantityInStock = 200 };
			TowelModel towel = new TowelModel { ItemName = "Beach Towel", PurchasePrice = 35.99M, QuantityInStock = 75, RentalPrice = 2.00M, TowelLength = 72, TowelWidth = 30 };
			TruckModel truck = new TruckModel { BedLength = 6, ItemName = "Ram 1500", PurchasePrice = 35000.00M, QuantityInStock = 5, RentalPrice = 175.00M, VehicleIdentificationNumber = "ADF1234DK9E8D" };
			VehicleModel vehicle = new VehicleModel { ItemName = "Moped", PurchasePrice = 2500.00M, QuantityInStock = 5, RentalPrice = 50.00M, VehicleIdentificationNumber = "1234ADBD5643D" };

			rentables.Add(car);
			rentables.Add(excavator);
			rentables.Add(motorcycle);
			rentables.Add(towel);
			rentables.Add(truck);
			rentables.Add(vehicle);

			purchaseables.Add(beachball);
			purchaseables.Add(book);
			purchaseables.Add(car);
			purchaseables.Add(motorcycle);
			purchaseables.Add(sunscreen);
			purchaseables.Add(towel);
			purchaseables.Add(truck);
			purchaseables.Add(vehicle);

			Console.WriteLine("General Store");
			Console.WriteLine();

			string moretransactions;

			do
			{
				Console.Write("Do you want to rent, buy, or return (rent/buy/return): ");
				string rentorbuy = Console.ReadLine();

				if ( rentorbuy.ToLower() == "rent" )
				{
					foreach ( IRentable rentable in rentables )
					{
						Console.Write($"Did you want to rent a {rentable.ItemName} for ${rentable.RentalPrice} (yes/no): ");
						string wanttorent = Console.ReadLine();
						if ( wanttorent.ToLower() == "yes" )
						{
							rentable.Rent();
							Console.WriteLine();
						}
					}

					Console.WriteLine();
				}
				else if ( rentorbuy.ToLower() == "buy" )
				{
					foreach ( IPurchaseable purchaseable in purchaseables )
					{
						Console.Write($"Did you want to purchase a {purchaseable.ItemName} for ${purchaseable.PurchasePrice} (yes/no): ");
						string wanttobuy = Console.ReadLine();
						if ( wanttobuy.ToLower() == "yes" )
						{
							purchaseable.Puchase();
							Console.WriteLine();
						}
					}

					Console.WriteLine();
				}
				else if ( rentorbuy.ToLower() == "return" )
				{
					foreach ( IRentable rentable in rentables )
					{
						Console.Write($"Did you want to return a {rentable.ItemName} (yes/no): ");
						string wanttoreturn = Console.ReadLine();
						if ( wanttoreturn.ToLower() == "yes" )
						{
							rentable.Return();
							Console.WriteLine();
						}
					}

					Console.WriteLine();
				}
				else
				{
					Console.WriteLine("I did not understand.");
					Console.WriteLine();
				}

				Console.Write("Did you want to do anything else (yes/no): ");
				moretransactions = Console.ReadLine();

			} while ( moretransactions.ToLower() == "yes" );

			_ = Console.ReadLine();
		}
	}
}
