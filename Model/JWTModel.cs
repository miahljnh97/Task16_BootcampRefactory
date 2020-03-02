using System;
namespace Task16_BootcampRefactory.Model
{
    public class Customers
    {
        public int Id { get; set; }
        public string full_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime update_at { get; set; } = DateTime.Now;
    }

    public class Products
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime update_at { get; set; } = DateTime.Now;
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
