using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.OTDR.InternalGraphQL
{
    public class FooType
  : ObjectType<Foo>
    {
        protected override void Configure(IObjectTypeDescriptor<Foo> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "foo");
        }
    }

}
