using System;
using System.Web.Mvc;
using PixabitSolutionsMvc.Infrastructure;
using PixabitSolutionsMvc.Models;
using PixabitSolutionsMvc.Resources;
using System.Drawing;
using System.IO;
using  System.Drawing.Drawing2D;
using  System.Drawing.Text;

namespace PixabitSolutionsMvc.Controllers
{
 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SwitchLanguage(string lang, string returnUrl)
        {
           LanguageCultureHelper.SetLanguageCultureCookie(lang);
           return Redirect(string.IsNullOrEmpty(returnUrl) ? "~/" : returnUrl);//save current Url for translation
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    
        [HttpGet]
        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";
            var temp = new FeedbackForm();
            return View(temp);
        }

        [HttpPost]
        public ActionResult Contact(FeedbackForm model)
        {
            var rez = new EmailBodyGenerator(model);
            var text = rez.GenerateEmailBody();
            var tempForm = new FeedbackForm();

            if (Session["Captcha"].ToString() != model.Captcha )
            {
                ModelState.AddModelError("Captcha", Translations.CaptchaValidation);
                return View();
            }

            try
            {
                EmailSender.SendEmail(AppSettings.FromEmailAddress, AppSettings.ToEmailAddress, Translations.Contact_Form_Message_Field, text);
                ViewBag.SendContactSuccess = Translations.SubmitSuccess;
                ModelState.Clear();
            }

            catch (Exception)
            {
                ViewBag.SmtpError = Translations.SmtpError;

            }

            if (Session["Captcha"] == null)
            {
                return RedirectToAction("Contact", "Home");
            }
       
            return View(tempForm);  
        }

        [HttpGet]
        public ActionResult CaptchaImage(string prefix, bool noisy = true)
        {

            var rand = new Random((int) DateTime.Now.Ticks);
            //generate new question
            var a = rand.Next(10, 99);
            var b = rand.Next(0, 9);
            var captcha = string.Format("{0} + {1} = ?", a, b);

            //store answer
            Session["Captcha" + prefix] = a + b;

            //image stream
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            using (var bmp = new Bitmap(130, 30))
            using (var gfx = Graphics.FromImage((Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));

       
                //add noise
                if (noisy)
                {
                    int i;
                    var pen = new Pen(Color.Yellow);
                    for (i = 1; i < 10; i++)
                    {
                        pen.Color = Color.FromArgb(
                            (rand.Next(0, 255)),
                            (rand.Next(0, 255)),
                            (rand.Next(0, 255)));

                        var r = rand.Next(0, (130 / 3));
                        var x = rand.Next(0, 130);
                        var y = rand.Next(0, 30);

                        gfx.DrawEllipse(pen, x - r, y - r, r, r);
                    }
                }

                //add question
                gfx.DrawString(captcha, new Font("Tahoma",15), Brushes.DimGray, 2, 3);

                //render as Jpeg
                bmp.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");

            }

            return img;
        }

        public ActionResult Impressum()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
     
    }
}
