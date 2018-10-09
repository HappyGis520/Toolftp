using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EllaMaker.Api.Enum;

namespace EllaMaker.Api.Request
{
    public class DocBaseInfoApiModel
    {
        public string sourceId { get; set; }
        public string sourceName { get; set; }
        public EnumDocType type { get; set; }
    }
}
