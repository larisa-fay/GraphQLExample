using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CopyResponseResolver
    {
        public List<CopyFiberResponseType> GetFibers([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            List<CopyFiberResponseType> tempResult = new List<CopyFiberResponseType>();
            CopyFiberResponseType tempCopyFiberResponseType = new CopyFiberResponseType { 
                CopyFiberResponseError = new CopyFiberResponseErrorType 
                {
                    ErrorCode = 999
                }
            };
            tempResult.Add(tempCopyFiberResponseType);
           return tempResult;
           
        }
	}
}
