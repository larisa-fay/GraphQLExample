using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class FooType
  : ObjectType<Foo>, IFooBarBaz
    {
        /*
        protected override void Configure(IObjectTypeDescriptor<Foo> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "foo");
        }
        */
        public string Foo { get; set; }
    }

}
