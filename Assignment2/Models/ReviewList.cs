using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class ReviewList
    {

        private static List<Review> reviewList = new List<Review>()
        {
            new Review{ReviewID = 1, SongId = 1, Message = "Good Song", Rating = 5},
            new Review{ReviewID = 2, SongId = 4, Message = "Amazing", Rating = 5},
            new Review{ReviewID = 3, SongId = 6, Message = "It's Okay", Rating = 3}
        };


        public static Review AddReview(Review newReview)
        {
            newReview.ReviewID = reviewList.Max(s => s.ReviewID) + 1;
            reviewList.Add(newReview);
            return newReview;
        }

        public static List<Review> GetReviews()
        {
            return reviewList;
        }

        public static Review GetReview(int ReviewId)
        {
            int ReviewIndex = reviewList.FindIndex(r => r.ReviewID == ReviewId);
            return (ReviewIndex == -1) ? null : reviewList[ReviewIndex];
        }

        public static Review UpdateReview(int ReviewId, Review newReview)
        {
            int reviewIndex = reviewList.FindIndex(r => r.ReviewID == ReviewId);
            if (reviewIndex != -1)
            {
                reviewList[reviewIndex] = newReview;
                return reviewList[reviewIndex];
            }
            return null;

        }

        public static bool DeleteReview(int ReviewId)
        {
            int ReviewIndex = reviewList.FindIndex(r => r.ReviewID == ReviewId);
            if (ReviewIndex != -1)
            {
                reviewList.RemoveAt(ReviewIndex);
                return true;
            }
            return false;
        }
    }
}