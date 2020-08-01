using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Models;
using DataAccess;
using DataAccessLayer.Models;

namespace BusinessLayer
{
    public class HomesManager
    {
        private readonly AnimalsRepo _animalsRepo;
        private readonly Mapper _mapper;

        public HomesManager()
        {
            _animalsRepo = new AnimalsRepo();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Home, HomeModel>();
                cfg.CreateMap<HomeModel, Home>();
                cfg.CreateMap<Animal, AnimalModel>();
                cfg.CreateMap<AnimalModel, Animal>();
            });

            _mapper = new Mapper(conf);
        }

        public IList<HomeModel> GetAllHomes()
        {
            return _mapper.Map<IList<HomeModel>>(_animalsRepo.GetAllHomes());
        }
    }
}
