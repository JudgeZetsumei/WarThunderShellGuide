using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarThunderShellGuide.Models;
using Newtonsoft.Json.Serialization;
using System.Text.RegularExpressions;

namespace WarThunderShellGuide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /////////////////////////////////////////////////////////////////// My code starts here /////////////////////////////////////////////////////////////////

        public ActionResult About()
        {
            // Using this as my page

            List<TankViewModel> tanks;
            tanks = buildTankStats();

            return View(tanks);
        }

        public ActionResult ShellDetails(int tankId)
        {
            List<TankViewModel> tanks = buildTankStats();
            TankViewModel tank = new TankViewModel();

            foreach (var tnk in tanks)
                if (tankId == tnk.tankId)
                    tank = tnk;




            return PartialView("ShellDetails", tank);
        }

        public List<TankViewModel> buildTankStats()
        {
            List<TankViewModel> tanks = new List<TankViewModel>();

            List<ShellViewModel> pz3Shells = new List<ShellViewModel>();
            pz3Shells.Add(new ShellViewModel()
            {
                shellId = 1,
                name = "PzGr 39",
                type = "APC",
                weight = 2,
                calibre = 50,
                range10m = 92,
                range100m = 87,
                range500m = 75,
                range1000m = 65,
                range1500m = 48,
                range2000m = 38,
            });
            pz3Shells.Add(new ShellViewModel()
            {
                shellId = 1,
                name = "PzGr 40/1",
                type = "APCR",
                weight = 1.1,
                calibre = 50,
                range10m = 128,
                range100m = 115,
                range500m = 75,
                range1000m = 45,
                range1500m = 24,
                range2000m = 15,
            });
            pz3Shells.Add(new ShellViewModel()
            {
                shellId = 1,
                name = "PzGr 40",
                type = "APCR",
                weight = 0.9,
                calibre = 50,
                range10m = 145,
                range100m = 130,
                range500m = 70,
                range1000m = 30,
                range1500m = 17,
                range2000m = 10,
            });
            pz3Shells.Add(new ShellViewModel()
            {
                shellId = 1,
                name = "Sprgr. 38",
                type = "HE",
                weight = 1.8,
                calibre = 50,
                range10m = 7,
                range100m = 7,
                range500m = 7,
                range1000m = 7,
                range1500m = 7,
                range2000m = 7,
            });

            List<ShellViewModel> t34Shells = new List<ShellViewModel>();
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "BR-350A",
                type = "APHEBC",
                weight = 6.3,
                calibre = 76.2,
                range10m = 86,
                range100m = 83,
                range500m = 74,
                range1000m = 67,
                range1500m = 57,
                range2000m = 38,
            });
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "BR-350B",
                type = "APHEBC",
                weight = 6.3,
                calibre = 76.2,
                range10m = 90,
                range100m = 87,
                range500m = 79,
                range1000m = 73,
                range1500m = 66,
                range2000m = 45,
            });
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "BR-350SP",
                type = "APBC",
                weight = 6.8,
                calibre = 76.2,
                range10m = 92,
                range100m = 88,
                range500m = 77,
                range1000m = 73,
                range1500m = 64,
                range2000m = 55,
            });
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "BR-350P",
                type = "APCR",
                weight = 3,
                calibre = 76.2,
                range10m = 116,
                range100m = 113,
                range500m = 102,
                range1000m = 92,
                range1500m = 78,
                range2000m = 60,
            });
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "BP-350A",
                type = "HEAT",
                weight = 5.3,
                calibre = 76.2,
                range10m = 80,
                range100m = 80,
                range500m = 80,
                range1000m = 80,
                range1500m = 80,
                range2000m = 80,
            });
            t34Shells.Add(new ShellViewModel()
            {
                shellId = 2,
                name = "QF-350M",
                type = "HE",
                weight = 6.2,
                calibre = 76.2,
                range10m = 15,
                range100m = 15,
                range500m = 15,
                range1000m = 15,
                range1500m = 15,
                range2000m = 15,
            });

            List<ShellViewModel> chieftainShells = new List<ShellViewModel>();
            chieftainShells.Add(new ShellViewModel()
            {
                shellId = 3,
                name = "L23",
                type = "APFSDS",
                weight = 0,
                calibre = 120,
                range10m = 600,
                range100m = 590,
                range500m = 550,
                range1000m = 512,
                range1500m = 483,
                range2000m = 425,
            });

            string pz3Image = @"../../Content/Images/Pzkpfw-III_Ausf-M_late.png";
            string t34Image = @"../../Content/Images/T34-76_model42_5tharmy_guards.png";
            string chieftainImage = @"../../Content/Images/chieftain_Mk2.png";

            tanks.Add(new TankViewModel() { tankId = 1, name = "Pz.Kpfw. III Ausf. M", nation = "Nazi Germany", afvClass = "Medium Tank", battleRating = 3.7, shells = pz3Shells, imageUrl = pz3Image });
            tanks.Add(new TankViewModel() { tankId = 2, name = "T-34 1942", nation = "Soviet Russia", afvClass = "Medium Tank", battleRating = 4.0, shells = t34Shells, imageUrl = t34Image });
            tanks.Add(new TankViewModel() { tankId = 3, name = "Chieftain Mk2", nation = "Britain", afvClass = "MBT", battleRating = 22, shells = chieftainShells, imageUrl = chieftainImage });
            tanks.Add(new TankViewModel() { tankId = 4, name = "Chieftain Mk3", nation = "West Germany", afvClass = "MBT2", battleRating = 23, shells = chieftainShells, imageUrl = @"../../Content/Images/chieftain-MkIII.png" });
            tanks.Add(new TankViewModel() { tankId = 5, name = "Chieftain Mk5", nation = "Britain", afvClass = "MBT3", battleRating = 25, shells = chieftainShells, imageUrl = @"../../Content/Images/chieftain-MkV_Brussels1979.png" });
            tanks.Add(new TankViewModel() { tankId = 6, name = "Chieftain Mk10", nation = "Britain", afvClass = "MBT4", battleRating = 30, shells = chieftainShells, imageUrl = @"../../Content/Images/chieftain-Mk10_BATUS.png" });
            tanks.Add(new TankViewModel() { tankId = 7, name = "Chieftain Mk11", nation = "Britain", afvClass = "MBT5", battleRating = 31, shells = chieftainShells, imageUrl = @"../../Content/Images/chieftain_MkXI_BATUS.png" });
            tanks.Add(new TankViewModel() { tankId = 8, name = "Chieftain Shir-I", nation = "Jordan", afvClass = "MBT6", battleRating = 32, shells = chieftainShells, imageUrl = @"../../Content/Images/Jordanian_Shir-I_AlKhalid.png" });

            return tanks;
        }

        //[Authorize]
        //[AcceptVerbs(HttpVerbs.Post)]
        public JsonResult FetchGraphData(int tankId)
        {
            List<TankViewModel> tanks = buildTankStats();
            TankViewModel tank = new TankViewModel();

            List<GraphStatistics> shellDataList = new List<GraphStatistics>();

            List<string> shellDataName = new List<string>();

            foreach (var tnk in tanks)
                if (tankId == tnk.tankId)
                    tank = tnk;

            foreach (var shell in tank.shells)
            {

                GraphStatistics shellData = new GraphStatistics();
                shellData.Name = shell.name;

                shellData.Serie = new int[6][];
                shellData.Serie[0] = new int[2] { 10, shell.range10m };
                shellData.Serie[1] = new int[2] { 100, shell.range100m };
                shellData.Serie[2] = new int[2] { 500, shell.range500m };
                shellData.Serie[3] = new int[2] { 1000, shell.range1000m };
                shellData.Serie[4] = new int[2] { 1500, shell.range1500m };
                shellData.Serie[5] = new int[2] { 2000, shell.range2000m };

                shellDataList.Add(shellData);
            }

            return Json(shellDataList, JsonRequestBehavior.AllowGet);
        }




        public JsonResult BuildTankTree()
        {
            List<TankViewModel> tanks = buildTankStats();

            JsonTreeModel TanksTreeData = new JsonTreeModel();
            TanksTreeData.text = "Tanks";
            TanksTreeData.state = new JsonTreeStateModel { opened = true };

            List<JsonTreeModel> NationChildren = new List<JsonTreeModel>();
            List<JsonTreeModel> BritainChildren = new List<JsonTreeModel>();
            List<JsonTreeModel> JordanChildren = new List<JsonTreeModel>();
            List<JsonTreeModel> GermanyChildren = new List<JsonTreeModel>();
            List<JsonTreeModel> RussiaChildren = new List<JsonTreeModel>();
            List<JsonTreeModel> WGermanyChildren = new List<JsonTreeModel>();

            foreach (var tank in tanks)
            {
                bool exists = NationChildren.Exists(element => element.text == tank.nation);
                if (exists == false)
                    NationChildren.Add(new JsonTreeModel() { text = tank.nation, });
                if (tank.nation == "Britain")
                    BritainChildren.Add(new JsonTreeModel() { text = tank.name, id = tank.tankId, icon = @"../../Content/Images/tanke.gif" });
                if (tank.nation == "Jordan")
                    JordanChildren.Add(new JsonTreeModel() { text = tank.name, id = tank.tankId, icon = @"../../Content/Images/tanke.gif" });
                if (tank.nation == "Nazi Germany")
                    GermanyChildren.Add(new JsonTreeModel() { text = tank.name, id = tank.tankId, icon = @"../../Content/Images/tanke.gif" });
                if (tank.nation == "Soviet Russia")
                    RussiaChildren.Add(new JsonTreeModel() { text = tank.name, id = tank.tankId, icon = @"../../Content/Images/tanke.gif" });
                if (tank.nation == "West Germany")
                    WGermanyChildren.Add(new JsonTreeModel() { text = tank.name, id = tank.tankId, icon = @"../../Content/Images/tanke.gif" });
            }
            NationChildren = NationChildren.OrderBy(c => c.text).ToList();
            TanksTreeData.children = NationChildren;

            foreach (var nation in NationChildren)
            {
                if (nation.text == "Britain")
                    nation.children = BritainChildren;
                if (nation.text == "Jordan")
                    nation.children = JordanChildren;
                if (nation.text == "Nazi Germany")
                    nation.children = GermanyChildren;
                if (nation.text == "Soviet Russia")
                    nation.children = RussiaChildren;
                if (nation.text == "West Germany")
                    nation.children = WGermanyChildren;
            }

            return Json(TanksTreeData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BuildDataTable(JQueryDataTableParamModel param)
        {
            List<TankViewModel> tanks = buildTankStats();
            List<JsonDataTableDetailModel> TanksData = new List<JsonDataTableDetailModel>();
            for (int i = 0; i < 10; i++)
            {
                foreach (var tank in tanks)
                {
                    TanksData.Add(new JsonDataTableDetailModel()
                    {
                        Name = tank.name + i,
                        Nation = tank.nation,
                        Class = tank.afvClass,
                        BattleRating = tank.battleRating
                    });
                }
            }

            var allTanks = TanksData;
            var filteredTanksData = TanksData;
            IEnumerable<JsonDataTableDetailModel> filteredTanks;
            if (!string.IsNullOrEmpty(param.sSearch))
            {
                //Used if particular columns are filtered (NOT USED IN CODE)
                var nameFilter = Convert.ToString(Request["sSearch_0"]);
                var nationFilter = Convert.ToString(Request["sSearch_1"]);
                var classFilter = Convert.ToString(Request["sSearch_2"]);
                var battleRatingFilter = Convert.ToString(Request["sSearch_3"]);

                //Optionally check whether the columns are searchable at all (USED IN CODE BUT ALWAYS RETURNS TRUE SO THERFORE ISN'T USED AS A FUNCTIONING FEATURE)
                var isNameSearchable = Convert.ToBoolean(Request["bSearchable_0"]);
                var isNationSearchable = Convert.ToBoolean(Request["bSearchable_1"]);
                var isClassSearchable = Convert.ToBoolean(Request["bSearchable_2"]);
                var isBattleRatingSearchable = Convert.ToBoolean(Request["bSearchable_3"]);

                filteredTanks = filteredTanksData
                         .Where(t => isNameSearchable && t.Name.ToLower().Contains(param.sSearch.ToLower())
                                     || // This is an OR operator. || performs a logical-OR of its bool operands. If the 1st operand evaluates to true, the second operand isn't evaluated. If the first operand evaluates to false, the second operator determines whether the OR expression as a whole evaluates to true or false.
                          isNationSearchable && t.Nation.ToLower().Contains(param.sSearch.ToLower())
                                     ||
                          isClassSearchable && t.Class.ToLower().Contains(param.sSearch.ToLower())
                                     ||
                          isBattleRatingSearchable && t.BattleRating.ToString().Contains(param.sSearch.ToLower()));
            }
            else
            {
                filteredTanks = allTanks;
            }

            var isNameSortable = Convert.ToBoolean(Request["bSortable_0"]);
            var isNationSortable = Convert.ToBoolean(Request["bSortable_1"]);
            var isClassSortable = Convert.ToBoolean(Request["bSortable_2"]);
            var isBattleRatingSortable = Convert.ToBoolean(Request["bSortable_3"]);
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<JsonDataTableDetailModel, string> orderingFunction = (t => sortColumnIndex == 0 && isNameSortable ? t.Name :   // This is a ?: operator. Shorthand IF ELSE statement. condition ? first_expression : second_expression; if (condition) first_expression else second_expression
                                                                            sortColumnIndex == 1 && isNationSortable ? t.Nation :
                                                                            sortColumnIndex == 2 && isClassSortable ? t.Class :                                                                           
                                                                       "");

            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                if (sortColumnIndex == 3)
                    filteredTanks = filteredTanks.OrderBy(t => t.BattleRating);
                else
                    filteredTanks = filteredTanks.OrderBy(orderingFunction);
            else
                if (sortColumnIndex == 3)
                    filteredTanks = filteredTanks.OrderByDescending(t => t.BattleRating);
                else
                    filteredTanks = filteredTanks.OrderByDescending(orderingFunction);


            var displayedTanks = filteredTanks.Skip(param.iDisplayStart).Take(param.iDisplayLength);
            var result = from t in displayedTanks select new[] { t.Name, t.Nation, t.Class, Convert.ToString(t.BattleRating) };
            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = allTanks.Count(),
                iTotalDisplayRecords = filteredTanks.Count(),
                aaData = result
            },
                        JsonRequestBehavior.AllowGet);
        }

        //public JsonResult BuildDataTable()
        //{
        //    List<TankViewModel> tanks = buildTankStats();
        //    List<JsonDataTableDetailModel> TanksDataTable = new List<JsonDataTableDetailModel>();

        //    for (int i = 0; i < 100; i++)
        //    {
        //        foreach (var tank in tanks)
        //        {
        //            TanksDataTable.Add(new JsonDataTableDetailModel()
        //            {
        //                Name = tank.name + i,
        //                Nation = tank.nation,
        //                Class = tank.afvClass,
        //                BattleRating = tank.battleRating
        //            });
        //        }
        //    }

        //    return Json(new
        //    {                               
        //        aaData = TanksDataTable.Select(x => new[] { x.Name, 
        //                                                    x.Nation, 
        //                                                    x.Class, 
        //                                                    x.BattleRating.ToString()})},
        //                                       JsonRequestBehavior.AllowGet);
        //}
    }
}

