using IntelligenceCloud.Helpers;
using IntelligenceCloud.Models;
using IntelligenceCloud.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntelligenceCloud.Infrastructure
{
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        public string AuthorizationFailView { get; set; }
        private bool accessible;
        private FeatureService featSrv = new FeatureService();

        //請求授權時執行
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            accessible = false;
            //獲得url請求裡的controller和action
            string ctrlName = filterContext.RouteData.Values["controller"].ToString();
            string actName = filterContext.RouteData.Values["action"].ToString();
            if(IdentityHelper.UserId != null)
            {
                int userId = (int)IdentityHelper.UserId;
                accessible = featSrv.Accessible(userId, ctrlName, actName);
            }
            


            base.OnAuthorization(filterContext);//進入AuthorizeCore
        }

        //自定義授權檢查 (return false 則禁止存取頁面)
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            
            //return base.AuthorizeCore(httpContext);
            //return true; // 測試用
            return accessible;
            
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            /**/
            //Feature feature = featSrv.GetFeats(IdentityHelper.UserId).FirstOrDefault();
            var  feat = featSrv.GetFeats(IdentityHelper.UserId).FirstOrDefault();

            if (feat != null)
            {
                
                //導到別頁
                filterContext.HttpContext.Response.RedirectToRoute(new { controller = feat.ControllerName, action = feat.ActionName });
            }
            else
            {
                //用URL
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary {
                        { "action","Logout"},
                        { "controller","Home"}
                });
            }
            

            //filterContext.Result = new ViewResult { ViewName = AuthorizationFailView };
        }
    }
}