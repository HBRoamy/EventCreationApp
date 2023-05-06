using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.Core.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using Book_reading_app.AppDomain.Interfaces;
using Book_reading_app.AppDomain.Services;
using Book_reading_app.AppDomain.AbstractFactories;
using Book_reading_app.Core.Logger;

namespace Book_reading_app.Core.Web.Controllers
{

    public class BookEventController : Controller
    {

        //private readonly IUserCredsService _userService; ----> replaced by a Decorator

       // private readonly IRepository_UoW UoW;   ----> replaced by Facade

        private readonly IUserCredsService decorated_userService;
        private readonly IFacade _facade;
        private readonly ICustomLogger customLogger;

        public BookEventController(IFacadeFactory facadeFactory,IUserCredsService userService)
        {
            _facade = facadeFactory.getFacade();
            decorated_userService = new UserInfoService_Decorated(userService); // -----> using a decorator instead of the userService itself
            customLogger = CustomLogger.GetInstance();
        }

        public IActionResult Index(bool IsSuccess = false)
        {

            //var currentUser = _userService.GetCurrentUserEmail();
            var currentUser = decorated_userService.GetCurrentUserEmail();
            ViewBag.IsSuccess = IsSuccess;
            customLogger.LogToConsole("Inside Index action of Book Event Controller");
            if (currentUser == "myadmin@bookevents.com")
            {
                //var allEvents = _eventRepo.GetAllEvents();
                //var allEvents = UoW.bookRepo.GetAllEvents();
                var allEvents = _facade.bookRepo.GetAllEvents();
                return View(allEvents);
            }
            //var publicEvents = _eventRepo.GetAllPublicEvents();
            //var publicEvents = UoW.bookRepo.GetAllPublicEvents();
            var publicEvents = _facade.bookRepo.GetAllPublicEvents();
            return View(publicEvents);
        }

        [Route("Customer-Support", Name = "getSupport")]
        public IActionResult CustomerSupport()
        {
            customLogger.LogToConsole("Clicked Customer-Support link");
            return Redirect("https://www.nagarro.com/en");
        }

        [Authorize]
        public IActionResult MyEvents(string email)
        {
            //var events = _eventRepo.GetEventsByUser(email);
            //var events = UoW.bookRepo.GetEventsByUser(email);
            var events = _facade.bookRepo.GetEventsByUser(email);
            if (events != null)
            {
                customLogger.LogToConsole("Accessing \"My Events\" action");
                return View(events);
            }
            else
            {
                customLogger.LogToConsole("Couldn't find any events");
                return View("EventNotFound");
            }
        }

        [Authorize]
        public IActionResult CreateEvent(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }


