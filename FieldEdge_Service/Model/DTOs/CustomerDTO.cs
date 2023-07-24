﻿namespace Model.DTOs
{
    public class CustomerRequest
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string gender { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string country_code { get; set; }
        public string phone_number { get; set; }
    }
}
