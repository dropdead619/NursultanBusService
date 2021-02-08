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
            
            Console.WriteLine(@"*******************************
*							  *
*  Система оплаты транспорта  *
* 							  *
*                             *
*******************************");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Пополнить баланс\n2.Произвести валидацию\n3.Проверить баланс\n0.Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите пополняемый баланс: ");
                        transportCard.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Карта успешно пополнена! Ваш баланс составляет:{transportCard.CheckBalance()}");
                        break;
                    case "2":
                        if (transportCard.Validate(90) == true)
                        {
                            Console.WriteLine("Оплачено!");
                        }
                        else
                        {
                            Console.WriteLine("Не достаточно баланса!");
                        }
                        break;
                    case "3":
                        Console.WriteLine(transportCard.CheckBalance());
                        break;
                    case "0":
                        flag = false;
                        break;
                }
            }
        }
    }
}
