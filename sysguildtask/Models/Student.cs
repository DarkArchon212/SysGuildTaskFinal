using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sysguildtask.Models
{
    public class Student
    {
        //Getters and settesr for properties
        [Key] //key needed for dbcontext
        public String FirstName { get; set; }
        public String LastName  { get; set; }
        public String EmailID   { get; set; }
        public String PhoneNo   { get; set; }
    }
}
