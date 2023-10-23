namespace AgencyWeb.Areas.Functions.Models
{
    public class CustomerBirthdayDto
    {
        public long CustomerBirthdayId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Agent { get; set; }

    }
}
