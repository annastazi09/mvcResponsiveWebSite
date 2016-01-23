using System.IO;
using System.Web;

namespace PixabitSolutionsMvc.Infrastructure
{
    public static class EmailTemplateManager
    {
        private const string Path = "~/Templates/EmailTemplate.html";
        public static string GetEmailTemplateContent()
        {
            string templatePath = HttpContext.Current.Server.MapPath(Path);
            return File.ReadAllText(templatePath);
        }
    }
}