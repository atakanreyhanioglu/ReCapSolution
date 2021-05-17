using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

    namespace Entities.Concrete
    {
        public class Payment : IEntity  
        {
            public int Id { get; set; }
            public int UserId { get; set; }      
            public string CreditCardNumber { get; set; }
            public string ExpirationDate { get; set; }
            public string SecurityCode { get; set; }
        }
    }

