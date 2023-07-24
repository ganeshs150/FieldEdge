namespace Model.DTOs
{
    public class CustomerViewModel
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string gender { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string country_code { get; set; }
        public double balance { get; set; } = 0;
        public string phone_number { get; set; }
    }
}
