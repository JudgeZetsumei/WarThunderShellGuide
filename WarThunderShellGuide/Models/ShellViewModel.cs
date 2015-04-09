using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarThunderShellGuide.Models
{
    public class ShellViewModel
    {
        public int shellId { get; set; }
        public string name { get; set; }    // Shell name
        public string type { get; set; }    // Shell type (AP, APCR, HE etc.)
        public double weight { get; set; }  // Kilograms kg
        public double calibre { get; set; } // Milimetres mm

        public int range10m { get; set; }   // 
        public int range100m { get; set; }  //
        public int range500m { get; set; }  // Penetration of shell at stated range
        public int range1000m { get; set; } //
        public int range1500m { get; set; } //
        public int range2000m { get; set; } //



        // SHELL VIEW MODEL (NAME, WEIGHT, RANGE)
        // TANK VIEW MODEL (NAME)
        // SINGLE TANK, TANK HAS IT'S SHELLS
        // HARD CODE STATS

        // Pz.Kpfw. III Ausf. M
        //
        // 50mm KwK39 Cannon
        //
        // PzGr 39 APC 2KG
        //      10m: 92mm
        //      100m: 87mm
        //      500: 75mm
        //      1000m: 65mm
        //      1500m: 48mm
        //      2000m: 38mm
        //
        // PzGr 40/1 APCR 1.1KG
        //      10m: 128mm
        //      100m: 115mm
        //      500: 75mm
        //      1000m: 45mm
        //      1500m: 24mm
        //      2000m: 15mm
        //
        // PzGr 40 APCR 0.9KG
        //      10m: 145mm
        //      100m: 130mm
        //      500: 70mm
        //      1000m: 30mm
        //      1500m: 17mm
        //      2000m: 10mm
        //
        // Sprgr. 38 HE 1.8KG
        //      10m: 7mm
        //      100m: 7mm
        //      500: 7mm
        //      1000m: 7mm
        //      1500m: 7mm
        //      2000m: 7mm
        //
        //
        //
        // T-34 1942
        //
        // 76.2mm F-34 Cannon
        //
        // BR-350A APHEBC 6.3KG
        //      10m: 86mm
        //      100m: 83mm
        //      500: 74mm
        //      1000m: 67mm
        //      1500m: 57mm
        //      2000m: 38mm
        //
        // BR-350B APHEBC 6.3KG
        //      10m: 90mm
        //      100m: 87mm
        //      500: 79mm
        //      1000m: 73mm
        //      1500m: 66mm
        //      2000m: 45mm
        //
        // BR-350SP APBC 6.8KG
        //      10m: 92mm
        //      100m: 88mm
        //      500: 77mm
        //      1000m: 73mm
        //      1500m: 64mm
        //      2000m: 55mm
        //
        // BR-350P APCR 3KG
        //      10m: 116mm
        //      100m: 113mm
        //      500: 102mm
        //      1000m: 92mm
        //      1500m: 78mm
        //      2000m: 60mm
        //
        // BP-350A HEAT 5.3KG
        //      10m: 80mm
        //      100m: 80mm
        //      500: 80mm
        //      1000m: 80mm
        //      1500m: 80mm
        //      2000m: 80mm
        //
        // QF-350M HE 6.2KG
        //      10m: 15mm
        //      100m: 15mm
        //      500: 15mm
        //      1000m: 15mm
        //      1500m: 15mm
        //      2000m: 15mm
    }
}