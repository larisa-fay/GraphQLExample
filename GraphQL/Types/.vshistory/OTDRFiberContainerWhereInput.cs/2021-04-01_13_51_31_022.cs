using System;
using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR : ObjectType
{
	public class OtdrFiberContainerWhereInput : InputObjectType
    {
        public Guid FiberContainerID { get; set; }
        
        public List<OtdrFiberResultWhereInput> OtdrFiberResultsWhereList { get; set; }
    }
}
