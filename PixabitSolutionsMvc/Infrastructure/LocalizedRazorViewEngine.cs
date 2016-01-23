using System.Threading;
using System.Web.Mvc;


namespace PixabitSolutionsMvc.Infrastructure
{
    public class LocalizedRazorViewEngine : RazorViewEngine
    {
        public LocalizedRazorViewEngine()
        {
            DefaultLanguageCode = "en";
        }

        public string DefaultLanguageCode { get; set; }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var controllerName = (string)controllerContext.RouteData.Values["controller"];
            var language = GetLanguage(controllerName, viewName);
            if (language != "") language = "." + language;

            var masterPath = string.Format("~/Views/Shared/_Layout{0}.cshtml", language);
            var uri = string.Format("~/Views/{0}/{1}{2}.cshtml", controllerName, viewName, language);

            if (!VirtualPathProvider.FileExists(masterPath))
            {
                masterPath = "~/Views/Shared/_Layout.cshtml";
            }

            if (VirtualPathProvider.FileExists(uri))
                return new ViewEngineResult(CreateView(controllerContext, uri, masterPath), this);

            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var language = GetLanguageForPartial(partialViewName);
            if (language != null) language = "." + language;

            var uri = string.Format("~/Views/Shared/{0}{1}.cshtml", partialViewName, language);

            if (VirtualPathProvider.FileExists(uri))
                return new ViewEngineResult(CreatePartialView(controllerContext, uri), this);

            return base.FindPartialView(controllerContext, partialViewName, useCache);
        }

        private string GetLanguage(string controllerName, string actionName)
        {
            const string viewPathFormat = "~/Views/{0}/{1}.{2}.cshtml";

            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, controllerName, actionName, Thread.CurrentThread.CurrentCulture.Name)))
                return Thread.CurrentThread.CurrentCulture.Name;
            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, controllerName, actionName, Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)))
                return Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, controllerName, actionName, DefaultLanguageCode)))
                return DefaultLanguageCode;

            return string.Empty;
        }

        private string GetLanguageForPartial(string partialName)
        {
            const string viewPathFormat = "~/Views/Shared/{0}.{1}.cshtml";

            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, partialName, Thread.CurrentThread.CurrentCulture.Name)))
                return Thread.CurrentThread.CurrentCulture.Name;
            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, partialName, Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)))
                return Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            if (VirtualPathProvider.FileExists(string.Format(viewPathFormat, partialName, DefaultLanguageCode)))
                return DefaultLanguageCode;

            return string.Empty;

        }
    }
}