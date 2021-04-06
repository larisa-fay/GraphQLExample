using HotChocolate.Types;
using ExampleModels.OTDR;

namespace ExampleGraphQL.InternalOTDR
{
    public class ABCWhereInput
  : InputObjectType<ABC>
    {
        public string BoBoString { get; set; }
    }

}
