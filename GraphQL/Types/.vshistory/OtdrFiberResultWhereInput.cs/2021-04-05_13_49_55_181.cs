﻿using System;
using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class OtdrFiberResultWhereInput : InputObjectType<OtdrFiberResult>
    {
        //public DriveFileWhereInput DriveFile { get; set; }
        public string SorFilePath { get; set; }
        public ResultDirection ResultDirection { get; set; }
        
    }
}
