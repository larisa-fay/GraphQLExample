using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class ABCDEWhereInput
  : InputObjectType<ABCDE>
    {
        public ABCDWhereInput ABCD { get; set;}
    }

}
