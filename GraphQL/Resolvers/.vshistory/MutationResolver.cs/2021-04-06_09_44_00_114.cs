using AutoMapper;
using HotChocolate;

namespace GraphQLExample.InternalOTDR
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
            ABCDEWhereInput where)
        {

            return "That was ABCDE";

        }
        public string GetDoABCD(
            ABCDWhereInput where)
        {

            return "That was ABCD";

        }
    }
}
