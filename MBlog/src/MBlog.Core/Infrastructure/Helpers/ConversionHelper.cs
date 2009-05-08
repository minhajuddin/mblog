﻿using MBlog.Data.Domain;

namespace MBlog.Data.DataAccess {

    public static class ConversionHelper {
        public static Post ToDomainPost(this Entity.Post p) {
            return new Post
            {
                ID = p.PostID,
                Title = p.Title,
                Content = p.Content,
                Author = p.Author,
                Timestamp = p.Timestamp
            };
        }

        public static Entity.Post ToEntityPost(this Post p) {
            return new Entity.Post
            {
                PostID = p.ID,
                Title = p.Title,
                Content = p.Content,
                Author = p.Author,
                Timestamp = p.Timestamp
            };
        }
    }

}