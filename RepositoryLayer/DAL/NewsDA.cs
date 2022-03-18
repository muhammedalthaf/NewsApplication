using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.DAL
{
    public class NewsDA
    {
        private readonly NewsContext context;
        public NewsDA(NewsContext db_context)
        {
            context = db_context;
        }

        public List<School> GetAllSchool()
        {
            return context.Schools.ToList();
        }

        public List<News> GetAllNews(int thresholdValue = -7)
        {
            //ICollection<News> news;
            //if(IsRequiredManyMappings)
            //     news = context.News.Include(e => e.Schools).Include(x => x.NewsAttachment).ToList(); 
            //else
            //    news= context.News.ToList();
            ICollection<News> news;
            DateTime lastProcessedTime = DateTime.Now.AddDays(thresholdValue);
            if(thresholdValue == 0)
            {
                news = context.News.Where(c => c.ExpiryDate == null || c.ExpiryDate > DateTime.Now).ToList();
            }
            else
            {
                news = context.News.Where(c => c.CreatedDate > lastProcessedTime && (c.ExpiryDate == null || c.ExpiryDate > DateTime.Now)).ToList();
            }
         
            return news.ToList();
        }

        public News GetByNewsId(int NewsId)
        {
            News news =  context.News.Include(e => e.Schools).Include(x => x.NewsAttachment).FirstOrDefault(o=>o.NewsId == NewsId);
            return news;
        }

        public string Save(News news)
        {
            try
            {
                ICollection<School> ExistingSchools = news.Schools.ToList();
                news.Schools.Clear();
                context.Add(news);
                context.SaveChanges();
                foreach (School school in ExistingSchools)
                {
                    School existing = context.Schools.FirstOrDefault(s => s.SchoolId == school.SchoolId);
                    news.Schools.Add(existing);
                }
                context.SaveChanges();
                return "Success";
            }
            catch(Exception e)
            {
                return "Failed";
            }

        }
    }
}
