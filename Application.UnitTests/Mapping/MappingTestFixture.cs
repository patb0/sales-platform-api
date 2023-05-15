using AutoMapper;
using SalesPlatform.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Mapping
{
    public class MappingTestFixture
    {
        public IConfigurationProvider ConfigurationProvider { get; private set; }
        public IMapper Mapper { get; private set; }

        public MappingTestFixture()
        {
            ConfigurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = ConfigurationProvider.CreateMapper();
        }
    }
}
