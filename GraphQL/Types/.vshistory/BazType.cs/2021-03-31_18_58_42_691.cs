using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.OTDR.InternalGraphQL.Types
{
    public class BarType
  : ObjectType<Bar>
    {
        protected override void Configure(IObjectTypeDescriptor<Bar> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "bar");
        }
    }

}
