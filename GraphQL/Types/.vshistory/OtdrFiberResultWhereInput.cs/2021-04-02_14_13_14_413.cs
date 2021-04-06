using System;
using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class OtdrFiberResultWhereInput : InputObjectType
    {
        public DriveFileType DriveFile { get; set; }

        public ResultDirection ResultDirection { get; set; }
    }
}
