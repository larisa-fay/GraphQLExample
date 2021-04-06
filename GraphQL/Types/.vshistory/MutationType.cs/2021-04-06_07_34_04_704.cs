
using HotChocolate.Types;

namespace ExampleGraphQL.InternalOTDR
{
    public class MutationType : ObjectType
    {
        public FooBarBazType Uniontest { get; set; }
    }
}