using System;
using System.IO;
using Wakaba2ChApiClient.Helpers;

namespace Wakaba2ChApiClient
{
    internal static class Wakaba2ChApiEndpointBuilder
    {
        private const string Main2ChApiUrl = "https://2ch.hk/";
        private const string MobileParameters = "makaba/mobile.fcgi?task=";

        public static Uri LiteThreadsEndpoint(string board)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append("threads.json");
        }

        public static Uri AllThreadsOrderedByDateEndpoint(string board)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append("catalog_num.json");
        }

        public static Uri AllThreadsEndpoint(string board)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append("catalog.json");
        }

        public static Uri GetAllThreads(string board, string pageStr)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl).Append(board).Append($"{pageStr}.json");
        }

        public static Uri GetThread(string board, string threadNum, int posts)
        {
            board = board.Trim('/');
            return new Uri(
                $"{Main2ChApiUrl}/makaba/mobile.fcgi?task=get_thread&board={board}&thread={threadNum}&post={posts}");
        }

        public static Uri GetThreadDetails(string board, string threadNum)
        {
            board = board.Trim('/');
            return new Uri(Main2ChApiUrl)
                .Append(board)
                .Append("res")
                .Append($"{threadNum}.json");
        }

        public static Uri ThreadOptionsEndpoint()
        {
            return new Uri(Main2ChApiUrl).Append(MobileParameters + "get_boards");
        }
    }
}