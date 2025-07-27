using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_webapp_kaycee.Data;
using az_webapp_kaycee.Models;

namespace az_webapp_kaycee.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly az_webapp_kaycee.Data.AppDbContext _context;

        public IndexModel(az_webapp_kaycee.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
