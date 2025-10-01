using System.Collections.Generic;

namespace DeltaSchool.Utilities.Extensions
{
    public static class MaritalStatusExtension
    {
        public static string GetLabel(this MaritalStatus status)
        {
            switch (status)
            {
                case MaritalStatus.SINGLE:
                    return "Célibataire";
                case MaritalStatus.MARRIED:
                    return "Marié(e)";
                case MaritalStatus.DIVORCED:
                    return "Divorcé(e)";
                case MaritalStatus.WIDOWED:
                    return "Veuf(ve)";
                default:
                    return status.ToString();
            }
        }
    }

    public enum MaritalStatus
    {
        SINGLE,
        MARRIED,
        DIVORCED,
        WIDOWED
    }

    public class MaritalStatusItem
    {
        public MaritalStatus Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }

    public static class MaritalStatusMapper
    {
        public static readonly Dictionary<string, MaritalStatus> DbToEnum = new Dictionary<string, MaritalStatus>
        {
            { "SINGLE", MaritalStatus.SINGLE },
            { "MARRIED", MaritalStatus.MARRIED },
            { "DIVORCED", MaritalStatus.DIVORCED },
            { "WIDOWED", MaritalStatus.WIDOWED }
        };

        public static string GetLabelFromDbValue(string dbValue)
        {
            return DbToEnum.TryGetValue(dbValue, out var marital)
                ? marital.GetLabel()
                : dbValue;
        }
    }
}
