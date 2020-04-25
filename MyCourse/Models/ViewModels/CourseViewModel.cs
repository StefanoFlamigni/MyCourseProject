namespace MyCourse.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Id {get; set;}

        public string Title {get; set;}

        public string ImagePath {get; set;}

        public string Author {get; set;}

        public double Rating {get; set;}

        public decimal FullPrice {get; set;}

        public decimal CurrentPrice {get; set;}

    }
}