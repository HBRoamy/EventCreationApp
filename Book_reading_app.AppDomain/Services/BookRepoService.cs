using AutoMapper;
using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.AppDomain.Repository;
using Book_reading_app.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.Services
{
    public class BookRepoService : IBookRepo
    {
        
        private readonly Repository_DAc<BookEventEntity> main_Repo;
        private readonly BookReadingAppDomainContext _context;

        public BookRepoService(BookReadingAppDomainContext context) 
        {
            main_Repo= new Repository_DAc<BookEventEntity>(context);
            _context = context;
        }

        public async Task<int> CreateEvent(BookEventDTO model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventDTO, BookEventEntity>());
            var mapper = config.CreateMapper();
            var eventEntity = mapper.Map<BookEventDTO, BookEventEntity>(model);
            var entity = await main_Repo.CreateAsync(eventEntity);
            return entity.Id;
        }

        public async Task<int> EditEvent(BookEventDTO editedEvent, int Id)
        {
            var model = await main_Repo.GetByIdAsync(Id);
            if (model != null)
            {
                model.Title = editedEvent.Title;
                model.Date = editedEvent.Date;
                model.Location = editedEvent.Location;
                model.StartTime = editedEvent.StartTime;
                model.IsPrivateEvent = editedEvent.IsPrivateEvent;
                model.DurationInHours = editedEvent.DurationInHours;
                model.Description = editedEvent.Description;
                model.OtherDetails = editedEvent.OtherDetails;
                model.InviteByEmail = editedEvent.InviteByEmail;
                await _context.SaveChangesAsync();
                return model.Id;

            }
            return -1;
        }

        public IEnumerable<BookEventEntity> EventsInvitedTo(string email)
        {
            return main_Repo.Get(e => e.InviteByEmail.ToLower().Contains(email.ToLower())).ToList();
        }

        public IEnumerable<BookEventEntity> GetAllEvents()
        {
            var eventList = main_Repo.All();
            return eventList;
        }

        public IEnumerable<BookEventEntity> GetAllPublicEvents()
        {
            var eventList = main_Repo.Get(e => e.IsPrivateEvent == false).ToList();
            return eventList;
        }

        public IEnumerable<BookEventEntity> GetEventsByUser(string email)
        {
            return main_Repo.Get(e => e.OrganisersEmail.ToLower() == email.ToLower()).OrderByDescending(e => e.Date).ToList();
        }

        public async Task<BookEventDTO> GetEventWithId(int eventId)
        {
            var model = await main_Repo.FindAsync(e => e.Id == eventId);

            if (model != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<BookEventEntity, BookEventDTO>());
                var mapper = config.CreateMapper();

                var eventDto = mapper.Map<BookEventEntity, BookEventDTO>(model);
                return eventDto;
            }
            return null;
        }

        public async Task<int> DeleteEventById(int id)
        {
            var toBeRemoved = await main_Repo.FindAsync(e => e.Id == id);
            if (toBeRemoved != null)
            {
                var deletedId = toBeRemoved.Id;
                main_Repo.Delete(toBeRemoved);
                return deletedId;
            }
            else
                return -1;
        }


    }
}
