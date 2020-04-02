using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Web;
using System.Web.Mvc;
using TutorialAchilles_Core.Models;
using TutorialAchilles_Core.ViewModels;

namespace TutorialAchilles_Core.Infra
{
    public class ParametrosPaginacaoModelBinder : IModelBinder
    {
        public object BindModel(Contexto controllerContext, ModelBindingContext modelBindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;
            ParametrosPaginacao parametrosPaginacao = new ParametrosPaginacao(request.Form);
            return parametrosPaginacao;
        }
    }
}