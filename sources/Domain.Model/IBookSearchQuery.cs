namespace DotNetConf.Sphinx.Domain
{
    using System.Collections.Generic;
    using Criteria;

    public interface IBookSearchQuery
    {
        IEnumerable<int> Execute(BookSearchCriterion criterion);
    }
}