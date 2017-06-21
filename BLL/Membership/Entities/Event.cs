using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_WebEvent_Events")]
    public partial class Event
    {
		public int EventCode { get; set; }
		public int EventDetailCode { get; set; }

        [Column(TypeName = "char(32)")]
        public string EventId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime EventTimeUtc { get; set; }
        
		[Column(TypeName = "datetime")]
        public DateTime EventTime { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string EventType { get; set; }
        
		[Column(TypeName = "decimal")]
        public decimal EventSequence { get; set; }
        
		[Column(TypeName = "decimal")]
        public decimal EventOccurrence { get; set; }
        
		[MaxLength(1024)]
        public string Message { get; set; }
        
		[MaxLength(256)]
        public string ApplicationPath { get; set; }
        
		[MaxLength(256)]
        public string ApplicationVirtualPath { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string MachineName { get; set; }
        
		[MaxLength(1024)]
        public string RequestUrl { get; set; }
        
		[MaxLength(256)]
        public string ExceptionType { get; set; }
        
		[Column(TypeName = "ntext")]
        public string Details { get; set; }
    }
}
