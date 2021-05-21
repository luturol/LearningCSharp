using System.Collections.Generic;
using MoqXunit.Models;

namespace MoqXunit.Interfaces 
{
    public interface ICalculatorRepository
    {
        IEnumerable<Calculation> GetAllCalculations();
        void SaveCalculation(Calculation calc);
    }
}