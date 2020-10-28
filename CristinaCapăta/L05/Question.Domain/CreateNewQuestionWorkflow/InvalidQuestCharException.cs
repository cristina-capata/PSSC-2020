using System;
using System.Collections.Generic;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestCharException : Exception
    {
        public InvalidQuestCharException()
        {
        }

        public InvalidQuestCharException(string question) : base($"Questions must have less then 1000 characters.")
        {
        }

    }
}