using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryLayer.Models;

namespace NewsApp.Models
{
    public class NewsAdd
    {
        public int NewsType { get; set; }
        public string ExipiryTime { get; set; }
        public string NewsText { get; set; }
        public string NewsTitle { get; set; }
        public int LanguageDir { get; set; }
        public string SelectedSchools { get; set; }

        public List<string> Attachments { get; set; }
        public string ProfilePicture { get; set; }

        public NewsAdd()
        {
            Attachments = new List<string>();
        }

        public void SetProfilePicture(string UrlString)
        {
            ProfilePicture = UrlString;
        }

        public void AddAttachments(string UrlString)
        {
            Attachments.Add(UrlString);
        }

        public News CreateNewsDataModel()
        {
            News news = new News();
            if(string.IsNullOrEmpty(ProfilePicture))
            {
                news.NewsImage = null;
            }
            else
            {
                news.NewsImage = ProfilePicture;
            }

            if (string.IsNullOrEmpty(ExipiryTime))
            {
                news.ExpiryDate = null;
            }
            else
            {
                news.ExpiryDate = DateTime.Parse(ExipiryTime);
            }

            news.NewsType = (NewsType)NewsType;
            news.NewsLanguage = (NewsLanguage)LanguageDir;
            news.NewsText = NewsText;
            news.NewsTitle = NewsTitle;

            if(SelectedSchools != null)
            {
                List<int> selectedSchooldIds = SelectedSchools.Split(',').Select(int.Parse).ToList();
                foreach (int eachSchholId in selectedSchooldIds)
                {
                    news.Schools.Add(new School()
                    {
                        SchoolId = eachSchholId
                    });
                }

            }


            foreach (string  attachments in Attachments)
            {
                news.NewsAttachment.Add(new NewsAttachment()
                {
                    AttachmentUrl = attachments
                });
            }

            return news;
        }
    }
}
