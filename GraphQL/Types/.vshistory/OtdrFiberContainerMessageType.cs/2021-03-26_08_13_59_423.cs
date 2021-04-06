namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerMessageType
    {
        public MessageLevelType MessageLevel { get; set; }

        public int MessageCode { get; set; }
        public string InternalMessage { get; set; }

    }
}