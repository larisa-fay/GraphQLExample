using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.OTDR.InternalGraphQL.Types
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
