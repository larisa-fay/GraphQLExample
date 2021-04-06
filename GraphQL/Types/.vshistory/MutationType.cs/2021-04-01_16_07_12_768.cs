
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class MutationType : ObjectType
    {
        public CreateOtdrFiberContainersResponseType CreateOtdrFiberContainersResponse { get; set; }

        public FooBarBazType Uniontest { get; set; }
    }
}