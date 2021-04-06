using System;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Service.GraphQL;
using AFL.OTDR.Service.GraphQL.InternalOTDR;
using AFL.OTDR.Service.Utility;
using AutoMapper;

namespace AFL.OTDR.Server
{
	public class AutoMapperUtility
    {

        public static MapperConfiguration CreateMapperConfig()
        {

            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Organization, OrganizationType>();
                cfg.CreateMap<Project, ProjectType>();
                cfg.CreateMap<Project, ProjectOverviewType>();
                cfg.CreateMap<ResultsPassFailSummary, PassFailTotalsType>();
                cfg.CreateMap<FiberGroupSummary, FiberGroupSummaryType>()
                    .ForMember(dest => dest.Cable,
                        opt => opt.MapFrom(src => new StringVariesType { Value = src.Cable, Varies = false }))
                    .ForMember(dest => dest.End1,
                        opt => opt.MapFrom(src => new StringVariesType { Value = src.End1, Varies = false }))
                    .ForMember(dest => dest.End2,
                        opt => opt.MapFrom(src => new StringVariesType { Value = src.End2, Varies = false }));
                cfg.CreateMap<FiberGroupLinkSummary, FiberGroupLinkSummaryType>();
                cfg.CreateMap<LinkSummary, LinkSummaryType>();
                cfg.CreateMap<FiberConnection, FiberConnectionType>();
                cfg.CreateMap<FiberEdge, FiberEdgeType>();
                cfg.CreateMap<Fiber, FiberType>();
                cfg.CreateMap<OTDRData, OTDRDataType>();
                cfg.CreateMap<OTDRConfigurationSummary, OTDRConfigurationSummaryType>();
                cfg.CreateMap<EventDetectionCriteria, EventDetectionCriteriaType>();
                cfg.CreateMap<EventPassFailCriteria, EventPassFailCriteriaType>();
                cfg.CreateMap<LinkPassFailCriteria, LinkPassFailCriteriaType>();
                cfg.CreateMap<LinkPassFailCriteriaWavelength, LinkPassFailCriteriaWavelengthType>();
                cfg.CreateMap<OTDRTestEquipmentInfo, OTDRTestEquipmentInfoType>();
                cfg.CreateMap<OTDRSetup, OTDRSetupType>();
                cfg.CreateMap<FloatVaries, FloatVariesType>();
                cfg.CreateMap<IntVaries, IntVariesType>();
                cfg.CreateMap<FloatListVaries, FloatListVariesType>();
                cfg.CreateMap<IntListVaries, IntListVariesType>();
                cfg.CreateMap<StringVaries, StringVariesType>();
                cfg.CreateMap<OTDRTestModeVaries, OTDRTestModeVariesType>();
                cfg.CreateMap<EventTable, EventTableType>();
                cfg.CreateMap<FiberEvent, FiberEventType>();
                cfg.CreateMap<ResultEvent, ResultEventType>();
                cfg.CreateMap<UploadInfo, UploadInfoType>();
                cfg.CreateMap<UploadSummary, UploadSummaryType>();
                cfg.CreateMap<UploadFileInfo, UploadFileInfoType>();
                cfg.CreateMap<FilePathLastUpdated, FilePathLastUpdatedType>();
                cfg.CreateMap<int, DateTime>().ConvertUsing<UnixTimeToDateTimeConverter>();
                cfg.CreateMap<SorEntry, SorEntryType>();
                cfg.CreateMap<SorEntryType, SorEntry>();
                cfg.CreateMap<DriveFileInput, DriveFile>();
                cfg.CreateMap<OtdrFiberResultWhereInput, DriveFileDirection>();
                
            });
        }
    }
}