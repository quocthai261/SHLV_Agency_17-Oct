namespace AgencyWeb.Areas.Functions.Models
{
    public class IncompleteContestDto
    {
        public long ContestId { get; set; }

        public string ContestName { get; set; }

        public string ContestCode { get; set; }

        public DateTime EndDate { get; set; }

        public string ImageUrl { get; set; }
    }
}
