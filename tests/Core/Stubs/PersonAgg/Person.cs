using TRDomainDriven.Core;
using TRDomainDriven.Tests.Stubs.PersonAgg.Events;
using TRDomainDriven.Tests.Stubs.PersonAgg.ValueObjects;

namespace TRDomainDriven.Tests.Stubs.PersonAgg
{
    public class Person : AggregateRoot<long>
    {
        public Person(long id, Name name) : base(id)
        {
            Name = name;
        }

        public Person(Name name)
        {
            Name = name;
            RaiseDomainEvent(new PersonCreated());
        }

        public Name Name { get; }
    }
}