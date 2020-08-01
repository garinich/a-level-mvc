using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Models;
using DataAccess;
using DataAccessLayer.Models;

namespace BusinessLayer
{
    public class AnimalsManager
    {
        private readonly AnimalsRepo _animalsRepo;
        private readonly Mapper _mapper;

        public AnimalsManager()
        {
            _animalsRepo = new AnimalsRepo();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalModel>();
                cfg.CreateMap<AnimalModel, Animal>();
                cfg.CreateMap<Home, HomeModel>();
                cfg.CreateMap<HomeModel, Home>();
            });

            _mapper = new Mapper(conf);
        }

        public IList<AnimalModel> GetAllAnimals()
        {
            return _mapper.Map<IList<AnimalModel>>(_animalsRepo.GetAllAnimals());
        }
    }
}
