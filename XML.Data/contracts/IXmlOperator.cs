namespace XML.Data.contracts
{
    using System.Collections.Generic;

    using Football.Models;
    using Models;

    public interface IXmlOperator
    {
        IEnumerable<MatchAdapter> GetAllMatches(string path);

        IEnumerable<PlayerAdapter> GetAllPlayers(string path);
    }
}
