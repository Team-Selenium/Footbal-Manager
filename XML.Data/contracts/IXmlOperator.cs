namespace XML.Data.Contracts
{
    using System.Collections.Generic;
    using Models;

    public interface IXmlOperator
    {
        IEnumerable<DtoMatch> GetAllMatches(string path);

        IEnumerable<DtoPlayer> GetAllPlayers(string path);
    }
}