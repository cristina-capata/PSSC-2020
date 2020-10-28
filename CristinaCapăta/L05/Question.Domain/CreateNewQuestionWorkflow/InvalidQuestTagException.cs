using System;
using System.Collections.Generic;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestTagException: Exception
    {
        public InvalidQuestTagException()
        {
        }

        public InvalidQuestTagException(List<string> tag) : base($"Questions must have at least one tag and maximum 3 tags!")
        {
        }

    }
}