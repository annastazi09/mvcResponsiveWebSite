using System;
using System.Collections.Generic;
using System.Web;
using PixabitSolutionsMvc.Models;


namespace PixabitSolutionsMvc.Infrastructure
{
    public static class LanguageCultureHelper
    {
        public static string LanguageCulture { get; set; }

        public static IEnumerable<LanguageCultureViewModel> GetLanguageCultures()
        {  
            
            yield return new LanguageCultureViewModel("de-DE", "Deutsch (DE)");
            yield return new LanguageCultureViewModel("en-GB", "English (GB)");
            yield return new LanguageCultureViewModel("ru-RU", "Russian (RU)");
          
        }

        public static void SetLanguageCultureCookie(string languageCulture)
        {
            HttpContext.Current.Response.Cookies.Set(new HttpCookie(WebConstants.CookieNameLanguageCulture, languageCulture) { Path = VirtualPathUtility.ToAbsolute("~/"), Expires = DateTime.Now.AddYears(1) });
        }

        public static string GetCurrentLanguageCulture()
        {
             
            var cookie = HttpContext.Current.Request.Cookies[WebConstants.CookieNameLanguageCulture];
            if (cookie == null)
            {
                var language = LanguageCulture ?? AppSettings.Language;
                SetLanguageCultureCookie(language);
                return language;
            }

            return cookie.Value;
        }
    }
}