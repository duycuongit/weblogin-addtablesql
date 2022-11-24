using Microsoft.AspNetCore.Identity;

namespace webtest3.Data
{
    public class AppUser : IdentityUser
    {
        // Khai báo thêm các thuộc tính ngoài các thuộc
        // tính như UserName, Email ... cung cấp sẵn bởi IdentityUser
        public string mssv { set; get; }
    }
}
