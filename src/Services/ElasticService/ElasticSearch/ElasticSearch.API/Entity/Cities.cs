﻿namespace ElasticSearch.API.Entity
{
    public class Cities
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
    }
}
