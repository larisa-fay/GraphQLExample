using System;
using AFL.OTDR.Server.Models;
using AFL.TraceReapplyService;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
    /// <summary>
    /// SorEntryType is a GraphQL type which corresponds to SorEntry Model
    /// It is for internal (debugging) use only
    /// </summary>
    public class SorEntryType : ObjectType
    {
        public Guid SorUUID { get; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string FolderPath { get; set; }

        public SorFile SorFile { get; set; }

        public DateTime LastUpdated { get; set; }

        public string ContainerUUID { get; set; }

        public string ProjectUUID { get; set; } 

        public string Warnings { get; set; }

        public short Wavelength { get; set; }

        public Directions Dir { get; set; }

        public string SorMetadata { get; set; }

        public string ErrorMessage { get; set; }

        public int ErrorCode { get; set; }

        public string SourceSorEntry { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; }

        public PassFailStatus PassFailStatus { get; set; }

        public int FiberNumber { get; set; }

        public string Cable { get; set; }

        public string End1 { get; set; }

        public string End2 { get; set; }

    }
}
