namespace Cah.Models.Extensions
{
    public static class QuestionCardExtensions
    {
        public static bool IsValid(this QuestionCard questionCard)
        {
            return questionCard.Text != "";
        }
    }
}
