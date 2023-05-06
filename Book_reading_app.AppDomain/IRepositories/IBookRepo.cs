using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.IRepositories
{
    public interface IBookRepo
    {
        public Task<int> CreateEvent(BookEventDTO model);

        public Task<int> EditEvent(BookEventDTO editedEvent, int Id);

        public Task<BookEventDTO> GetEventWithId(int eventId);
        public IEnumerable<BookEventEntity> GetEventsByUser(string email);
        public IEnumerable<BookEventEntity> GetAllEvents();
        public IEnumerable<BookEventEntity> GetAllPublicEvents();
        public IEnumerable<BookEventEntity> EventsInvitedTo(string email);
        public Task<int> DeleteEventById(int id);
    }
}
