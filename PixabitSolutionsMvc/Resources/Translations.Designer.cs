﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PixabitSolutionsMvc.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Translations {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Translations() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PixabitSolutionsMvc.Resources.Translations", typeof(Translations).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Captcha field is empty.
        /// </summary>
        public static string CaptchaEmptyField {
            get {
                return ResourceManager.GetString("CaptchaEmptyField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How much is the sum?.
        /// </summary>
        public static string CaptchaLabel {
            get {
                return ResourceManager.GetString("CaptchaLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field must be between {1} and {2}.
        /// </summary>
        public static string CaptchaRange {
            get {
                return ResourceManager.GetString("CaptchaRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong value, please try again .
        /// </summary>
        public static string CaptchaValidation {
            get {
                return ResourceManager.GetString("CaptchaValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notification from E-mail.
        /// </summary>
        public static string Contact_Form_Message_Field {
            get {
                return ResourceManager.GetString("Contact_Form_Message_Field", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail field is required.
        /// </summary>
        public static string EmailLabel {
            get {
                return ResourceManager.GetString("EmailLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid email address.
        /// </summary>
        public static string EmailValidation {
            get {
                return ResourceManager.GetString("EmailValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message field is required.
        /// </summary>
        public static string MessageLabel {
            get {
                return ResourceManager.GetString("MessageLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name field is required.
        /// </summary>
        public static string NameLabel {
            get {
                return ResourceManager.GetString("NameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Smtp server error sending email.
        /// </summary>
        public static string SmtpError {
            get {
                return ResourceManager.GetString("SmtpError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum string length {1} symbols.
        /// </summary>
        public static string StringLengthMaximum {
            get {
                return ResourceManager.GetString("StringLengthMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit Successful!.
        /// </summary>
        public static string SubmitSuccess {
            get {
                return ResourceManager.GetString("SubmitSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please correct the following errors before submitting the message.
        /// </summary>
        public static string ValidationSummary {
            get {
                return ResourceManager.GetString("ValidationSummary", resourceCulture);
            }
        }
    }
}
