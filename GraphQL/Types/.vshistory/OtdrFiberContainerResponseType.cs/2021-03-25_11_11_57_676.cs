using System;
using System.Collections.Generic;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CopyFiberResponseResultType
    {
        public Guid FiberContainerID { get; set; }
        public bool IncludeOTDRData { get; set; }

        public List<CopyFiberMessageType> CopyFiberMessageList { get; set; }

        public CopyFiberDataType CopyFiberData { get; set; }

    }
}