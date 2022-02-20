using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Assignment_3_New.Models;

namespace Assignment_3_New.Pages
{
    public class DriverModel : PageModel
    {
        private readonly DbContext _context;
        private readonly ILogger<DriverModel> _logger;
        [BindProperty]
        public Driver Driver {get; set;}
        public DriverModel(DbContext context, ILogger<DriverModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}