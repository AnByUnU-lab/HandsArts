using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsArts.ViewModels
{
    public class RubroOptionsVM
    {
        public List<SelectListItem> Rubro { get; set; }
        public List<SelectListItem> ModoEnvioPreferido { get; set; }
    }
}
