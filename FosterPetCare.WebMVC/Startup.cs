using FosterPetCare.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FosterPetCare.WebMVC.Startup))]
namespace FosterPetCare.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {
            var context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Create Admin Role
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                // Create Admin Account
                var user = new ApplicationUser();

                user.UserName = "Admin";
                user.Email = "admin@admin.com";
                string userPWD = "Listen";

                var checkUser = UserManager.Create(user, userPWD);

                if (checkUser.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Admin");
                }
            }
            // Create Staff Role
            if (!roleManager.RoleExists("Staff"))
            {
                var role = new IdentityRole();
                role.Name = "Staff";
                roleManager.Create(role);

                // Create Staff Account
                var user = new ApplicationUser();

                user.UserName = "Staff";
                user.Email = "staff@staff.com";
                string userPWD = "dogsarecool";

                var checkUser = UserManager.Create(user, userPWD);

                if (checkUser.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Staff");
                }
            }
            // Create User Role
            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }
        }
    }
}
