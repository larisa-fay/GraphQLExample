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
        public CopyFiberResponseResultType GetTempCopyFiberResponseResult([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CopyFiberResponseResultType tempresult = new CopyFiberResponseResultType
            {
                FiberContainerID = Guid.NewGuid(),
                IncludeOTDRData = false,
                CopyFiberMessageList = new List<CopyFiberMessageType>()

            };

           return tempresult;
           
        }
        public CopyFiberResponseErrorType GetTempCopyFiberResponseError([Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

            StatsDetailsType stats = new StatsDetailsType
            {
                TotalSorEntries = fileService.EntryCount(),
                SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
            };

            CopyFiberResponseErrorType error = new CopyFiberResponseErrorType
            {
                ErrorCode =  1234567890
            };
            return error;

        }
    }
}
