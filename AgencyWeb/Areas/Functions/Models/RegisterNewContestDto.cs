namespace AgencyWeb.Areas.Functions.Models
{
    public class RegisterNewContestDto
    {
        public long ContestId { get; set; }

        public string ContestName { get; set; }

        public string ContestCode { get; set; }

        public int ExpireAfter { get; set; }

        public DateTime CreatedDay { get; set; }

        public string ImageUrl { get; set; }
    }
}
