using System.Linq;

namespace Cah.Models.Extensions
{
    public static class CardSetExtensions
    {
        public static bool IsValid(this CardSet cardSet)
        {
            if (cardSet.Name == "") return false;
            return cardSet.AnswerCards.All(answerCard => answerCard.IsValid() == true)
                && cardSet.QuestionCards.All(questionCard => questionCard.IsValid() == true);
        }
    }
}
