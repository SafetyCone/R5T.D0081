using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0064;


namespace R5T.D0081
{
    [ServiceDefinitionMarker]
    public interface IExecutionSynchronicityProvider : IServiceDefinition
    {
        Task<Synchronicity> GetExecutionSynchronicity();
    }
}
