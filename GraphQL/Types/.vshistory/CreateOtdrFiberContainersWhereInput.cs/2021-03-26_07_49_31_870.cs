using System.Collections.Generic;
using HotChocolate.Types;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class CreateOtdrFiberContainersWhere : InputObjectType
    {
        public List<OtdrFiberContainerWhereInput> OtdrFiberContainerWhereList { get; set; }
    }
}
