using ServiceStack.Auth;
using CMMYDB.Data;

[assembly: HostingStartup(typeof(CMMYDB.ConfigureAuth))]

namespace CMMYDB;

public class ConfigureAuth : IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            services.AddPlugin(new AuthFeature(IdentityAuth.For<ApplicationUser>(options => {
                options.SessionFactory = () => new CustomUserSession();
                options.CredentialsAuth();
                options.AdminUsersFeature();
            })));
        });
}
