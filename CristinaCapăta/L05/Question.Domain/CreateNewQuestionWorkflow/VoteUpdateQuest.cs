using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Question.Domain.CreateNewQuestionWorkflow.CreateNewQuestResult;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    class VoteUpdateQuest
    {
        public QuestionPosted VoteUpdate(QuestionPosted question, VoteCount vote)
        {
            var allvotes = question.AllVotes;
            allvotes.Append(vote);
            return new QuestionPosted(question.QuestionId, question.Question, allvotes.Sum(v => Convert.ToInt32(v)), allvotes);
        }
    }
}
