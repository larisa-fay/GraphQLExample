using HotChocolate.Types;
using ExampleModels.OTDR;

namespace GraphQLExample.InternalOTDR
{
    public class ABCType
  : ObjectType<ABC>
    {
        public string AbcString { get; set; }
    }

}
