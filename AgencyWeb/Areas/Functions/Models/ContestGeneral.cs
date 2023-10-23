namespace AgencyWeb.Areas.Functions.Models
{
    public class ContestGeneral
    {
        public IEnumerable<RegisterNewContestDto> RegisterNewContest { get; set; }

        public IEnumerable<HappeningContestDto> HappeningContest { get; set; }

        public IEnumerable<FinishedContestDto> FinishedContest { get; set; }

        public IEnumerable<IncompleteContestDto> IncompleteContest { get; set; }
    }
}
