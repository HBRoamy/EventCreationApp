using AutoMapper;
using Book_reading_app.AppDomain.Data.DB_Context;
using Book_reading_app.AppDomain.Data_transfer_objects;
using Book_reading_app.AppDomain.IRepositories;
using Book_reading_app.AppDomain.Repository;
using Book_reading_app.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_reading_app.AppDomain.Services
{
    public class CommentRepoService: ICommentRepo
    {
        Repository_DAc<CommentEntity> main_Repo;

        public CommentRepoService(BookReadingAppDomainContext context)
        {
            main_Repo = new Repository_DAc<CommentEntity>(context);
        }

        public async Task<ICollection<CommentEntity>> GetCommentsWithEventId(int id)
        {
            var relevantComments = await main_Repo.Get(c => c.EventId == id).OrderBy(c => c.TimeStamp).ToListAsync();

            return relevantComments;
        }

        public async Task<int> PostCommentOnEvent(CommentDTO newCommentDto)
        {
            //var newComment = new CommentEntity()
            //{
            //    Comment = newCommentDto.Comment,
            //    EventId = newCommentDto.EventId,
            //    TimeStamp = newCommentDto.TimeStamp,
            //    PostingUserEmail = newCommentDto.PostingUserEmail
            //};
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentDTO, CommentEntity>());
            var mapper = config.CreateMapper();

            var newComment = mapper.Map<CommentDTO, CommentEntity>(newCommentDto);
            await main_Repo.CreateAsync(newComment);
            return newComment.EventId;
        }
    }
}
