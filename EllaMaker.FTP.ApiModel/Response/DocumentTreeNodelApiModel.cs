using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.Api.Response
{
    public class DocumentTreeNodelApiModel
    {
        public string Name { get; set; }
        public string DocId { get; set; }
        public List<DocumentTreeNodelApiModel> Childrens { get; set; }
    }
}
