using System.Threading.Tasks;
using Wakaba2ChApiClient.Exceptions;
using Wakaba2ChApiClient.Models;

namespace Wakaba2ChApiClient
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
        Task<LiteAllThreadsFromBoard> GetLiteAllThreadsFromBoard(string board);

        /// <summary>
        /// Все треды с сортировкой по времени создания треда
        /// </summary>
        /// <param name="board">Имя доски, например "/b", "b", "/b/", "b/"</param>
        /// <returns></returns>
        /// <exception cref="Wakaba2ChHttpException">HTTP ошибка</exception>
        /// <exception cref="Wakaba2ChSerializationException">Ошибка десериализации</exception>
        Task<AllThreads> GetAllThreadsFromBoard(string board = "b");
    }
}