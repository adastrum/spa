using System.Collections.Generic;
using System.Linq;
using Spa.Api.Nancy.Models;

namespace Spa.Api.Nancy.Services
{
    public interface IFooService
    {
        IEnumerable<Foo> GetFoos();

        Foo GetFooById(int id);
    }

    public class FooService : IFooService
    {
        private readonly IEnumerable<Foo> _foos = new[]
        {
            new Foo {Id = 1, Name = "John"},
            new Foo {Id = 2, Name = "Jane", Description = "the ten most critical web application security risks"},
            new Foo
            {
                Id = 3,
                Name = "Jake",
                Bars = new[]
                {
                    new Bar {Name = "table", Amount = 42},
                    new Bar {Name = "chair", Amount = 1337},
                    new Bar {Name = "sofa", Amount = 999.99m}
                }
            }
        };

        public IEnumerable<Foo> GetFoos()
        {
            return _foos;
        }

        public Foo GetFooById(int id)
        {
            return _foos.FirstOrDefault(x => x.Id == id);
        }
    }
}