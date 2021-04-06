using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class DriveFileWhereInput : InputObjectType
    {
        public string SorFilePath { get; set; }
        public string Version { get; set; }

    }
}