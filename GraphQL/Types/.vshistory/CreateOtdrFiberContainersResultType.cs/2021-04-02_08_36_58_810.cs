using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersResultType : ObjectType, ICreateOtdrFiberContainersResponse
    {
        public List<OtdrFiberContainerResponseType> OtdrFiberContainerResponseList { get; set; }
    }
}