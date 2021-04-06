using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public interface ICreateOtdrFiberContainersResponse { }
    public class CreateOtdrFiberContainersResponseType : UnionType<ICreateOtdrFiberContainersResponse>
    {
        public CreateOtdrFiberContainersResultType CreateOtdrFiberContainersResult { get; set; }
        public CreateOtdrFiberContainersErrorType CreateOtdrFiberContainersError { get; set; }

    }
}