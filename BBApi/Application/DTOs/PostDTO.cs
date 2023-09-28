using BBDomain.Entities;
using BBDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBApplication.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PrettyUrl { get; set; }
        public string SubTitle { get; set; }
        public string HeadLine { get; set; }
        public string Author { get; set; }
        public DateTime DocumentDate { get; set; }
        public string Teaser { get; set; }
        public string TeaserThubnail { get; set; }
        public string TeaserThumbnail { get; set; }
        public string MainText { get; set; }
        public string MetaDescription { get; set; }
        public bool UnlockedPost { get; set; }
        public bool EnableMLSSearch { get; set; }
        public PostType PostType { get; set; }
        public Page HomePage { get; set; }
        public Page CategoryLandingPage { get; set; }
        public Visibility Visibility { get; set; }
        public List<PostCategoryDTO>? PostCategory { get; set; }
    }
}
