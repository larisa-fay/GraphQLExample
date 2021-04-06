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
            CreateOtdrFiberContainersWhereInput containersInputList)
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

			System.Collections.IList list = containersInputList.OtdrFiberContainerWhereList;
			for (int i = 0; i < list.Count; i++)
			{
				List<OtdrFiberContainerWhereInput> contIdFileDirList = (List<OtdrFiberContainerWhereInput>)list[i];
			}
           return tempResponse;
           
        }
        public IFooBarBaz GetUniontest([Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            BazType b = new BazType()
            {
                Baz = "This is the object of type Baz",
                
                
            };

            
            FooBarBazType res = new FooBarBazType()
            {
                
            };
            
            return b;

        }
    }
}
