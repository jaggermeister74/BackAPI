using BackAPI.Services;


namespace BackAPI.RegistrationServices
{
    public static class ApiRegistrationExtensions
    {
        /// <summary>
        /// Регистрация сервисов приложения
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
            return services;
        }
    }
}