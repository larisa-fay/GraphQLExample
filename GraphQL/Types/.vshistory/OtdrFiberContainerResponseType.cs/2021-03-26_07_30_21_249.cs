using System;
using System.Collections.Generic;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerResponseType
    {
        public Guid FiberContainerID { get; set; }
        public bool IncludeOtdrData { get; set; }

        public List<OtdrFiberContainerMessageType> CopyFiberMessageList { get; set; }

        public OtdrFiberContainerDataType OtdrFiberContainerData { get; set; }

    }
}