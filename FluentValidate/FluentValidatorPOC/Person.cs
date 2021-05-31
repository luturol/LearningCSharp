using System.Collections.Generic;
using FluentValidator;
using FluentValidator.Validation;

namespace FluentValidate.FluentValidatorPOC
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public IEnumerable<Notification> Validations()
        {
            return new ValidationContract()
            .Requires()
            .HasMinLen(Name, 4, "Name", "Name need to have at least 4 characters")
            .IsGreaterThan(Age, 18, "Age", "You must have at least 18 years old")
            .Notifications;
        }
    }
}