using HotChocolate;
using Microsoft.Extensions.DependencyInjection;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public static class InternalOTDRSchemaFactory
    {
        public static IServiceCollection AddInternalOTDRGraphQL(
            this IServiceCollection services, string schemaFilePath)
        {
            services.AddScoped<QueryType>()
                .AddScoped<MutationType>();

            services
                .AddGraphQLServer("InternalOtdrGraphQL")
                .AddDocumentFromFile(schemaFilePath)

                // Bind types.
                .BindResolver<OTDRQueryResolver>(r => r.To<QueryType>())
                
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
