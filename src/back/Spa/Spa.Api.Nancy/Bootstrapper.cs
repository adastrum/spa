using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Spa.Api.Nancy.Services;

namespace Spa.Api.Nancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<FooService>();
        }
    }
}
