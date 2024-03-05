namespace PizzaShop.Models
{
    public class CategoryRepository: IcategoryRepository
    {
        public CategoryRepository() { }
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

    }
}
