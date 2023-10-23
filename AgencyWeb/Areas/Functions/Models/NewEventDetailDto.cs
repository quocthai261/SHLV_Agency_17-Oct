namespace AgencyWeb.Areas.Functions.Models
{
    public class NewEventDetailDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
