﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff: Passenger
    {
        public int Id { get; set; }

        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }
        [DataType(DataType.Currency)]
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a staff");
        }
    }
    
}
