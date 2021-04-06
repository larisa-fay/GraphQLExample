using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCDWhereInput
  : InputObjectType<ABCD>
    {
        public ABCWhereInput ABC { get; set;}
    }

}
