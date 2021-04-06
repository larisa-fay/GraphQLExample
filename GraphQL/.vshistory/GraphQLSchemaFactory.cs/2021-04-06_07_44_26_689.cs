using HotChocolate;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLExample.InternalOTDR
{
	public static class GraphQLSchemaFactory
    {
        public static IServiceCollection AddGraphQL(
            this IServiceCollection services, string schemaFilePath)
        {
            services.AddScoped<QueryType>()
                .AddScoped<MutationType>();

            services
                .AddGraphQLServer()
                .AddDocumentFromFile(schemaFilePath)

                // Bind types.
                .BindResolver<QueryResolver>(r => r.To<QueryType>())
                
                .BindResolver<MutationResolver>(r => r.To<MutationType>())

                .BindComplexType<MutationType>(r => r.To("Mutation"))
                .BindComplexType<QueryType>(r => r.To("Query"))
                

                .BindComplexType<BarType>(r => r.To("Bar"))
                .BindComplexType<FooType>(r => r.To("Foo"))
                .BindComplexType<BazType>(r => r.To("Baz"))

                .BindComplexType<ABCDEWhereInput>(r => r.To("ABCDEWhere"))
            .BindComplexType<ABCDWhereInput>(r => r.To("ABCDWhere"))
            .BindComplexType<ABCWhereInput>(r => r.To("ABCWhere"))
            ;
            return services;

        }
    }
}
