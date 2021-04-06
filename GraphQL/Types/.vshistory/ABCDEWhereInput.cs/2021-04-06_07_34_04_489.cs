using HotChocolate.Types;
using ExampleModels.OTDR;

namespace ExampleGraphQL.InternalOTDR
{
    public class ABCDEWhereInput
  : InputObjectType<ABCDE>
    {
        public ABCDWhereInput ABCD { get; set;}
    }

}
