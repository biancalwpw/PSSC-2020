using System;
using System.Collections.Generic;
using System.Text;
using StackUnderflow.Domain.Core.Contexts.Questions.CheckLanguage;
using StackUnderflow.Domain.Schema.Backoffice.CreateTenantOp;
using StackUnderflow.EF.Models;

namespace StackUnderflow.Domain.Core.Contexts.Questions.CreateReply
{
   public /*static*/ partial class CreateReplyResult
    {
        public interface ICreateReplyResult { Microsoft.AspNetCore.Mvc.IActionResult Match(Func<CheckLanguageResult.TextChecked, Microsoft.AspNetCore.Mvc.IActionResult> p1, Func<CheckLanguageResult.TextCheckedFailed, Microsoft.AspNetCore.Mvc.BadRequestObjectResult> p2, Func<CreateTenantResult.InvalidRequest, Microsoft.AspNetCore.Mvc.ActionResult> p3); };
        public class ReplyCreated : ICreateReplyResult
        {
            public Post Post { get; }

            public ReplyCreated(Post post)
            {
                Post = post;
            }
        }
        public class ReplyNotCreated : ICreateReplyResult
        {
            public string Reason { get; }

            public ReplyNotCreated(string reason)
            {
                Reason = reason;
            }
        }
        public class InvalidRequest : ICreateReplyResult
        {
            public CreateReplyCmd Cmd { get; }

            public InvalidRequest(CreateReplyCmd cmd)
            {
                Cmd = cmd;
            }
        }
    }
}
