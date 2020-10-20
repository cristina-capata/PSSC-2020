using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Choices;

namespace QuestionContext.QuestContext
{
    [AsChoice]
    public static partial class CreateQuestResult
    {
        public interface ICreateQuestResult { }

        public class QuestCreated: ICreateQuestResult
        {
           public string Titlu {get; private set;}
            public string Descriere {get; private set;}
            public string Tag {get; private set;}

            public QuestCreated(string Titlu, string Descriere, string Tag)
            {
                this.Titlu=Titlu;
                this.Descriere=Descriere;
                this.Tag=Tag;
            }
        }

        public class QuestNotCreated: ICreateQuestResult
        {
            public IEnumerable<string> ValidationError {get; private set;}
            public QuestionValidationFailed(IEnumerable<string> error)
            {
                ValidationError=error.AsEnumerable();
            }
        }

    }
}
