using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public static class Repository
    {
        private static List<UserReviews> comments = new List<UserReviews>();

        public static IEnumerable<UserReviews> Comments
        {
            get
            {
                return comments;
            }
        }

        public static void AddComment(UserReviews comment)
        {
            comments.Add(comment);
        }
    }
}
