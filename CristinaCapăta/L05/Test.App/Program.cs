using Question.Domain.CreateNewQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Net;
using LanguageExt;
using static Question.Domain.CreateNewQuestionWorkflow.CreateNewQuestResult;
using static Question.Domain.CreateNewQuestionWorkflow.QuestDescription;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var questionResult = UnpublishedQuestion.Create("Can a programmer live without errors?", new List<string>() {"errors","programming"});


            questionResult.Match(
                    Succ: question =>
                    {
                        VoteQuestion(question);
                        Console.WriteLine("This question can be voted! *happy dance*");
                        return Unit.Default;
                    },
                    Fail: ex =>
                    {
                        Console.WriteLine($"The question couldn't be published because {ex.Message}");
                        return Unit.Default;
                    }
                );
            Console.ReadLine();
        }
        private static void VoteQuestion(UnpublishedQuestion question)
        {
            var publishedQuestionResult = new PublishQuestService().PublishQuestion(question);
            publishedQuestionResult.Match(
                    QuestionVote=>
                    {
                        new VoteQuestService().SendPermissionToVote(QuestionVote);
                        return Unit.Default;
                    },
                    ex =>
                    {
                        Console.WriteLine("This question can't be voted! C'ést la vie!");
                        return Unit.Default;
                    }
                );
        }

    }
}
