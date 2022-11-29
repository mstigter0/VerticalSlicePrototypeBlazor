namespace Vertical_Slice_Architecture.Features.NumberDisplay
{
    public class NumberController : INumberController
    {
        public int CurrentNumber { get; private set; }
        public void IncrementNumber()
        {
            CurrentNumber++;
        }

        public void RandomNumber()
        {
            // Generate a random number between 0 and 100
            CurrentNumber = new Random().Next(0, 100);
        }
    }
}
