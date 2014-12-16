HighIronRanch.Cqrs
==================

Add-ons for github.com/sbalkum/SimpleCQRS, a fork of github.com/tyronegroves/SimpleCQRS.

Typical implementation of CqrsRuntime<TServiceLocator>:

public class CqrsRuntime : CqrsRuntime<StructureMapServiceLocator>
{
  protected override IEventStore GetEventStore(IServiceLocator serviceLocator)
  {
    return serviceLocator.Resolve<IEventStore>();
  }

  protected override ISnapshotStore GetSnapshotStore(IServiceLocator serviceLocator)
  {
    return serviceLocator.Resolve<ISnapshotStore>();
  }
}
	