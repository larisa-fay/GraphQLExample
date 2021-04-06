using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class MutationResolver
    {
        public CreateOtdrFiberContainersResponseType GetCreateOtdrFiberContainers([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            CreateOtdrFiberContainersWhereInput where)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CreateOtdrFiberContainersResponseType tempResponse = new CreateOtdrFiberContainersResponseType
            {
                CreateOtdrFiberContainersResult = new CreateOtdrFiberContainersResultType(),
                CreateOtdrFiberContainersError = new CreateOtdrFiberContainersErrorType() 
            };
           return tempResponse;
           
        }
	}
}
