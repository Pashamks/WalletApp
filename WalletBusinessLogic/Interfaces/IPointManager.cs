using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Interfaces
{
    public interface IPointManager
    {
        Task<Point> CalculatePoints();
    }
}
