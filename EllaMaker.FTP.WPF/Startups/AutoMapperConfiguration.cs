using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace EllaMaker.FTP.Startups
{
    public class AutoMapperConfiguration
    {
        public static void AutoMapperInit()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                cfg.CreateMap<Api.Response.DocumentV1ApiModel, Model.DocumentsModel>();
                cfg.CreateMap<Api.Response.EmployeeAndDeptNodelApiModel, Model.PsAndDeptTreeNodeItem>();
            });
            MapperUtil.Config(config.CreateMapper());
        }
    }
}
