using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public static class GameInit
    {
        private static QuestionList _questionList;

        public static QuestionList GetQuestionList()
        {
            GameInit.Init();
            return GameInit._questionList;
        }

        private static void Init()
        {
            List<Response> responses1 = new List<Response>();
            responses1.Add(new Response("Aller chercher un café en salle de pause", 0));
            responses1.Add(new Response("Essayer de rentrer en cours sans que mon professeur me voit", 0));
            responses1.Add(new Response("Aller demander à mon professeur s'il m'accepte", 1));
            responses1.Add(new Response("Aller chercher un mot de retard à l'administration", 3));
            Question question1 = new Question(
                "Il est 8h10 ... Que voulez-vous faire ?",
                responses1
            );

            List<Response> responses2 = new List<Response>();
            responses2.Add(new Response("Mon chien a été trop lent", 0));
            responses2.Add(new Response("Panne de réveil", 0));
            responses2.Add(new Response("Je suis désolé, il y avait des embouteillages", 2));
            responses2.Add(new Response("Je ne suis pas en retard, sur mon téléphone il est 8h00 !", 0));
            Question question2 = new Question(
                "Bonjour, quel est le motif de votre retard ?",
                responses2
            );
            
            List<Question> list = new List<Question>();
            list.Add(question1);
            list.Add(question2);
            _questionList = new QuestionList(list);
            

        }
        
    }
    
}