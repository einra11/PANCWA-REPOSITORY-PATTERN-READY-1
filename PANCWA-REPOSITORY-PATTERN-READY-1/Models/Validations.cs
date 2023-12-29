using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.RegularExpressions;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Models
{
    public class MacAdressAttribute : RegularExpressionAttribute
    {
        public MacAdressAttribute()
            : base(@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")
        { }
    }

    //Greens are logical error that can be fix later
    public class IpAddressAttribute : RegularExpressionAttribute
    {
        public IpAddressAttribute()
            : base(@"^([\d]{1,3}\.){3}[\d]{1,3}$")
        { }

        public override bool IsValid(object value)
        {
            if (!base.IsValid(value))
                return false;

            string ipValue = value as string;
            if (IsIpAddressValid(ipValue))
                return true;

            return false;
        }

        private bool IsIpAddressValid(string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
                return false;

            string[] values = ipAddress.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            byte ipByteValue;
            foreach (string token in values)
            {
                if (!byte.TryParse(token, out ipByteValue))
                    return false;
            }

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("The '{0}' field has an invalid format.", name);
        }
    }
}
