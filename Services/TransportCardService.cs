using System;
using System.Collections.Generic;
using System.Text;
using Services.IServices;
using Models;

namespace Services
{
    class TransportCardService : ITransportCardService
    {
        public void Add(int sum, TransportCard transportCard)
        {
            if (sum >= 0)
            {
                transportCard.Balance += sum;
            }
        }

        public int CheckBalance(TransportCard transportCard)
        {
            return transportCard.Balance;
        }

        public bool Validate(int balance, int busPrice)
        {
            if (balance >= busPrice)
            {
                balance -= busPrice;
                return true;
            }
            return false;
        }
    }
}
