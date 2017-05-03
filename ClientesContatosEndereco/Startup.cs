using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientesContatosEndereco.Startup))]
namespace ClientesContatosEndereco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
