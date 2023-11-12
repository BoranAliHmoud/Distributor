using AutoMapper;
using IDCoreTest.Models;

namespace IDCoreTest
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<TblCustomer,HtblCustomer> (); 
        }
    }
}
