namespace Intuition.Domain.Models
{
    public class Truck : Vehicle
    {
        public override decimal Execute(int time)
        {
            if (time > 500 && time <= 999)
            {
                return .85m;
            }

            return base.Execute(time);
        }
    }

}
