using SpringBootApp.Models;
using SpringBootApp.Repositories;
using System.Collections.Generic;

namespace SpringBootApp.Services
{
    public class SpringBootAppService
    {
        SpringBootAppRepository SpringBootAppRepository;

        public SpringBootAppService(SpringBootAppRepository springBootAppRepository)
        {
            SpringBootAppRepository = springBootAppRepository;
        }

        public List<LicencePlate> GetLicencePlateListForUser(string inputPlate)
        {
            return SpringBootAppRepository.GetPlateList(inputPlate);
        }

        public List<LicencePlate> GetBrandListForUser(string brand)
        {
            return SpringBootAppRepository.GetBrandList(brand);
        }

        public List<LicencePlate> GetPoliceCarsForUser()
        {
            return SpringBootAppRepository.GetPoliceCars();
        }

        public List<LicencePlate> GetDiplomatCarsForUser()
        {
            return SpringBootAppRepository.GetDiplomatCars();
        }
    }
}