namespace userReg.Models.DTO;
    public class ApplicantDto
    {
        public int AppId { get; set; }
        public DateTime AppDate { get; set; }
        public string AppName { get; set; }
        public string AppPosition { get; set; }
        public DateTime AppDob { get; set; }
        public int AppAge { get; set; }
        public string AppGender { get; set; }
        public string AppMobile { get; set; }
        public string AppEmail { get; set; }
        public string AppReason { get; set; }
        public decimal? AppNoYears { get; set; }
        public string AppCurrentEmployer { get; set; }
    }