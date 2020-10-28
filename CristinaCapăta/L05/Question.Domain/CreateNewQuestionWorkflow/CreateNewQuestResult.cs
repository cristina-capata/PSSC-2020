using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Choices;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    [AsChoice]
    public static partial class CreateNewQuestResult
    {
        public interface ICreateNewQuestionResult
        {
            
        }

        public class QuestionPosted: ICreateNewQuestionResult
        {
            public Guid QuestionId { get; private set; }
            public string Question { get; private set; }
            public int VoteCount { get; private set; }
            public IReadOnlyCollection<VoteCount> AllVotes { get; private set; }

            public QuestionPosted(Guid questionId, string question,int voteCount, IReadOnlyCollection<VoteCount> allVotes)
            {
                QuestionId = questionId;
                Question = question;
                VoteCount = voteCount;
                AllVotes = allVotes;
            }
        }

        public class QuestionNotPosted : ICreateNewQuestionResult
        {
            public string Reason { get; set; }

            public QuestionNotPosted(string reason)
            {
                Reason = reason;
            }
        }
    
        public class QuestionValidationFailed: ICreateNewQuestionResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}
