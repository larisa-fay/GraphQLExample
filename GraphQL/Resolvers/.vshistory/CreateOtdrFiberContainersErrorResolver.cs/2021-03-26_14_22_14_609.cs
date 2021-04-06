using System;
using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersResultResolver
    {
        public List<OtdrFiberContainerResponseType> GetFiberContainers([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            OtdrFiberContainerResponseType tempRes =
                new OtdrFiberContainerResponseType
                { 
                FiberContainerID = Guid.NewGuid(),
                IncludeOtdrData = false,
                OtdrFiberContainerData = null,
                OtdrFiberContainerMessageList = null
                };
            List<OtdrFiberContainerResponseType> tesmList = new List<OtdrFiberContainerResponseType>();
            tesmList.Add(tempRes);
           return tesmList;
           
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
