using System;
using System.Collections.Generic;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerResponseType
    {
        public Guid FiberContainerID { get; set; }
        public bool IncludeOtdrData { get; set; }

        public List<CopyFiberMessageType> CopyFiberMessageList { get; set; }

        public CopyFiberDataType CopyFiberData { get; set; }

    }
}