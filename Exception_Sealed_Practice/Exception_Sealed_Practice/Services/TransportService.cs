using Exception_Sealed_Practice.CustomExceptions;
using Exception_Sealed_Practice.Model;
using Exception_Sealed_Practice.Services.Interfaces;
using System;

namespace Exception_Sealed_Practice.Services
{
    public class TransportService : ITransportService
    {
        private Transport _transport;

        public void CreateTransport(string model, string brand, int year, string title)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter car model: ");
                    model = Console.ReadLine();
                    if (string.IsNullOrEmpty(model))
                        throw new NullorException("Model cannot be empty!");
                    break;
                }
                catch (NullorException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter car brand: ");
                    brand = Console.ReadLine();
                    if (string.IsNullOrEmpty(brand) || brand.Length < 3)
                        throw new LengthException("Brand must contain at least 3 characters!");
                    break;
                }
                catch (LengthException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter car year: ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        throw new YearException("Year cannot be empty!");
                    year = Convert.ToInt32(input);
                    if (year < 1900)
                        throw new YearException("Cars did not exist before 1900!");
                    break;
                }
                catch (YearException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Year must be a number!");
                }
            }

            Console.Write("Enter car title: ");
            title = Console.ReadLine();

            _transport = new Transport
            {
                ID = 1,
                Model = model,
                Brand = brand,
                Year = year,
                title = title
            };

            Console.WriteLine("Transport successfully created!\n");
        }

        public void GetAllTransports()
        {
            if (_transport == null)
            {
                Console.WriteLine("No transport has been created yet.");
                return;
            }

            Console.WriteLine($"Model: {_transport.Model}");
            Console.WriteLine($"Brand: {_transport.Brand}");
            Console.WriteLine($"Year: {_transport.Year}");
            Console.WriteLine($"Title: {_transport.title}");
        }
    }
}
