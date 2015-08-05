using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture.Web.Mappings
{
    class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
        protected override void Configure()
        {
            base.Configure();
        }
    }
}
