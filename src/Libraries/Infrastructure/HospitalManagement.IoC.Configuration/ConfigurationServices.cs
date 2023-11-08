using HospitalManagement.Core;
using HospitalManagement.Core.Mapper;
using HospitalManagement.Infrastructure;
using HospitalManagement.Repositories.Base;
using HospitalManagement.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.IoC.Configuration;

public static class ConfigurationServices
{
    public static IServiceCollection AddExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HospitalManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
        services.AddAutoMapper(typeof(CommonMapper).Assembly);
        services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));
        services.AddTransient<IDoctorRepository, DoctorRepository>();
        return services;
    }
}