using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;

namespace AppMAUIGallery.Repo
{
    internal class CategoryRepo
    {
        public CategoryRepo() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Name = "Layout",
                    Components = new List<Component>
                {
                    new Component
                    {
                        Title = "StackLayout", 
                        Description = "Loren blabalbla.", 
                        Page = typeof(StackLayoutPage) 
                    }
                }
                }
            };
            return categories; 
        }
    }
}
