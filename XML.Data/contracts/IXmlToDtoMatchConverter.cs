namespace XML.Data.Contracts
{
    using System.Collections.Generic;
    using Models;

    public interface IXmlToDtoMatchConverter
    {
        IEnumerable<DtoMatch> GetAllDtoMatches();
    }
}