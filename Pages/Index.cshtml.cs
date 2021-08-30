using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_World.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "Hello from CS4790! ";
        public void OnGet()
        {
            Message += $"Server Time is {DateTime.Now}";
        }
        public void OnPost() { }
    }
}
