using Calculator.Interfaces;

namespace Calculator.Services
{
    public class OperationService : IOperation
    {
        public double Operation(double input1, double input2, int operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case 1: return input1 + input2;
                case 2: return input1 - input2;
                case 3: return input1 * input2;
                case 4: return input1 / input2;
                default: return 0;
            }
        }
    }
}