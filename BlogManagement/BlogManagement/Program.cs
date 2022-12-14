using System;
using System.Collections.Generic;

namespace BlogManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tags = { "firsttag" };

            List<Blog> blogs = new List<Blog>()
            {
                new Blog("Salam","FirstBlog",BlogStatus.Approved, tags),
                 new Blog("Salam1", "secondblog", BlogStatus.Rejected, tags)
            };


            Console.WriteLine(BlogStatus.Approved.GetAze());

        }
    }

    class Blog
    {
        public string Tittle { get; set; }
        public string Content { get; set; }
        public BlogStatus Status { get; set; }
        public string[] Tags { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        public Blog(string tittle, string content, BlogStatus status, params string[] tags)
        {
            Tittle = tittle;
            Content = content;
            Tags = tags;
            Status = status;

        }


    }
    enum BlogStatus
    {
        Sent,
        Approved,
        Rejected
    }


    static class BlogStatusExtension
    {
        public static string GetAze(this BlogStatus status)
        {
            switch (status)
            {
                case BlogStatus.Sent:
                    return "gonderildi";

                   
                case BlogStatus.Approved:

                    return "qebul edildi";
                    
                case BlogStatus.Rejected:
                    return "Legv Edildi";
                    
                default:
                    return "sehvdir";
                   
            }
        }


    }

}
