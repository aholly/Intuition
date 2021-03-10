namespace Intuition.Domain.Models
{
    public class Car : Vehicle
    {
        public override decimal Execute(int time)
        {
            if (time > 0 && time <= 499)
            {
                return .75m;
            }

            return base.Execute(time);
        }
    }
}
