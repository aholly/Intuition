namespace Intuition.Domain.Models
{
    public class Train : Vehicle
    {
        public override decimal Execute(int time)
        {
            if (time >= 1000)
            {
                return 1.00m;
            }

            return base.Execute(time);
        }
    }
}
