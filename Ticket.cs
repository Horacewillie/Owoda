using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owoda
{
    class Ticket

    {
        public double Total { get; set; }
        public double DefaultPrice { get; set; }
        public int TotalNumberOfTicketSold { get; set; }

        public Ticket()
        {
            DefaultPrice = 100;
            Total = 0;
            TotalNumberOfTicketSold = 0;

        }


        //Genearte 13 Random Digits;
        public string GenerateRandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
            {
                s = String.Concat(s, random.Next(13).ToString());
            }
            return s;
        }

        public void ChooseOperation()
        {
            Console.WriteLine("Welcome to Owoda Application \nPlease Choose An Operation. \n1. Purchase Ticket \n2. Check Summary");
            Console.WriteLine("***************************************************************");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************");
            while (userInput == 1)
            {
                PurchaseTicket();
                Console.WriteLine("Please Choose An Operation. \n1. Purchase Ticket \n2. Check Summary");
                Console.WriteLine("***************************************************************");
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("***************************************************************");

                TotalNumberOfTicketSold++;
            }
            Summation();   
        }

        public void PurchaseTicket()
        {
           

            double ticketPrice;
            Console.WriteLine("Choose a ticket type: \n1. Daily \n2. Monthly");
            Console.WriteLine("***************************************************************");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************");

            if (userInput == 1)
            {
                ticketPrice = DefaultPrice;
            }
            else
            {
                ticketPrice = DefaultPrice / 2;
            }
            Total += ticketPrice;
            Console.WriteLine($"Purchase Succesful! Ticket Id is {GenerateRandomDigits(13)}");
        }

        public void Summation()
        {
            Console.WriteLine($"Number of tickets sold today is {TotalNumberOfTicketSold}");
            Console.WriteLine($"Total amount made today is {Total}");
            double remittance = 0.65 * Total;
            Console.WriteLine($"You are to remit the sum of #{remittance} to Supervisor");
        }
    }
}
