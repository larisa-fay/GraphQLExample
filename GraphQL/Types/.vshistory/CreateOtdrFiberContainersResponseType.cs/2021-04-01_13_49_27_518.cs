namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersResponseType : ObjectType
    {
        public CreateOtdrFiberContainersResultType CreateOtdrFiberContainersResult { get; set; }
        public CreateOtdrFiberContainersErrorType CreateOtdrFiberContainersError { get; set; }

    }
}