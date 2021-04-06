using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    
    public class CreateOtdrFiberContainersResponseType : UnionType<ICreateOtdrFiberContainersResponse>
    {
        public CreateOtdrFiberContainersResultType CreateOtdrFiberContainersResult { get; set; }
        public CreateOtdrFiberContainersErrorType CreateOtdrFiberContainersError { get; set; }

    }
}