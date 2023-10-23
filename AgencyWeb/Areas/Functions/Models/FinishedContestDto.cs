namespace AgencyWeb.Areas.Functions.Models
{
    public class FinishedContestDto
    {
        public long ContestId { get; set; }

        public string ContestName { get; set; }

        public string ContestCode { get; set; }

        public int ExpireAfter { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Status { get; set; }

        public string ImageUrl { get; set; }
    }
}
