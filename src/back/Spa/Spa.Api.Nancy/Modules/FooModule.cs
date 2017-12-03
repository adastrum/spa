using Nancy;
using Spa.Api.Nancy.Services;

namespace Spa.Api.Nancy.Modules
{
    public class FooModule : NancyModule
    {
        private readonly IFooService _fooService;

        public FooModule(IFooService fooService)
        {
            _fooService = fooService;

            Get["/foos/{id}"] = GetFooById;
        }

        private dynamic GetFooById(dynamic parameters)
        {
            var foo = _fooService.GetFooById((int)parameters.id);
            return Negotiate.WithModel(foo);
        }
    }
}