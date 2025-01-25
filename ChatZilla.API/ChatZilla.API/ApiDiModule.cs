namespace ChatZilla.API
{
    public static class ApiDiModule
    {
        public static IServiceCollection BuildApiDiModule(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            
            return services;
        }   
    }
    
}

