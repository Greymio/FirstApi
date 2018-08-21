using FirstApi.Infra;
using FirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstApi.Controllers
{
    public class GuiController : ApiController
    {
        private List<Resto> _lresto;
        public List<Resto> LResto 
        {
            get { return _lresto = _lresto ?? new List<Resto>(); }
            set { _lresto = value; }
        }
        public GuiController()
        {
            LResto = PersistJson.getDatas();
            if (LResto.Count() < 1)
            {
                LResto = new List<Resto>();
                LResto.Add(new Resto() { Cote = 885, Nom = "Family Burger", Adresse = "Ciney pas très loin d'ici", JourOuverture = new List<string>() { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" }, NbPlaces = 52, PrixMoyen = 10 });
                LResto.Add(new Resto() { Cote = 982, Nom = "Vivaco", Adresse = "Ciney pas très loin d'ici non plus près de la pompe à essence direction nationale=> marche", JourOuverture = new List<string>() { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" }, NbPlaces = 68, PrixMoyen = 26 });
                PersistJson.SetDatas(LResto);
            }
            
        }
        public IEnumerable<Resto> Get()
        {
            return LResto;
        }

        [AcceptVerbs("GET")]
        [Route("api/Gui/BestResto")]
        public IEnumerable<Resto> BestRestoAllOverTheWorld()
        {
            return LResto.Where(r=>r.Cote>800);
        }

        [Route("api/Gui/Resto/{Nom}/{Pm}")]
        public IEnumerable<Resto> Get(string Nom, float Pm)
        {
            return LResto.Where(r => r.Nom.Contains(Nom) && r.PrixMoyen<=Pm);
        }

        // Use x-www-form-urlencoded to send data
        public IEnumerable<Resto> Post(Resto toBeInsert)
        {
            if (toBeInsert == null) return null;
            LResto.Add(toBeInsert);
            PersistJson.SetDatas(LResto);
            return LResto;
        }

    }
}
