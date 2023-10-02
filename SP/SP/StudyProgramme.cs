﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SP
{
    public class StudyProgram
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string WebsiteUrl { get; set; }
        public string Location { get; set; }
        public List<string> StudyForm { get; set; }
        public string Description { get; set; }
    }

    public class StudyProgrammes
    {
        public List<StudyProgram> GetAll()
        {
            return new List<StudyProgram>
            {
                new StudyProgram
                {
                    Id = 1,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/AAD%20voorbeeld%20banner.jpg?h=fb98929e&itok=Mafsm4py",
                    Type = "Graduaat",
                    Title = "Accounting Administration",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/accounting-administration",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs" },
                    Description = "Wil je kantoren en bedrijven later een staaltje accounting magic laten zien? Heb je oog voor detail, oor voor klantvragen en stalen zenuwen als het op deadlines aankomt? Ben je nauwkeurig en kijk je graag naar de cijfers na de komma?"
                },
                new StudyProgram
                {
                    Id = 2,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl",
                    Type = "Bachelor na bachelor",
                    Title = "Advanced Bachelor of Bioinformatics",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs" },
                    Description = "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden."
                },
                new StudyProgram
                {
                    Id = 3,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl",
                    Type = "Bachelor na bachelor",
                    Title = "Advanced Bachelor of Bioinformatics at home",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics-at-home",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Afstandsonderwijs" },
                    Description = "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden."
                },
                new StudyProgram
                {
                    Id = 4,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/BM_Bedrijfsmanagement_banner.jpg?h=a6ad8000&itok=nvVdoA6J",
                    Type = "Bachelor",
                    Title = "Bedrijfsmanagement",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor/bedrijfsmanagement",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs", "Afstandsonderwijs" },
                    Description = "De bachelor Bedrijfsmanagement is de perfecte opleiding om later in de bedrijfswereld aan de slag te gaan. Je wordt meteen ondergedompeld in het werkveld met echte projecten, bedrijfsbezoeken en studiereizen in binnen- en buitenland."
                },
                new StudyProgram
                {
                    Id = 5,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/20211125_Howest_foto_BLT_Brochure-05936.jpg?h=3a3df0c5&itok=7IDTDqwC",
                    Type = "Bachelor",
                    Title = "Biomedische",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor/biomedische-laboratoriumtechnologie",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs" },
                    Description = "Biomedische Laboratoriumtechnologie is een brede, polyvalente en praktijkgerichte opleiding die uniek is in West-Vlaanderen. Het programma stoomt je als wetenschappelijk medewerker helemaal klaar voor de biomedische uitdagingen van de 21ste eeuw."
                },
                new StudyProgram
                {
                    Id = 6,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/51973282711_7932026739_k.jpg?h=1760b068&itok=pt6D_mZm",
                    Type = "Graduaat",
                    Title = "Bouwkundig Tekenen",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/bouwkundig-tekenen",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs", "Avondonderwijs" },
                    Description = "Droom je van het tekenen van bouwplannen? Ben je geïnteresseerd in de technische kant van de bouwsector? Wil je je materialenkennis uitbreiden en je ruimtelijke en bouwkundige inzicht versterken? Dan is de graduaatsopleiding Bouwkundig Tekenen in Brugge of Kortrijk iets voor jou."
                } 
            };
        }


    }
}