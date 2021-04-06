using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class BazType
  : ObjectType<Baz> , IFooBarBaz
    {
        /*
        protected override void Configure(IObjectTypeDescriptor<Baz> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "baz");
        }
        */
        public string Baz { get; set; }
    }

}
