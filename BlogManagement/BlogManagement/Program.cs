using System;
using System.Collections.Generic;

namespace BlogManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tags = { "firsttag" };



            Blog blog = new Blog("Salam","FirstBlog",BlogStatus.Approved, tags);
            Blog blog1 = new Blog("Salam1", "secondblog", BlogStatus.Rejected, tags);
            Blog blog2 = new Blog("Salam2", "thirdblog", BlogStatus.Sent, tags);
            Blog blog3 = new Blog("Salam3", "fourthblog", BlogStatus.Approved, tags);
        }
    }

    class Blog
    {
        public string Tittle { get; set; }
        public string Content { get; set; }
        public string[] Tags { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public BlogStatus Status { get; set; }

        public Blog(string tittle,string content, BlogStatus status,params string[] tags)
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

}
