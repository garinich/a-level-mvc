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

        /*public BookDTO GetBookById(int id)
        {
            return _mapper.Map<BookDTO>(_bookStoreRepo.GetBookById(id));
        }

        public void AddBook(BookDTO bookDTO)
        {
            bookDTO.WriterIds.ForEach(bookWriterId =>
            {
                bookDTO.Writers.Add( new WriterDTO {Id= bookWriterId});
            });
            bookDTO.Category.Id = bookDTO.CategoryId;

            _bookStoreRepo.SaveBook(_mapper.Map<Book>(bookDTO));
        }

        public void UpdateBook(BookDTO bookDTO)
        {
            bookDTO.Category.Id = bookDTO.CategoryId;

            bookDTO.WriterIds.ForEach(bookWriterId =>
            {
                bookDTO.Writers.Add(new WriterDTO { Id = bookWriterId });
            });

            _bookStoreRepo.UpdateBook(_mapper.Map<Book>(bookDTO));
        }

        public void RemoveBookById(int id)
        {
            _bookStoreRepo.RemoveBookById(id);
        }

        public IList<CategoryDTO> GetAllCategories()
        {
            return _mapper.Map<IList<CategoryDTO>>(_bookStoreRepo.GetAllCategories());
        }

        public CategoryDTO GetCategoryById(int id)
        {
            return _mapper.Map<CategoryDTO>(_bookStoreRepo.GetCategoryById(id));
        }

        public IList<WriterDTO> GetAllWriters()
        {
            return _mapper.Map<IList<WriterDTO>>(_bookStoreRepo.GetAllWriters());
        }

        public WriterDTO GetWriterById(int id)
        {
            return _mapper.Map<WriterDTO>(_bookStoreRepo.GetWriterById(id));
        }*/
    }
}
