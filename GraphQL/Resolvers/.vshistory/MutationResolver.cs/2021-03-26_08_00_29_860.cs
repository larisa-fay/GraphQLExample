using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class MutationResolver
    {
        public CreateOtdrFiberContainersResponseType GetCopyRequest([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            CreateOtdrFiberContainersWhereInput where)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CreateOtdrFiberContainersResultType tempResult = new CreateOtdrFiberContainersResultType
            {
                CopyFiberResponseList = new List<CopyFiberResponseType>()
            };
           return tempResult;
           
        }
	}
}
