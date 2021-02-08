using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services.IServices
{
    public interface ITransportCardService
    {
        public void Add(int sum);

        public int CheckBalance();

        public bool Validate(int busPrice);
    }
}
