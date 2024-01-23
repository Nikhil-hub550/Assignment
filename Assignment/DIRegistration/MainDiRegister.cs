using Assignment.BusinessLogic.Interface;
using Assignment.BusinessLogic.Services;
using Assignment.DataAccess.Interface;
using Assignment.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DIRegistration
{
    public static class MainDiRegister
    {
        public static void RegisterMainDI(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
