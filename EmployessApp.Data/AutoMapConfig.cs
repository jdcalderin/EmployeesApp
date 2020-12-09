using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Data
{
    public class AutoMapConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<Model.Employee, EmployessApp.Entities.Employee>();
                c.CreateMap<EmployessApp.Entities.Employee, Model.Employee>();
            });
        }

        public static void TearDown()
        {
            AutoMapper.Mapper.Reset();
        }
    }
}
