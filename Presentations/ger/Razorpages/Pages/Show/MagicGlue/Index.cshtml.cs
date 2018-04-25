using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Show.MagicGlue {
  public class GlueBrand : PageModel {

    [BindProperty]
    public string BrandName { get; set; }

    public IEnumerable<string> BrandNameExampelList { get; set; }

    public GlueBrand() {
      this.BrandNameExampelList = new List<string>() {
        "Magic Glue",
        "Silver Glue",
        "Sticky Stick",
        "Unicorn Clench"
      };
    }

    public async Task OnGetAsync(string name) {
      this.BrandName = name;
    }
  }
}