using System;
using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class OtdrFiberResultsWhereInput : InputObjectType
    {
        public DriveFileWhereInput DriveFile { get; set; }

        public int Wavelength { get; set; }
        public ResultDirection ResultDirection { get; set; }
    }
}
