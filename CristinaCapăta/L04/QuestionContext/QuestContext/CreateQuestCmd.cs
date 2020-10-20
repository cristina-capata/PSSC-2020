using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionContext.QuestContext
{
    public struct CreateQuestCmd
    {
        [Required]
        public string Titlu {get; private set;}
        public string Descriere {get; private set;}
        public string Tag{get; private set;}

        public CreateQuestCmd(string Titlu, string Descriere, string Tag)
        {
            this.Titlu=Titlu;
            this.Descriere=Descriere;
            this.Tag=Tag;
        }
    }
}
