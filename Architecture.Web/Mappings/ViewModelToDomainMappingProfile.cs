using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture.Web.Mappings
{
    class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }
        protected override void Configure()
        {
            base.Configure();
        }
    }
}
