using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameShop.Entities
{
    public class Adult : ICustomer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string StudentId { get; set; }

    }
}
