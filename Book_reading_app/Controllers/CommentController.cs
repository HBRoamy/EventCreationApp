using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.Core.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Book_reading_app.Core.Web.Controllers
{
    public class CommentController : Controller
    {
        //private readonly CommentsRepo repo;
        private readonly IRepository_UoW UoW;
        private readonly IUserCredsService _currentUser;

        public CommentController(IRepository_UoW UoW, IUserCredsService currentUser)
        {
            //this.repo = repo;
            this.UoW = UoW;
            _currentUser = currentUser;
        }

        public IActionResult Index()
        {
            return View();
        }

       

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostCommentOnEvent(CommentModel newComment, int eventId)
        {
            if (newComment != null)
            {
                var addedCommentDTO = new CommentDTO()
                {
                    Comment = newComment.Comment,
                    EventId = eventId,
                    TimeStamp = DateTime.Now,
                    PostingUserEmail = _currentUser.GetCurrentUserEmail()
                };
                
                //var receivedEventId = await repo.PostCommentOnEvent(addedCommentDTO);

                var receivedEventId = await UoW.commentRepo.PostCommentOnEvent(addedCommentDTO);
                await UoW.SaveAsync();


                return RedirectToAction("EventDetails", "BookEvent", new { id = receivedEventId });
            }
            else 
                return RedirectToAction("EventDetails", "BookEvent", new { id = eventId });
        }
    }
}
