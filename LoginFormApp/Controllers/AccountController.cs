using LoginFormApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginFormApp.Controllers
{
    public class AccountController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // Por convención es mejor usar el nombre del controlador como nombre del método?
        // (ForgotPassword en vez de Index)?
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(model.Email);
        //        if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
        //        {
        //            // No revelar que el usuario no existe o no está confirmado
        //            return View("ForgotPasswordConfirmation");
        //        }

        //        // Para obtener más información sobre cómo habilitar la confirmación de cuentas y restablecimiento de contraseñas, 
        //        // visita https://go.microsoft.com/fwlink/?LinkID=532713
        //        var code = await _userManager.GeneratePasswordResetTokenAsync(user);
        //        var callbackUrl = Url.ResetPasswordCallbackLink(user.Id, code, Request.Scheme);
        //        await _emailSender.SendEmailAsync(model.Email, "Restablecer contraseña",
        //           $"Por favor restablece tu contraseña haciendo clic aquí: <a href='{callbackUrl}'>link</a>");
        //        return View("ForgotPasswordConfirmation");
        //    }

        //    // Si llegamos hasta aquí, algo falló, volver a mostrar el formulario
        //    return View(model);
        //}

    }
}
