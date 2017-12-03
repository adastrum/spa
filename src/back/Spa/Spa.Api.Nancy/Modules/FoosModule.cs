using Nancy;
using Spa.Api.Nancy.Services;

namespace Spa.Api.Nancy.Modules
{
    public class FoosModule : NancyModule
    {
        private readonly IFooService _fooService;

        public FoosModule(IFooService fooService)
        {
            _fooService = fooService;

            Get["/foos"] = _ => GetFoos();
        }

        private dynamic GetFoos()
        {
            var foos = _fooService.GetFoos();
            return Negotiate.WithModel(foos);
        }
    }
}