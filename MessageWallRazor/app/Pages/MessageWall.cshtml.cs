using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }
        [BindProperty]
        public List<string> Messages { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Messages.Add(Message);
            return Page();
        }
    }
}
