using System;
using System.Collections.Generic;
using System.Text;
using Services.IServices;
using Models;

namespace Services
{
    public class TransportCardService : ITransportCardService
    {
        TransportCard TransportCard { get;set; }

        public TransportCardService()
        {
            TransportCard = new TransportCard();
            TransportCard.Balance = 0;
        }

        public void Add(int sum)
        {
            if (sum >= 0)
            {
                TransportCard.Balance+=sum;
            }
        }

        public int CheckBalance()
        {
            return TransportCard.Balance;
        }

        public bool Validate(int busPrice)
        {
            if (TransportCard.Balance >= busPrice)
            {
                TransportCard.Balance -= busPrice;
                return true;
            }
            return false;
        }
    }
}
