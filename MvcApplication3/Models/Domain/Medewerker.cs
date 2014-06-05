using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication3.Models.Domain
{
    @Entity
    public class Medewerker
    {
        [Key]
        public int ProposalId { get; set; }
        public String VoorNaam { get; set; }
        public String AchterNaam { get; set; }

    }
}