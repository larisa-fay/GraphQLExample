using System;
using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class OtdrFiberResultWhereInput : ObjectType<OtdrFiberResult>
    {
        public DriveFileWhereInput SorFileInfo { get; set; }
        public ResultDirection ResultDirection { get; set; }
        
    }
}
