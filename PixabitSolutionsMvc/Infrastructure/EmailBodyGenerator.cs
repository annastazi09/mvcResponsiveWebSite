using PixabitSolutionsMvc.Models;

namespace PixabitSolutionsMvc.Infrastructure
{
    public class EmailBodyGenerator
    {
        private readonly string _userName;
        private readonly string _emailTo;
        private readonly string _userMessage;

        public EmailBodyGenerator(FeedbackForm model)
        {
            _userName = model.Name;
            _emailTo = model.Email;
            _userMessage = model.Message;

        }
      public string GenerateEmailBody()
        {
            var emailContent = EmailTemplateManager.GetEmailTemplateContent();

            var result = emailContent
               .Replace(EmailVariableHelper.GetFormattedVar(EmailVariableHelper.Name), _userName)
               .Replace(EmailVariableHelper.GetFormattedVar(EmailVariableHelper.Email), _emailTo)
               .Replace(EmailVariableHelper.GetFormattedVar(EmailVariableHelper.Message), _userMessage);

          return result;

        }
    }
}