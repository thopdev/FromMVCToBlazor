using FromMVCToBlazor.Shared.Models;
using FromMVCToBlazor.Shared.Services;

namespace FromMVCToBlazor.Mvc.Services
{
    public class MvcRenderService : IRenderService
    {
        public RenderModel GetRenderType()
        {
            return new RenderModel {Text = "I got rendered from the server!"};
        }
    }
}
