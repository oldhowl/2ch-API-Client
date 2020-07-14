using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Wakaba2ChApiClient.Impl;

namespace Wakaba2ChApiClient.Tests
{
    public class ApiTests
    {
        private Wakaba2ChApi _wakaba2ChApi = new Wakaba2ChApi();
        private Wakaba2ChApiMobile _wakaba2ChApiMobile = new Wakaba2ChApiMobile();


        [Test]
        public async Task GetAllThreadsFromBoardOrderedByDate_Test()
        {
            var threads = await _wakaba2ChApi.GetAllThreadsFromBoardOrderedByDate("b");
            Assert.True(threads.Threads.Count > 0);
        }
        
        [Test]
        public async Task GetThreadOptions_Test()
        {
            var threadOptions = await _wakaba2ChApiMobile.GetThreadOptions();
            Assert.True(threadOptions.Art != null);
        }
    }
}