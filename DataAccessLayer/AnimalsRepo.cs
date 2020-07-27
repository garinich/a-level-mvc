using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccess
{
    public class AnimalsRepo
    {
        public IList<Animal> GetAllAnimals()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Animals
                    .Include(animal => animal.Home)
                    .ToList();
            }
        }

        public IList<Home> GetAllHomes()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Homes
                    .Include(animal => animal.Animals)
                    .ToList();
            }
        }

        /*public Book GetBookById(int id)
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Books
                    .Include(book => book.Writers)
                    .Include(book => book.Category)
                    .First(book => book.Id == id);
            }
        }

        public void SaveBook(Book book)
        {
            using (var ctx = new AnimalsContext())
            {
                book.Category = ctx.Categories.First(category => category.Id == book.Category.Id);
                book.Writers = book.Writers.Select(bookWriter => ctx.Writers.First(writer => writer.Id == bookWriter.Id)).ToList(); ;
                ctx.Books.Add(book);
                
                ctx.SaveChanges();
            }
        }

        public void UpdateBook(Book book)
        {
            using (var ctx = new AnimalsContext())
            {
                var existingBook = ctx.Books
                    .Include(c => c.Category)
                    .Include(w=> w.Writers).FirstOrDefault(b => b.Id == book.Id);

                if (existingBook == null)
                {
                    ctx.Books.Add(book);
                }

                else
                {
                    existingBook.Name = book.Name;
                    existingBook.Category = ctx.Categories.FirstOrDefault(c => c.Id == book.Category.Id);
                    existingBook.Writers = new List<Writer>();

                    foreach (var writer in book.Writers)
                    {
                        var selectedWriter = ctx.Writers.FirstOrDefault(w => w.Id == writer.Id);
                        if (selectedWriter != null && existingBook.Writers.All(w => w.Id != selectedWriter.Id))
                        { 
                            existingBook.Writers.Add(selectedWriter);
                        }
                    };

                    ctx.Books.Attach(existingBook);
                    ctx.Entry(existingBook).State = EntityState.Modified;
                }

                ctx.SaveChanges();
            }
        }

        public void RemoveBookById(int id)
        {
            using (var ctx = new AnimalsContext())
            {
                ctx.Books.Remove(ctx.Books.First(book => book.Id == id));
                ctx.SaveChanges();
            }
        }

        public IList<Category> GetAllCategories()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Categories
                    .Include(category => category.Books)
                    .ToList();
            }
        }

        public Category GetCategoryById(int id)
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Categories
                    .Include(category => category.Books)
                    .First(category => category.Id == id);
            }
        }

        public IList<Writer> GetAllWriters()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Writers
                    .Include(category => category.Books)
                    .ToList();
            }
        }

        public Writer GetWriterById(int id)
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Writers
                    .Include(writer => writer.Books)
                    .First(writer => writer.Id == id);
            }
        }*/
    }
}
