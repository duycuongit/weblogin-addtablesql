using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webtest3.Data;
using webtest3.Areas.Identity.Data;
using System.Linq;

namespace webtest3.Areas.Identity.Pages.Role
{
    public class IndexModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<webtest3User> _userManager;
        //private readonly webtest3DbContext _webtest3DbContext;

        public IndexModel(RoleManager<IdentityRole> roleManager/*, webtest3DbContext webtest3DbContext*//*, UserManager <webtest3User> userManager*/)
        {
            _roleManager = roleManager;
            //_userManager = userManager;
            //_webtest3DbContext = webtest3DbContext;
        }
        public List<IdentityRole> roles { set; get; }

        [TempData] // Sử dụng Session lưu thông báo
        public string StatusMessage { get; set; }

        //public async Task OnGet()
        //{
        //    roles = await _roleManager.Roles.ToListAsync();
        //    return Page();
        //}


        public async Task<IActionResult> OnGet()
        {
            roles = await _roleManager.Roles.ToListAsync();
            return Page();
        }

        //public void OnPost() => RedirectToPage();
    }
}
