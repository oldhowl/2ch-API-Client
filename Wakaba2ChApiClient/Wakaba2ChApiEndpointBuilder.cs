using System;
using System.Linq;

namespace Wakaba2ChApiClient
{
    internal static class Wakaba2ChApiEndpointBuilder
    {
        private const string Main2ChApiUrl = "https://2ch.hk/";

        public static Uri LiteThreadsEndpoint(string board)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append("threads.json");
        }
        
        public static Uri AllThreadsEndpoint(string board)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append("catalog_num.json");
        }


        private static Uri Append(this Uri uri, params string[] paths)
        {
            return new Uri(paths.Aggregate(
                uri.AbsoluteUri,
                (current, path) => string.Format("{0}/{1}", current.TrimEnd('/'), path.TrimStart('/'))));
        }
    }
}