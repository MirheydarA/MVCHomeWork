using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVCHomework.Models;


namespace MVCHomework.Pages.Movies;

public class DetailsModel : PageModel
{
    private readonly MVCHomework.Data.MVCHomeworkContext _context;

    public DetailsModel(MVCHomework.Data.MVCHomeworkContext context)
    {
        _context = context;
    }

    public Movie Movie { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

        if (Movie == null)
        {
            return NotFound();
        }
        return Page();
    }
}
