﻿using Newtonsoft.Json;

namespace LibraryManagementSystem.Entities
{
    public class IssueEntity
    {
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "uid", NullValueHandling = NullValueHandling.Ignore)]
        public string UId { get; set; }
        [JsonProperty(PropertyName = "dType", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentType { get; set; }

        [JsonProperty(PropertyName = "version", NullValueHandling = NullValueHandling.Ignore)]
        public int Version { get; set; }

        [JsonProperty(PropertyName = "updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        [JsonProperty(PropertyName = "updatedOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedOn { get; set; }

        [JsonProperty(PropertyName = "createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        [JsonProperty(PropertyName = "createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedOn { get; set; }

        [JsonProperty(PropertyName = "active", NullValueHandling = NullValueHandling.Ignore)]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool Archived { get; set; }
        [JsonProperty(PropertyName = "bookId", NullValueHandling = NullValueHandling.Ignore)]
        public string BookId { get; set; }
        [JsonProperty(PropertyName = "mmemberId", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }
        [JsonProperty(PropertyName = "issueDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime IssueDate { get; set; }
        [JsonProperty(PropertyName = "returnDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime ReturnDate { get; set; }
        [JsonProperty(PropertyName = "isReturned", NullValueHandling = NullValueHandling.Ignore)]
        public bool isReturned { get; set; }

        public IssueEntity() { }

       
    }
}
