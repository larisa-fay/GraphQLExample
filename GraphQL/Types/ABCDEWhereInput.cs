using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCDEWhereInput
  : InputObjectType<ABCDE>
    {
        public ABCDType ABCD { get; set;}
    }

}
