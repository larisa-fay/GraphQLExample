using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCDType
  : ObjectType<ABCD>
    {
        public ABCType ABC { get; set;}
    }

}
