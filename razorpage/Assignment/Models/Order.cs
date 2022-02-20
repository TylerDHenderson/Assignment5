using System;

namespace Assignment_3_New.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public double totalPrice {get;set;}
        public DateTime Date {get;set;}
        public Customer Customer {get;set;}
        public Driver Driver {get;set;}
    }
}