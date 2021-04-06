using HotChocolate.Types;
using AFL.OTDR.Service.Models.OTDR;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class ABCDWhereInput
  : ObjectType<ABCD>
    {
        public ABCWhereInput ABC { get; set;}
    }

}
