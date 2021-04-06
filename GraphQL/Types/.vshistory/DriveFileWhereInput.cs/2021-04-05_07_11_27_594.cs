using AFL.OTDR.Server.Models;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class DriveFileWhereInput : InputObjectType<DriveFile>
    {
        public string SorFilePath { get; set; }
        // In this version we won't have Version parameter
        // The latest version of the file will be used
        // if more than one version is available
        public string Version { get; set; } = null;

    }
}