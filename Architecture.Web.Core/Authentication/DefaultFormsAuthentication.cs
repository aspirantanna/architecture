using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Architecture.Web.Core.Authentication
{
    public class DefaultFormsAuthentication : IFormsAuthentication
    {
        public void Signout()
        {
            FormsAuthentication.SignOut();
        }

        public void SetAuthCookie(string userName, bool persistent)
        {
            FormsAuthentication.SetAuthCookie(userName, persistent);
        }

        public void SetAuthCookie(System.Web.HttpContextBase httpContext, System.Web.Security.FormsAuthenticationTicket authenticationTicket)
        {
            var encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);
            httpContext.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) { Expires = CalculateCookieExpirationDate() });
        }

        public void SetAuthCookie(System.Web.HttpContext httpContext, System.Web.Security.FormsAuthenticationTicket authenticationTicket)
        {
            var encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);
            httpContext.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) { Expires = CalculateCookieExpirationDate() });
        }

        public System.Web.Security.FormsAuthenticationTicket Decrypt(string encryptedTicket)
        {
            return FormsAuthentication.Decrypt(encryptedTicket);
        }
        private static DateTime CalculateCookieExpirationDate()
        {
            return DateTime.Now.AddHours(1);
        }
    }
}
