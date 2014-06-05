using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projecten2Groep23.Exceptions;

namespace MvcApplication3.Models.Domain
{
    public class Evenement
    {
        [Key]
        public int ProposalId { get; set; }

        public String naam { get; set; }

        public DateTime Datum { get; set; }

        public List<Medewerker> Medewerkers { get; set; }

        public void voegMedewerkerToe(Medewerker medewerker)
        {

            

            if(Medewerkers.Any(m => m.VoorNaam.Equals(medewerker.VoorNaam) && m.AchterNaam.Equals(medewerker.VoorNaam)) != null)
                throw new MedewerkerAlToegevoegdException();

            Medewerkers.Add(medewerker)

        }

    }
}