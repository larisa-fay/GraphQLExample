using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersErrorType : ObjectType
    {
        public int ErrorCode { get; set; }

    }
}