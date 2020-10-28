using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateNewQuestionWorkflow.QuestDescription;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    public class PublishQuestService
    {
        public Result<PublishedQuestion> PublishQuestion(UnpublishedQuestion question)
        {
            return new PublishedQuestion(question.Question,question.Tag);
        }
    }
}
