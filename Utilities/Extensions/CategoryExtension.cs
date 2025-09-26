namespace DeltaSchool.Utilities.Extensions
{
    public static class CategoryExtension
    {
        public static string GetLabel(this Category category)
        {
            switch (category)
            {
                case Category.PASS:
                    return "Classe de passage";
                case Category.EXAM:
                    return "Classe d'examen";
                default:
                    return category.ToString();
            }
        }
    }

    public enum Category
    {
        PASS,
        EXAM,
    }


    public class CategoryItem
    {
        public Category Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }
}
