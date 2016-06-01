using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agathas.Storefront.Infrastructure.Domain
{
    public abstract class ValueObjectBase
    {
        private List<BusinessRule> _brokenRules = new List<BusinessRule>();

        public abstract void Validate();

        public void ThrowExceptionIfInvalid()
        {
            _brokenRules.Clear();
            Validate();
            if (_brokenRules.Count > 0)
            {
                StringBuilder issues = new StringBuilder();
                foreach (var rule in _brokenRules)
                {
                    issues.Append(rule.Rule);
                }
                throw new ValueObjectIsInValidException(issues.ToString());
            }
        }

        public void AddBrokenRule(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }
    }
}
