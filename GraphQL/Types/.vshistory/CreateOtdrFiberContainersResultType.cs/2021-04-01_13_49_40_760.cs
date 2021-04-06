using System.Collections.Generic;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersResultType : ObjectType
    {
        public List<OtdrFiberContainerResponseType> OtdrFiberContainerResponseList { get; set; }
    }
}