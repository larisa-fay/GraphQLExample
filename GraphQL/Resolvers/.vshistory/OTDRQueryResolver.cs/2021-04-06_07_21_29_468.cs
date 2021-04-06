using HotChocolate;
namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    public class QueryResolver
    {
        public FooType GetStats()
        {
            FooType res = new FooType()
            {
                Foo = "I am Foo"
            };
            return res;

        }
    }

}
