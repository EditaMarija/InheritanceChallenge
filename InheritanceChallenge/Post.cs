﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Post
    {
        private static int currentPostID { get; set; }

        protected int ID { get; set; }
        protected string? Title { get; set; }
        protected string? SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Marija";

        }

        public Post(string title,bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;

        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic =isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID, this.Title, this.SendByUsername);
        }
    }
}