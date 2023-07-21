using WalletBusinessLogic.Extentions;
using WalletBusinessLogic.Interfaces;
using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Managers
{
    public class PointManager: IPointManager
    {
        const int ROUNDING_PRECISION = 1000;

        public Task<Point> CalculatePoints()
        {
            int total = 0, firstPoint = 0, secondPoint = 0, current = 0 ;
            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);

            for (DateTime date = startDate; date <= DateTime.Now; date = date.AddDays(1))
            {
                if(date.IsDateStartOfSeason())
                {
                    total += 2;
                    firstPoint = 2;
                }
                else if (date.IsDateSecondDaytOfSeason())
                {
                    total += 3;
                    secondPoint = 3;
                }
                else
                {
                    current = firstPoint + (int)(secondPoint * 0.6);
                    total += current;
                    firstPoint = secondPoint;
                    secondPoint = current;
                }
            }

            return Task.FromResult(new Point
            {
                PointNumber = total,
                PointText = total >= ROUNDING_PRECISION ? (total / ROUNDING_PRECISION).ToString() + "k" : total.ToString()
            });
        }
    }
}
