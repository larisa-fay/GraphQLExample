using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class DriveFileWhereInput : InputObjectType
    {
        public string SorFilePath { get; set; }
        // In this version we won't have version
        public string Version { get; set; } = null;

    }
}