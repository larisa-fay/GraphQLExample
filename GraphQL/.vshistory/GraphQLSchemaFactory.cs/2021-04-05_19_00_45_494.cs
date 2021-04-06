using AFL.OTDR.Server.Models;
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
                .AddScoped<StatsType>()
                .AddScoped<MutationType>();

            services
                .AddGraphQLServer(OTDRConstants.INTERNAL_OTDR_GRAPHQL_SCHEMA)
                .AddDocumentFromFile(schemaFilePath)

                // Bind types.
                .BindResolver<OTDRQueryResolver>(r => r.To<QueryType>())
                .BindResolver<OTDRSorEntryResolver>(r => r.To<SorEntryType>())
                .BindResolver<OtdrFiberContainerDataResolver>(r => r.To<OtdrFiberContainerDataType>())
                .BindResolver<CreateOtdrFiberContainersResponseResolver>(r => r.To<CreateOtdrFiberContainersResponseType>())
                .BindResolver<OtdrFiberContainerResponseResolver>(r => r.To<OtdrFiberContainerResponseType>())
                .BindResolver<OtdrFiberContainerMessageResolver>(r => r.To<OtdrFiberContainerMessageType>())
                .BindResolver<CreateOtdrFiberContainersResultResolver>(r => r.To<CreateOtdrFiberContainersResultType>())
                .BindResolver<MutationResolver>(r => r.To<MutationType>())

                .BindComplexType<MutationType>(r => r.To("Mutation"))
                .BindComplexType<QueryType>(r => r.To("Query"))
                .BindComplexType<LimitWhereInput>(r => r.To("LimitWhere"))
                .BindComplexType<StatsDetailsType>(r => r.To("StatsDetails"))
                .BindComplexType<SorEntryType>(r => r.To("SorEntry"))

                .BindComplexType<OtdrFiberContainerMessageType>(r => r.To("OtdrFiberContainerMessage"))
                .BindComplexType<CreateOtdrFiberContainersErrorType>(r => r.To("CreateOtdrFiberContainersError"))


                .BindComplexType<BarType>(r => r.To("Bar"))
                .BindComplexType<FooType>(r => r.To("Foo"))
                .BindComplexType<BazType>(r => r.To("Baz"))

                .BindComplexType<CreateOtdrFiberContainersResultType>(r => r.To("CreateOtdrFiberContainersResult"))
                /*
                .BindComplexType<CreateOtdrFiberContainersResponseType>(r => r.To("CreateOtdrFiberContainersResponse"))
                */
                .BindComplexType<CreateOtdrFiberContainersWhereInput>(r => r.To("CreateOtdrFiberContainersWhere"))

                .BindComplexType<OtdrFiberContainerResponseType>(r => r.To("OtdrFiberContainerResponse"))
                .BindComplexType<OtdrFiberContainerDataType>(r => r.To("OtdrFiberContainerData"))
                .BindComplexType<OtdrFiberContainerWhereInput>(r => r.To("OtdrFiberContainerWhere"))
                .BindComplexType<OtdrFiberResultWhereInput>(r => r.To("OtdrFiberResult"))
                .BindComplexType<DriveFileWhereInput>(r => r.To("DriveFileWhere"))


                .BindComplexType<ABCDEWhereInput>(r => r.To("ABCDEWhere"))
            .BindComplexType<ABCDWhereInput>(r => r.To("ABCDWhere"))
            .BindComplexType<ABCWhereInput>(r => r.To("ABCWhere"))
            ;
            return services;

        }
    }
}
