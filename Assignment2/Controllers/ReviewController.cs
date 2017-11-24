using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class ReviewController : ApiController
    {
        // GET: api/Reviews
        public IEnumerable<Review> Get()
        {
            return ReviewList.GetReviews();
        }

        // GET: api/Reviews/5
        public Review Get(int id)
        {
            return ReviewList.GetReview(id);
        }

        // POST: api/Reviews
        public Review Post([FromBody] Review newReview)
        {
            Review addedReview = ReviewList.AddReview(newReview);
            return addedReview;
        }

        // PUT: api/Reviews/5
        public Review Put(int id, [FromBody] Review newReview)
        {
            Review updatedReview = ReviewList.UpdateReview(id, newReview);
            return updatedReview;
        }

        // DELETE: api/Reviews/5
        public void Delete(int id)
        {
            ReviewList.DeleteReview(id);
        }
    }
}
