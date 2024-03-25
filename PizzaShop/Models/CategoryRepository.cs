namespace PizzaShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }

        private List<Category> categories = new List<Category>();

        public Category GetCategoryByID(int id)
        {
            foreach (var category in categories)
            {
                if (category.GetCategoryId() == id)
                    return category;
            }
            return null;
        }

        public CategoryRepository()
        {
            categories.Add(new Category(1, "Pice sa mesom", ""));
            categories.Add(new Category(2, "Veganske pice", ""));
            categories.Add(new Category(3, "Pice bez glutena", ""));
        }

    }
}
