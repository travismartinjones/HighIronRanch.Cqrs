using SimpleCqrs;

namespace HighIronRanch.Cqrs
{
	/// <summary>
    /// Represents the runtime environment for a <b>Cqrs</b> applications.
    /// </summary>
    /// <typeparam name="TServiceLocator">The type of the service locator.</typeparam>
    public class CqrsRuntime<TServiceLocator> : SimpleCqrsRuntime<TServiceLocator>, ISimpleCqrsRuntime
        where TServiceLocator : class, IServiceLocator
	{
	}
}
