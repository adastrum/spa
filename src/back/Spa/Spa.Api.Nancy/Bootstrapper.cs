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

            pipelines.AfterRequest.AddItemToEndOfPipeline(context => context.Response
                .WithHeader("Access-Control-Allow-Origin", "http://localhost:4200")
                .WithHeader("Access-Control-Allow-Methods", "POST, GET, DELETE, PUT, OPTIONS")
                .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type")
                .WithHeader("Allow", "POST, GET, DELETE, PUT, OPTIONS"));
        }
    }
}
