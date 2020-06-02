using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagerEngine.Model.DTO
{
    public class ValidationResult
    {
        private ValidationResult()
        {
            Errors = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Errors { get; private set; }
        public bool IsInvalid => Errors.Any();

        public void Add(string key, string value) => Errors.Add(key, value);

        public static ValidationResult Create() => new ValidationResult();
    }

    public static class ValidationResultExtension
    {
        public static string ToExceptionString(this ValidationResult result)
        {
            var builder = new StringBuilder();

            foreach (var error in result.Errors)
                builder.AppendLine(error.Value);

            return builder.ToString();
        }
    }
}
