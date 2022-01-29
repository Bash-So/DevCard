namespace DevCard_MVC.Models
{
    public class Article
    {
        public long iD { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long iD, string title, string description, string image)
        {
            this.iD = iD;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}