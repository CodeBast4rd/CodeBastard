using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Show.Outline {
    public class PresentData : PageModel {

        public readonly IEnumerable<string> _keyPointList;

        public PresentData () {
            this._keyPointList = new List<string> () {
                "Trennung der View und des Models",
                "Gesamtes C# Toolset",
                "Erhöhte Lesbarkeit",
                "Leichtere Fehleranalyse vor der Ausführungs"
            };
        }

    }
}