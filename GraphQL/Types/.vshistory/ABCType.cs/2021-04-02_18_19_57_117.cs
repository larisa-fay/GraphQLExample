using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class ABCWhereInput
  : InputObjectType<ABC>
    {
        public string AString { get; set; }
    }

}
