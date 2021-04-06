
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class MutationType : ObjectType
    {
        public FooBarBazType Uniontest { get; set; }
    }
}