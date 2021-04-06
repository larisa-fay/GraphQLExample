using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
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
