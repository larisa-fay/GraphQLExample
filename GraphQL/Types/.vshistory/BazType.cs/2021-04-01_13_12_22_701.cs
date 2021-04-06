using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class BazType
  : ObjectType<Baz>
    {
        protected override void Configure(IObjectTypeDescriptor<Baz> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "baz");
        }
        public string FieldBaz { get; set; }
    }

}
