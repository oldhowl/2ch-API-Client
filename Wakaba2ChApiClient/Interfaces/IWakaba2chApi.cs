using System.Collections.Generic;
using System.Threading.Tasks;
using Wakaba2ChApiClient.Exceptions;
using Wakaba2ChApiClient.Models;

namespace Wakaba2ChApiClient.Interfaces
{
    public interface IWakaba2ChApi
    {
        /// <summary>
        /// Все треды с доски(облегченный вариант, с просмотрами и рейтингом для топа тредов)
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<LiteAllThreadsFromBoard> GetAllThreadsFromBoardLite(string board);

        /// <summary>
        /// Все треды доски с сортировкой по времени создания треда
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<AllThreads> GetAllThreadsFromBoardOrderedByDate(string board);

        /// <summary>
        /// Все треды с сортировкой по последнему посту:
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<AllThreads> GetAllThreadsFromBoardOrderedByLastPost(string board);

        /// <summary>
        /// Список тредов
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <param name="page">Номер страницы, указать 0 вместо index если нужна главная</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<ThreadsList> GetThreadsList(string board, int page);

        /// <summary>
        /// Получить тред
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <param name="threadNum">res параметр (id треда) без ".json"</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<ThreadDetails> GetThreadDetails(string board, string threadNum);

        /// <summary>
        /// Получить посты треда
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <param name="threadNum">id треда</param>
        /// <param name="post">С какого номера поста получить посты</param>
        /// <returns></returns>
        Task<IEnumerable<ThreadPost>> GetThreadPosts(string board, string threadNum, int post = 0);
    }
}