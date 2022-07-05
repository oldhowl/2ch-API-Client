using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Wakaba2ChApiClient.Abstractions;
using Wakaba2ChApiClient.Interfaces;
using Wakaba2ChApiClient.Models;

namespace Wakaba2ChApiClient.Impl
{
    public class Wakaba2ChApi : Wakaba2ChApiBase, IWakaba2ChApi
    {
        public Wakaba2ChApi(HttpClientHandler httpClientHandler = null) : base(httpClientHandler)
        {
        }

        public Task<AllThreads> GetAllThreadsFromBoardOrderedByDate(string board) =>
            Get<AllThreads>(Wakaba2ChApiEndpointBuilder.AllThreadsOrderedByDateEndpoint(board).AbsoluteUri);

        public Task<AllThreads> GetAllThreadsFromBoardOrderedByLastPost(string board) =>
            Get<AllThreads>(Wakaba2ChApiEndpointBuilder.AllThreadsEndpoint(board).AbsoluteUri);

        public Task<LiteAllThreadsFromBoard> GetAllThreadsFromBoardLite(string board) =>
            Get<LiteAllThreadsFromBoard>(Wakaba2ChApiEndpointBuilder.LiteThreadsEndpoint(board).AbsoluteUri);

        public Task<ThreadsList> GetThreadsList(string board, int page) =>
            Get<ThreadsList>(Wakaba2ChApiEndpointBuilder
                .GetAllThreads(board, page <= 0 ? "index" : page.ToString()).AbsoluteUri);

        public Task<ThreadDetails> GetThreadDetails(string board, string threadNum) =>
            Get<ThreadDetails>(Wakaba2ChApiEndpointBuilder.GetThreadDetails(board, threadNum).AbsoluteUri);

        public Task<IEnumerable<ThreadPost>> GetThreadPosts(string board, string threadNum, int post)
            => Get<IEnumerable<ThreadPost>>(Wakaba2ChApiEndpointBuilder.GetThread(board, threadNum, post).AbsoluteUri);
    }
}