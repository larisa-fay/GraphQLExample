using System;
using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersResponseResolver
    {
        public CreateOtdrFiberContainersResultType GetTempCreateOtdrFiberContainersResult([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CreateOtdrFiberContainersResultType tempRes =
                new CreateOtdrFiberContainersResultType { 
                OtdrFiberContainerResponseList = null
                };

           return tempRes;
           
        }
        public CreateOtdrFiberContainersErrorType GetTempCreateOtdrFiberContainersError([Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

            StatsDetailsType stats = new StatsDetailsType
            {
                TotalSorEntries = fileService.EntryCount(),
                SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
            };

            CreateOtdrFiberContainersErrorType tempres =
                new CreateOtdrFiberContainersErrorType { 
                    ErrorCode = 123
                };
            return tempres;

        }
    }
}
