using AutoMapper;
using HotChocolate;

namespace GraphQLExample.InternalOTDR
{
	public class MutationResolver
    {
        
        
        public string GetDoABCDE(
            ABCDEWhereInput where)
        {

            return "That was ABCDE";

        }
        
    }
}
