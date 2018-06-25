using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebProject.Authorization
{
    public class RequestServiceAuthorization : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string _authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string _decodeAuthorization = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(_authenticationToken));
                string[] _credenticalsArray = _decodeAuthorization.Split(':');
                string _userName = _credenticalsArray[0];
                string _password = _credenticalsArray[1];

                if (SecurityLogic.Login(_userName, _password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(_userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }

            }
        }
    }
}