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
                responses1,
                "Rendez-vous à l'administration !"
            );

            List<Response> responses2 = new List<Response>();
            responses2.Add(new Response("Mon chien a été trop lent", 0));
            responses2.Add(new Response("Panne de réveil", 0));
            responses2.Add(new Response("Je suis désolé, il y avait des embouteillages", 2));
            responses2.Add(new Response("Je ne suis pas en retard, sur mon téléphone il est 8h00 !", 0));
            Question question2 = new Question(
                "Bonjour, quel est le motif de votre retard ?",
                responses2,
                "Rendez-vous dans à votre cours en salle A10 !"
            );
            
            List<Response> responses3 = new List<Response>();
            responses3.Add(new Response("J'essaierai de trouver une solution à la pause", 0));
            responses3.Add(new Response("Je vais demander un prêt à l'administration", 2));
            responses3.Add(new Response("Tant pis, de toute façon j'ai sommeil", 0));
            responses3.Add(new Response("Je demande à mes camarades", 3));
            Question question3 = new Question(
                "Il ne reste que des places sans prise, que voulez-vous faire ?",
                responses3,
                "Coup de chance, un camarade de classe a une multiprise pour vous !"
            );
            
            List<Question> list = new List<Question>();
            list.Add(question1);
            list.Add(question2);
            list.Add(question3);
            _questionList = new QuestionList(list);
            

        }
        
    }
    
}