
using HotChocolate.Types;

namespace GraphQLExample.InternalOTDR
{
    public class MutationType : ObjectType
    {
        public FooBarBazType Uniontest { get; set; }
    }
}