namespace PixabitSolutionsMvc.Infrastructure
{
    internal class EmailVariableHelper
    {
        public static string Name = "Name";
        public static string Email = "Email";
        public static string Message = "Message";

        public static string GetFormattedVar(string varName)
        {
            return string.Format("{{{{{0}}}}}", varName);
        }
    }
}