namespace DotNetConf.Sphinx.Domain.DataAccess.Queries
{
    using System.Collections.Generic;
    using Criteria;
    using JetBrains.Annotations;
    using global::Sphinx.Client.Commands.Search;
    using global::Sphinx.Client.Connections;

    [UsedImplicitly]
    public class BookSearchQuery : IBookSearchQuery
    {
        public IEnumerable<int> Execute(BookSearchCriterion criterion)
        {
            using (var connection = new TcpConnection("localhost", 9317))
            {
                var command = new SearchCommand(connection);

                connection.Open();
                command.Execute();

                IEnumerable<int> result = null;


                return result;
            }
        }
    }
}