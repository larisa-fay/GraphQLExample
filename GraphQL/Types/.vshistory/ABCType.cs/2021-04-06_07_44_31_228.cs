using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCWhereInput
  : InputObjectType<ABC>
    {
        public string BoBoString { get; set; }
    }

}
