using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApplication.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(string name)
        {
            Name = name;
        }
    }
}
