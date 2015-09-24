namespace Cah.Models.Extensions
{
    public static class AnswerCardExtensions
    {
        public static bool IsValid(this AnswerCard answerCard)
        {
            return answerCard.Text != "";
        }
    }
}
