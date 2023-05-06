using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.IRepositories
{
    public interface ICommentRepo
    {
        public Task<ICollection<CommentEntity>> GetCommentsWithEventId(int id);
        public Task<int> PostCommentOnEvent(CommentDTO newCommentDto);
    }
}
