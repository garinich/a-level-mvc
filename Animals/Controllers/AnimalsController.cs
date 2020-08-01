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
                cfg.CreateMap<AnimalModel, ElementViewModel>();
                cfg.CreateMap<HomeModel, ElementViewModel>();

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
            var animalsMap = _mapper.Map<IList<ElementViewModel>>(animals);
            var result = new AllElementsViewModel {Elements = animalsMap};
            return View(result);
        }

        // GET
        public ActionResult Homes()
        {
            var homes = _homesManager.GetAllHomes();
            var homesMap = _mapper.Map<IList<ElementViewModel>>(homes);
            var result = new AllElementsViewModel {Elements = homesMap};
            return View(result);
        }

        public ActionResult Partial()
        {
            return PartialView();
        }
    }
}
