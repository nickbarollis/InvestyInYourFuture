namespace InvestyInYourFuture.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CreatorId { get; set; }
        public Category? CategoryType { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal AmountGathered { get; set; }
        public decimal TargetAmount { get; set; }
        public string? ImagePath { get; set; }



        public enum Category
        {
            ARTS,
            TECHNOLOGY,
            SCIENCE,
            FOOD,
            MUSIC,
            SOCIAL,
        }

        

    }
}
