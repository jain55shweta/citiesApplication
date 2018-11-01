using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }


        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                 new CityDto()
                 {
                     Id = 1,
                     Name = "new york" ,
                     Description="Big Park",
                     PointsOfInterest=new List<PointOfInterestDto>()
                     {
                        new PointOfInterestDto()
                        {
                              Id = 1,
                              Name = "Central Park" 
                             
                        },
                        new PointOfInterestDto()
                        {
                              Id = 2,
                              Name = "Empire State Building" 
                            
                        }
                     }
                 },
                new CityDto()
                 {
                     Id = 2,
                     Name = "India" ,
                     Description="Developing Country ",
                     PointsOfInterest=new List<PointOfInterestDto>()
                     {
                        new PointOfInterestDto()
                        {
                              Id = 1,
                              Name = "Taj Mahal"
                        },
                        new PointOfInterestDto()
                        {
                              Id = 2,
                              Name = "India Gate" 
                        }
                     }
                 }
            };
           
        }
    }
}
