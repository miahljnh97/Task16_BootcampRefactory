using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task16_BootcampRefactory.Model;

namespace Task16_BootcampRefactory.Controllers
{
    [ApiController]
    [Authorize]
    [Route("customer")]
    public class CustomerController : Controller
    {
        private readonly JWTContext _context;

        public CustomerController(JWTContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var customer = _context.customers;

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _context.customers.First(i => i.Id == id);

            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _context.customers.First(i => i.Id == id);

            _context.customers.Remove(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Customers customerput)
        {
            var customer = _context.customers.First(i => i.Id == id);

            customer.full_name = customerput.full_name;
            customer.username = customerput.username;
            customer.email = customerput.email;
            customer.phone_number = customerput.phone_number;
            customer.created_at = customer.created_at;
            customer.update_at = DateTime.Now;

            _context.customers.Update(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post(Customers customer)
        {
            _context.customers.Add(customer);
            _context.SaveChanges();
            return Ok(new
            {
                message = "success retrieve data",
                status = true,
                data = customer
            });
        }
    }
}