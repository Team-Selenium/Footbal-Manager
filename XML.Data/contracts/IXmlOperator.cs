namespace XML.Data.contracts
{
    using System.Collections.Generic;

    using Football.Models;

    public interface IXmlOperator
    {
        ICollection<Match> GetAllMatches(string path);
    }
}
