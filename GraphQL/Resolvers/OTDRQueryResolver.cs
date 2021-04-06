namespace GraphQLExample.InternalOTDR
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
