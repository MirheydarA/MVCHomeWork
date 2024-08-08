﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVCHomework.Data;
using MVCHomework.Models;

namespace MVCHomework.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MVCHomework.Data.MVCHomeworkContext _context;

        public IndexModel(MVCHomework.Data.MVCHomeworkContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
