using Book_reading_app.Core.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_reading_app.Core.Web.Data.MockRepo
{
    public static class MockEventRepo 
    {
        private static List<BookEventModel> myEvents = new List<BookEventModel>()
        {
            new BookEventModel(){Id = 1, Title="PublicEvent1", Date=DateTime.UtcNow, Location="India", DurationInHours=3, OtherDetails="These are other Details" },
            new BookEventModel(){Id = 2, Title="PublicEvent2", Date=DateTime.UtcNow, Location="India", DurationInHours=2},
            new BookEventModel(){Id = 3, Title="PublicEvent3", Date=DateTime.UtcNow, Location="India",Description ="This is a description", DurationInHours=4},
            new BookEventModel(){Id = 4, Title="PublicEvent4", Date=DateTime.UtcNow, Location="India",Description ="This is a description", DurationInHours=1, OtherDetails="These are other Details"},
            new BookEventModel(){Id = 5, Title="PvtEvent1", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=4, OtherDetails="These are other Details"},
            new BookEventModel(){Id = 6, Title="PvtEvent2", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=2},
            new BookEventModel(){Id = 7, Title="PvtEvent3", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=1},
            new BookEventModel(){Id = 8, Title="PvtEvent4", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=3},
            new BookEventModel(){Id = 9, Title="PublicEvent5", Date=DateTime.UtcNow, Location="India", DurationInHours=3},
            new BookEventModel(){Id = 10, Title="PvtEvent5", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=1, OtherDetails="These are other Details"},
            new BookEventModel(){Id = 11, Title="PublicEvent6", Date=DateTime.UtcNow, Location="India", DurationInHours=4},
            new BookEventModel(){Id = 12, Title="PvtEvent6", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India",Description ="This is a description", DurationInHours=2},
            new BookEventModel(){Id = 13, Title="PvtEvent7", Date=DateTime.UtcNow,IsPrivateEvent=true, Location="India", DurationInHours=4, OtherDetails="These are other Details"},
            new BookEventModel(){Id = 14, Title="PublicEvent7", Date=DateTime.UtcNow, Location="India", DurationInHours=4},
            new BookEventModel(){Id = 15, Title="PublicEvent8", Date=DateTime.UtcNow, Location="India",Description ="This is a description", DurationInHours=1},
            new BookEventModel(){Id = 16, Title="PublicEvent9", Date=DateTime.UtcNow, Location="India",Description ="This is a description", DurationInHours=1, OtherDetails="These are other Details"}


        };

        public static int CreateEvent(BookEventModel model)
        {
            
            myEvents.Add(model);

            return model.Id;
            
            
        }

        public static int DeleteEvent(int Id)
        {
            var ToRemove = myEvents.Find(e => e.Id == Id);
            if (ToRemove != null) {
                myEvents.Remove(ToRemove);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static IEnumerable<BookEventModel> GetAllPublicEvents()
        {
            throw new NotImplementedException();
        }

        public static BookEventModel GetEventById(int id)
        {
            var eventSelected = myEvents.Find(e=>e.Id==id);
            
            return eventSelected;
            
        }

        public static IEnumerable<BookEventModel> GetFuturePublicEvents()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<BookEventModel> GetPastPublicEvents()
        {
            throw new NotImplementedException();
        }

        public static void UpdateEvent(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
