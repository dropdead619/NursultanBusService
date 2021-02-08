using System;
using Models;
using Services;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCardService transportCard = new TransportCardService();
            

            bool flag = true;
            int busTicketPrice = 90;
            while (flag )
            {
                Console.WriteLine(@"*******************************
			
  Система оплаты транспорта  
							  

*******************************");

                Console.WriteLine("1.Пополнить баланс\n2.Произвести валидацию\n3.Проверить баланс\n0.Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите пополняемый баланс: ");
                        transportCard.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Карта успешно пополнена! Ваш баланс составляет:{transportCard.CheckBalance()}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Выберете зону оплаты:");
                        Console.WriteLine("1.Город\n2.Пригород");                      
                        switch (Console.ReadLine())
                        {
                            case "1":
                                busTicketPrice = 90;
                                break;
                            case "2":
                                busTicketPrice = 180;
                                break;
                        }                            
                        if (transportCard.Validate(busTicketPrice) == true)
                        {
                            Console.WriteLine("Оплачено!");
                        }
                        else
                        {
                            Console.WriteLine("Не достаточно баланса!");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine(transportCard.CheckBalance());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "0":
                        flag = false;
                        break;
                }
            }
        }
    }
}
