using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.OTDR.InternalGraphQL.Types
{
    public class BazType
  : ObjectType<Baz>
    {
        protected override void Configure(IObjectTypeDescriptor<Baz> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "baz");
        }
    }

}
