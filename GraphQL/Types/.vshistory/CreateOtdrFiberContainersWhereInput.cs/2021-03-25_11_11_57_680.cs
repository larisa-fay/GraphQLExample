using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class CopyRequestWhereInput : InputObjectType
    {
        public List<CopyFiberContainerWhereInput> CopyFiberContainerWhereList { get; set; }
    }
}
