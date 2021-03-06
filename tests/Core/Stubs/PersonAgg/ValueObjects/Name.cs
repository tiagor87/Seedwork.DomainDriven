using System.Collections.Generic;

namespace TRDomainDriven.Core.Tests.Stubs.PersonAgg.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName = null)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}