using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepositoryLayer.Models
{
    public enum NewsType
    {
        Unknown, Public, Private
    }

    public enum NewsLanguage
    {
        Unknown, English, Arabic
    }

    public class News : BaseEntity
    {
        public News()
        {
            Schools = new List<School>();
            NewsAttachment = new List<NewsAttachment>();
        }
        public int NewsId { get; set; }
        [Required]
        public string NewsTitle { get; set; }
        public NewsType NewsType { get; set; }
        public string NewsText { get; set; }
        public string NewsImage { get; set; }
        public NewsLanguage NewsLanguage { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<NewsAttachment> NewsAttachment { get; set; }
    }

    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
    }

    public class NewsAttachment
    {
        public int NewsAttachmentId { get; set; }
        [Required]
        public string AttachmentUrl { get; set; }
        public News News { get; set; }

    }
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
