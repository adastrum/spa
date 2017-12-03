using System.Collections.Generic;

namespace Spa.Api.Nancy.Models
{
    public class Foo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<Bar> Bars { get; set; }
    }
}