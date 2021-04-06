using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class DriveFileResolver
    {
        public string GetSorFilePath([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            [Parent] DriveFileType driveFileType )
        {

            string res = driveFileType.SorFilePath;
           return res;
           
        }
	}
}
