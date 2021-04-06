using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCWhereInput
  : ObjectType<ABC>
    {
        public string AbcString { get; set; }
    }

}
