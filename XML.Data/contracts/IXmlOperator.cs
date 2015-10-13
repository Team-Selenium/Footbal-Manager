namespace XML.Data.Contracts
{
    using System.Collections.Generic;
    using Models;

    public interface IXmlOperator
    {
        IEnumerable<MatchAdapter> GetAllMatches(string path);

        IEnumerable<PlayerAdapter> GetAllPlayers(string path);
    }
}