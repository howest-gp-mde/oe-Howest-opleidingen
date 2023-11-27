using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services.Mock
{
    public class StudyProgrammeMockService : IStudyProgrammeService
    {

        public async Task AddStudyProgramme(StudyProgramme studyProgramme)
        {

        }
        public async Task<List<StudyProgramme>> GetAll()
        {
            await Task.Delay(2000);
            return await Task.FromResult(new List<StudyProgramme>
            {
                new StudyProgramme
                {
                    Id = 1,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/AAD%20voorbeeld%20banner.jpg?h=fb98929e&itok=Mafsm4py",
                    Type = "Graduaat",
                    Title = "Accounting Administration",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/accounting-administration",
                    Location = "Campus Brugge Station",
                    StudyForm = new List<string> { "Dagonderwijs", "Avondonderwijs", "Afstandsonderwijs" },
                    Description = "Wil je kantoren en bedrijven later een staaltje accounting magic laten zien? Heb je oog voor detail, oor voor klantvragen en stalen zenuwen als het op deadlines aankomt? Ben je nauwkeurig en kijk je graag naar de cijfers na de komma?"
                },
                new StudyProgramme
                {
                    Id = 2,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl",
                    Type = "Bachelor na bachelor",
                    Title = "Advanced Bachelor of Bioinformatics",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics",
                    Location = "Kortrijk",
                    StudyForm = new List<string> { "Dagonderwijs" },
                    Description = "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden."
                },
                new StudyProgramme
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
                new StudyProgramme
                {
                    Id = 4,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/BM_Bedrijfsmanagement_banner.jpg?h=a6ad8000&itok=nvVdoA6J",
                    Type = "Bachelor",
                    Title = "Bedrijfsmanagement",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor/bedrijfsmanagement",
                    Location = "Kortrijk",
                    StudyForm = new List<string> { "Dagonderwijs", "Afstandsonderwijs" },
                    Description = "De bachelor Bedrijfsmanagement is de perfecte opleiding om later in de bedrijfswereld aan de slag te gaan. Je wordt meteen ondergedompeld in het werkveld met echte projecten, bedrijfsbezoeken en studiereizen in binnen- en buitenland."
                },
                new StudyProgramme
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
                new StudyProgramme
                {
                    Id = 6,
                    Image = "https://www.howest.be/fs/styles/searchresult/public/images/51973282711_7932026739_k.jpg?h=1760b068&itok=pt6D_mZm",
                    Type = "Graduaat",
                    Title = "Bouwkundig Tekenen",
                    WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/bouwkundig-tekenen",
                    Location = "Kortrijk",
                    StudyForm = new List<string> { "Dagonderwijs", "Avondonderwijs" },
                    Description = "Droom je van het tekenen van bouwplannen? Ben je geïnteresseerd in de technische kant van de bouwsector? Wil je je materialenkennis uitbreiden en je ruimtelijke en bouwkundige inzicht versterken? Dan is de graduaatsopleiding Bouwkundig Tekenen in Brugge of Kortrijk iets voor jou."
                }
            });
        }
    }
}
