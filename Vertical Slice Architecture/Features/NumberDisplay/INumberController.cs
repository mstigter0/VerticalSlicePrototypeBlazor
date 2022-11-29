namespace Vertical_Slice_Architecture.Features.NumberDisplay;

public interface INumberController
{
    public int CurrentNumber { get;}
    void IncrementNumber();
    void RandomNumber();
}