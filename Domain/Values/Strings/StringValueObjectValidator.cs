using System;

namespace Bks.Training.Development.Domain.Values.Strings
{
    public class StringValueObjectValidator
    {
        private readonly string valueName;

        public StringValueObjectValidator(string valueName)
        {
            this.valueName = valueName;
        }

        public void Validate(string value, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{valueName} cannot be null or empty.", valueName);
            }

            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{valueName} is limited to {maxLength} characters.", valueName);
            }
        }
    }
}