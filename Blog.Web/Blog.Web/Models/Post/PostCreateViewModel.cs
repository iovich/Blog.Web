﻿using Blog.Web.Models.Category;
using Blog.Web.Models.Tag;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models.Post
{
    public class PostCreateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; } = false;
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        public IEnumerable<int> Tags { get; set; }
    }
}
