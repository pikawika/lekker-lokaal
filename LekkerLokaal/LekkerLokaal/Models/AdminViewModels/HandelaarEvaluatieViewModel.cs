﻿using LekkerLokaal.Models.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LekkerLokaal.Models.AdminViewModels
{
    public class HandelaarEvaluatieViewModel
    {
        [Required]
        public int HandelaarId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Naam")]
        public string Naam { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mailadres")]
        public string Emailadres { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Straatnaam")]
        public string Straat { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Huisnummer")]
        public string Huisnummer { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gemeente")]
        public string Gemeente { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Btw nummer")]
        public string BTW_Nummer { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Korte omschrijving")]
        public string Beschrijving { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Afbeelding")]
        public IFormFile Afbeelding { set; get; }

        [DataType(DataType.Text)]
        [Display(Name = "Opmerking (optioneel)")]
        public string Opmerking { get; set; }

        public string LogoPath { get; }

        public HandelaarEvaluatieViewModel(Handelaar handelaar)
        {
            HandelaarId = handelaar.HandelaarId;
            Naam = handelaar.Naam;
            Emailadres = handelaar.Emailadres;
            Beschrijving = handelaar.Beschrijving;
            BTW_Nummer = handelaar.BTW_Nummer ;
            Straat = handelaar.Straat;
            Huisnummer = handelaar.Huisnummer;
            Postcode = handelaar.Postcode;
            Gemeente = handelaar.Gemeente;
            LogoPath = handelaar.GetLogoPath();
        }

        public HandelaarEvaluatieViewModel()
        {

        }
    }
}
