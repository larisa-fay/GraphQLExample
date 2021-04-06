using AutoMapper;
using HotChocolate;

namespace ExampleGraphQL.InternalOTDR
{
	public class MutationResolver
    {
        
        public IFooBarBaz GetUniontest(
            [Service] IMapper mapper)
        {
            BazType b = new BazType()
            {
                Baz = "This is the object of type Baz",
                
                
            };

            BarType r = new BarType()
            {
                Bar = "This is the object of type Bar",


            };
            
            return r;

        }
        public string GetDoABCDE(
            ABCDWhereInput where)
        {
            

            return "Good";

        }
    }
}
