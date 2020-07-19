using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.DomainModels
{
    public class Bobestyrer
    {
        public string Navn { get; set; }

        public string Adresse { get; set; }

        public int Postnummer { get; set; }

        public string By { get; set; }

        public string Kommentarer_til_bobestyrer { get; set; }
    }
}