namespace PizzaShop.Models
{
    public class Category
    {
        private int CategoryID;
        private string CategoryName;
        private string Description;

        public Category(int categoryID, string categoryName, string description)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
        }

        public Category() { }

        public int GetCategoryId() { return CategoryID; }
        public string GetCategoryName() { return CategoryName; }
        public string GetDescription() { return Description; }
        public void SetCategoryID(int categoryID) { CategoryID = categoryID; }
        public void SetCategoryName(string categoryName) { CategoryName = categoryName; }
        public void SetDescription(string description) { Description = description; }


    }
}
