using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string? SocialMediaTitle { get; }
        public string? SocialMediaIcon { get; }
        public string? SocialMediaUrl { get; }
    }
}
