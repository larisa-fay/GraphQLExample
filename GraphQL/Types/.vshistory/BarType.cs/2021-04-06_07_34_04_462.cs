using HotChocolate.Types;
using ExampleModels.OTDR;

namespace ExampleGraphQL.InternalOTDR

{
    public class BarType
  : ObjectType<Bar>, IFooBarBaz
    {
        /*
        protected override void Configure(IObjectTypeDescriptor<Bar> desc)
        {
            desc.IsOfType((context, result) => result is string s && s == "bar");
        }
        */
        public string Bar { get; set; }
    }

}