        [AllowAnonymous]
        public async Task<IActionResult> EventDetails(int id)
        {
            bool stat = false;

            //var foundEvent = await _eventRepo.GetEventWithId(id);
            //var foundEvent = await UoW.bookRepo.GetEventWithId(id);
            var foundEvent = await _facade.bookRepo.GetEventWithId(id);
            //var newuser = _userService.GetCurrentUserEmail(); //gets current user // returns null if anonymous user
            var newuser = decorated_userService.GetCurrentUserEmail(); //gets current user // returns null if anonymous user

            customLogger.LogToConsole("Accessing \"Event Details\" action");

            if (foundEvent != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventDTO, BookEventModel>());
                var mapper = config.CreateMapper();
                var foundEventModel = mapper.Map<BookEventDTO, BookEventModel>(foundEvent);

                //var _comments = await _commentsRepo.GetCommentsWithEventId(foundEventModel.Id);
                //var _comments = await UoW.commentRepo.GetCommentsWithEventId(foundEventModel.Id);
                var _comments = await _facade.commentRepo.GetCommentsWithEventId(foundEventModel.Id);

                if (_comments != null)
                {

                    foundEventModel.Comments = _comments;

                }
                if (foundEventModel.IsPrivateEvent == true)
                {
                    bool IsInvitedUser = false;

                    if (newuser != null) // if user isnt anonymous
                    {
                        if (foundEventModel.InviteByEmail != null)
                        {

                            if (foundEventModel.InviteByEmail.ToLower().Contains(newuser.ToLower()))
                            {
                                IsInvitedUser = true;
                            }
                        }
                        //private events details can only be seen if the user is creater/admin/ invited to the event
                        if (foundEventModel.OrganisersEmail.ToLower() == newuser.ToLower() || newuser.ToLower() == "myadmin@bookevents.com" || IsInvitedUser)
                            return View(foundEventModel);
                        else
                        {
                            return View("UnAuthorized");
                        }

                    }
                    else//if user is anonymous and trying to access the private event details via a link.
                    {
                        return View("UnAuthorized");
                    }
                }

                //below is for public events
                ViewBag.IsEventInPast = stat;

                return View(foundEventModel);

            }
            else
                return View("EventNotFound");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateEvent(BookEventModel model)
        {
            if (model != null)
            {
                if (ModelState.IsValid)
                {
                    
                    //var newuser = _userService.GetCurrentUserEmail(); //gets the event creater's email
                    var newuser = decorated_userService.GetCurrentUserEmail(); //gets the event creater's email

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventModel, BookEventDTO>());
                    var mapper = config.CreateMapper();

                    var newEventDto = mapper.Map<BookEventModel, BookEventDTO>(model);
                    newEventDto.OrganisersEmail = newuser;

                    //var eventId = await _eventRepo.CreateEvent(newEventDto);
                    //var eventId = await UoW.bookRepo.CreateEvent(newEventDto);
                    var eventId = await _facade.bookRepo.CreateEvent(newEventDto);
                    //await UoW.SaveAsync();
                    await _facade.SaveUsingFacadeAsync();
                    customLogger.LogToConsole("Created a new event with Title : " + model.Title);
                    ViewBag.IsSuccess = true;
                    return RedirectToAction(nameof(EventDetails), new { id = eventId });
                }
            }
            customLogger.LogToConsole("Couldn't create a new event");
            ModelState.AddModelError("", "Mandatory Fields can't be empty.");
            ViewData["IsSuccess"] = false;
            return View();

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteEvent(int Id)
        {

            //var status = await _eventRepo.DeleteEventById(Id);
            //var status = await UoW.bookRepo.DeleteEventById(Id);
            var status = await _facade.bookRepo.DeleteEventById(Id);
            //await UoW.SaveAsync();
            await _facade.SaveUsingFacadeAsync();

            if (status == Id)
            {
                customLogger.LogToConsole("Deleted an Event");
                return RedirectToAction("Index", "BookEvent", new { IsSuccess = true });
            }
            customLogger.LogToConsole("Couldn't find the event to delete");
            return View("EventNotFound");

        }

        [Authorize]
        public async Task<IActionResult> EditEvent(int Id)
        {
            //var modelDTO = await _eventRepo.GetEventWithId(Id);
            //var modelDTO = await UoW.bookRepo.GetEventWithId(Id);
            var modelDTO = await _facade.bookRepo.GetEventWithId(Id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventDTO, BookEventModel>());
            var mapper = config.CreateMapper();

            var model = mapper.Map<BookEventDTO, BookEventModel>(modelDTO);
            customLogger.LogToConsole("Trying to edit an event");
            if (model != null)
            {

                return View(model); // to get the previous details auto-filled in the edit form
            }
            customLogger.LogToConsole("Couldn't find the event to be edited");
            return View("CreateEvent");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditEvent(BookEventModel model, int modelId)
        {

            if (model != null && ModelState.IsValid)
            {

                var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventModel, BookEventDTO>());
                var mapper = config.CreateMapper();
                var newEventDto = mapper.Map<BookEventModel, BookEventDTO>(model);


                //var editedEventId = await _eventRepo.EditEvent(newEventDto, modelId);
                //var editedEventId = await UoW.bookRepo.EditEvent(newEventDto, modelId);
                var editedEventId = await _facade.bookRepo.EditEvent(newEventDto, modelId);
               //await UoW.SaveAsync();
               await _facade.SaveUsingFacadeAsync();
                customLogger.LogToConsole("Edited an event successfully.");
                return RedirectToAction("EventDetails", new { Id = editedEventId });
            }
            bool stat = true;
            ViewBag.IsEventInPast = stat;
            customLogger.LogToConsole("Event was in past so couldn't be edited");
            return RedirectToAction("EventDetails", new { Id = modelId });


        }


        public IActionResult EventsInvitedTo(string email)
        {
            customLogger.LogToConsole("Going to the invitation list.");
            var invitation = true;
            //var status = _eventRepo.EventsInvitedTo(email);
            //var status = UoW.bookRepo.EventsInvitedTo(email);
            var status = _facade.bookRepo.EventsInvitedTo(email);
            if (status != null)
            {
                ViewBag.AreInvited = invitation;
                return View(status);
            }
            else
            {
                invitation = false;
                ViewBag.AreInvited = invitation;
                return View();
            }
        }
        public IActionResult UnAuthorized()
        {
            return View();
        }
    }
}
