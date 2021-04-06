using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

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
