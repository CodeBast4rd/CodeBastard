using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Show.Outline {
    public class PresentData : PageModel {

        public readonly IEnumerable<string> _keyPointList;

        public PresentData () {
            this._keyPointList = new List<string> () {
                "Klassen und Modelle in Razer Files möglich",
                "Voller funktionsumfang von c#",
                "Keine IDE unterstützung",
                "Fehler erst zur Laufzeit"
            };
        }

    }
}