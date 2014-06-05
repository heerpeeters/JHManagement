using System;
using System.Web;
using System.ComponentModel;

namespace Projecten2Groep23.Exceptions
{
    public class MedewerkerAlToegevoegdException : System.Exception
    {

        public MedewerkerAlToegevoegdException() : base("De medewerker werd al toegevoegd.") { }

        public MedewerkerAlToegevoegdException(string message) : base(message) { }


    }
}