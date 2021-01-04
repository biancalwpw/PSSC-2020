using StackUnderflow.Domain.Schema.Backoffice.CreateTenantOp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StackUnderflow.Domain.Core.Contexts.Questions.CreateQuestion
{
    public static partial class CreateQuestionResult
    {
        public interface ICreateQuestionResult
        {
            Task MatchAsync(Func<CreateTenantResult.TenantCreated, Task<CreateTenantResult.TenantCreated>> p1, Func<CreateTenantResult.TenantNotCreated, Task<CreateTenantResult.TenantNotCreated>> p2);
            void Match(Func<CreateTenantResult.TenantCreated, CreateTenantResult.TenantCreated> p1, Func<CreateTenantResult.TenantNotCreated, CreateTenantResult.TenantNotCreated> p2);
        }
        public class QuestionPosted: ICreateQuestionResult
        {
            

            public Guid QuestionId { get;  }
            public string Title { get; }

           public string Body { get; }

            public string Tags { get; }
            public QuestionPosted(Guid questionId, string title, string body, string tags)
            {
                QuestionId = questionId;
                Title = title;
                Body = body;
                Tags = tags;
            }

        }

        public class QuestionNotCreated : ICreateQuestionResult
        {
            public string Reason { get; }

            public QuestionNotCreated(string reason)
            {
                Reason = reason;
            }
        }
        public class QuestionValidFailed : ICreateQuestionResult
        {
            public string Message { get; }

            public QuestionValidFailed(string message)
            {
                Message = message;
            }
        }
    }
}
