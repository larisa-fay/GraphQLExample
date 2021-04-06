﻿using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CreateOtdrFiberContainersWhereResolver
    {
        public List<OtdrFiberContainerWhereInput> GetFibers([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            List<OtdrFiberContainerWhereInput> tempResult = new List<OtdrFiberContainerWhereInput>();
            OtdrFiberContainerWhereInput tempCopyFiberResponseType = new OtdrFiberContainerWhereInput
            { 
                
                OtdrFiberResultsWhereList = null
                
            };
            tempResult.Add(tempCopyFiberResponseType);
           return tempResult;
           
        }
	}
}
