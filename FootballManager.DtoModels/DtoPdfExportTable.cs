namespace FootballManager.DtoModels
{
    using System;

    public class DtoPdfExportTable
    {
        public DateTime Date { get; set; }

        public string Town { get; set; }

        public string Stadium { get; set; }

        public string HomeTeam { get; set; }

        public string AwayTeam { get; set; }

        public string Result { get; set; }
    }
}