using HotChocolate.Types;
using ExampleModels.OTDR;

namespace ExampleGraphQL.InternalOTDR
{
    public class ABCDWhereInput
  : InputObjectType<ABCD>
    {
        public ABCWhereInput ABC { get; set;}
    }

}
