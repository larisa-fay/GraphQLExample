using System;
using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerWhereInput : InputObjectType
    {
        public Guid FiberContainerID { get; set; }

        public List<OTDRFiberResultsWhereInput> CopyFiberResultsWhereList { get; set; }
    }
}
