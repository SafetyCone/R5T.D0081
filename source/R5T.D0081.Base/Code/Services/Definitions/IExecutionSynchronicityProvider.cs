using System;

using R5T.Dacia;

using R5T.Magyar;


namespace R5T.D0081
{
    [ServiceDefinitionMarker]
    public interface IExecutionSynchronicityProvider
    {
        Synchronicity GetSynchronicity();
    }
}
