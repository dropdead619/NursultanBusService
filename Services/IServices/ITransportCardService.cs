using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services.IServices
{
    interface ITransportCardService
    {
        public void Add(int sum, TransportCard transportCard);

        public int CheckBalance(TransportCard transportCard);

        public bool Validate(int balance, int busPrice);
    }
}
