namespace AgencyWeb.Areas.Functions.Models
{
    public class ContractRecordDto
    {
        public long ContractRecordId { get; set; }
        public string Proposal { get; set; }
        public string Policy { get; set; }
        public string MainProduct { get; set; }
        public string PolicyOwner { get; set; }
        public string AddressCustomer { get; set; }
        public string LifeAssured { get; set; }
        public double RegularPremium { get; set; }
        public double TemporaryCollection { get; set; }
        public string StatusProposal { get; set; }
        public string InformationMore { get; set; }
        public DateTime DateAdditionalDocument { get; set; }
        public string DownloadAttachment { get; set; }
        public DateTime DateAdditionalContract { get; set; }
        public DateTime ReleaseDateContract { get; set; }
        public string Status { get; set; }
        public DateTime DateNBUTransferCS { get; set; }
        public DateTime DateCSReceiveContract { get; set; }
        public DateTime DateTVTCReceiveContract { get; set; }
        public DateTime DateSignContract { get; set; }
        public DateTime DateTVTCSendMailCS { get; set; }
        public DateTime EndDateFee { get; set; }
        public DateTime ExpiresDate { get; set; }
        public string TVTCName { get; set; }
        public string TVTCOtherName { get; set; }
        public string OfficeName { get; set; }


        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
