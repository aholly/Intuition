namespace Intuition.Domain.Models
{
    public abstract class Vehicle
    {
        private Vehicle _nextVehicle;

        public void SetSuccessor(Vehicle next)
        {
            _nextVehicle = next;
        }

        public virtual decimal Execute(int time)
        {
            if (_nextVehicle != null)
            {
                return _nextVehicle.Execute(time);
            }
            return 0;
        }
    }
}



