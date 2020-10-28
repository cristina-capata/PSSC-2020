using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Question.Domain.CreateNewQuestionWorkflow.CreateNewQuestResult;
using static Question.Domain.CreateNewQuestionWorkflow.QuestDescription;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    public class VoteQuestService
    {
        public Task SendPermissionToVote(PublishedQuestion question)
        {
            return Task.CompletedTask;
        }
    }
}
