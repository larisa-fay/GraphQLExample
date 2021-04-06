using System;
using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR 
{
	public class OtdrFiberContainerWhereInput : InputObjectType<OtdrFiberContainer>
    {
        public int FiberContainerID { get; set; }
        
        public List<OtdrFiberResultWhereInput> Results { get; set; }
    }
}
