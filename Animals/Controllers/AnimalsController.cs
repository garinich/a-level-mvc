using System.Collections.Generic;
using System.Web.Mvc;
using Animals.Models;
using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;

namespace Animals.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalsManager _animalsManager;
        private readonly HomesManager _homesManager;
        private readonly Mapper _mapper;

        public AnimalsController()
        {
            _animalsManager = new AnimalsManager();
            _homesManager = new HomesManager();

            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();

                cfg.CreateMap<AnimalViewModel, AnimalModel>();
                cfg.CreateMap<HomeViewModel, HomeModel>();
            });

            _mapper = new Mapper(conf);
        }

        // GET
        public ActionResult Index()
        {
            var animals = _animalsManager.GetAllAnimals();
            var animalsMap = _mapper.Map<IList<AnimalViewModel>>(animals);
            var result = new GetAllAnimalViewModel {Animals = animalsMap};
            return View(result);
        }

        // GET
        public ActionResult Homes()
        {
            var homes = _homesManager.GetAllHomes();
            var homesMap = _mapper.Map<IList<HomeViewModel>>(homes);
            var result = new GetAllHomeViewModel {Homes = homesMap};
            return View(result);
        }
    }
}
