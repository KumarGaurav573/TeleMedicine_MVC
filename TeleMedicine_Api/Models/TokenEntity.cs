using System;

namespace TeleMedicine_Api.Models
{
    public class TokenEntity
    {
        public string UserId { get; set; }
        public Guid TokenId { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}