using System;

using R5T.Magyar;


namespace R5T.D0081.I001
{
    public class HardCodedSynchronousExecutionSynchronicityProvider : IExecutionSynchronicityProvider
    {
        public Synchronicity GetSynchronicity()
        {
            return Synchronicity.Synchronous;
        }
    }
}
