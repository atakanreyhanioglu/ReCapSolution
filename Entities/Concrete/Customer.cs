using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Customer :IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
       
    }
}
