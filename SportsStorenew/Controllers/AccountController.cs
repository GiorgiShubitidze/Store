using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportsStorenew.Models;
using SportsStoreNew.Areas.Identity.Pages.Account;
using SportsStoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SportsStorenew.Controllers
{
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
       
        [Route("google-login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
        {
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction(nameof(LoginModel));

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            //if (signInResult.IsLockedOut)
            //{
            //    return RedirectToAction(nameof(ForgotPassword));
            //}
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["Provider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return View("ExternalLoginModel1", new ExternalLoginModel1 { Email = email });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginModel1 model, string returnUrl = null)
        {
            //if (!ModelState.IsValid)
            //    return View(model);

            var info = await signInManager.GetExternalLoginInfoAsync();
            //if (info == null)
            //    return View(nameof(Error));

            var user = await userManager.FindByEmailAsync(model.Email);
            IdentityResult result;

            if (user != null)
            {
                result = await userManager.AddLoginAsync(user, info);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return Redirect(returnUrl);
                }
            }
            else
            {
                //model.Principal = info.Principal;
                // user = _mapper.Map<User>(model);
                IdentityUser user1 = new IdentityUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value
                };

                result = await userManager.CreateAsync(user1);
                if (result.Succeeded)
                {
                    result = await userManager.AddLoginAsync(user1, info);
                    if (result.Succeeded)
                    {
                        //TODO: Send an emal for the email confirmation and add a default role as in the Register action
                        await signInManager.SignInAsync(user1, isPersistent: false);
                        return Redirect(returnUrl);
                    }
                }
            }

            foreach (var error in result.Errors)
            {
                ModelState.TryAddModelError(error.Code, error.Description);
            }

            return View(nameof(ExternalLogin), model);
        }
      
    }
}
