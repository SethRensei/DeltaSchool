using System.Collections.Generic;

namespace DeltaSchool.Utilities.Extensions
{
    public static class TransacTypeExtension
    {
        public static string GetLabel(this TransacType transac)
        {
            switch (transac)
            {
                case TransacType.REGISTRATION:
                    return "Inscription";
                case TransacType.SCHOOL_FEES:
                    return "Frais de scolairité";
                case TransacType.RE_REGISTRATION:
                    return "Réinscription";
                case TransacType.TRANSFER:
                    return "Transfert";
                default:
                    return transac.ToString();
            }
        }
    }

    public enum TransacType
    {
        REGISTRATION,
        SCHOOL_FEES,
        RE_REGISTRATION,
        TRANSFER,
    }

    public class TransacTypeItem
    {
        public TransacType Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }

    public static class TransacTypeMapper
    {
        public static readonly Dictionary<string, TransacType> DbToEnum = new Dictionary<string, TransacType>
        {
            { "REGISTRATION", TransacType.REGISTRATION },
            { "SCHOOL_FEES", TransacType.SCHOOL_FEES },
            { "RE_REGISTRATION", TransacType.RE_REGISTRATION },
            { "TRANSFER", TransacType.TRANSFER },
        };

        public static string GetLabelFromDbValue(string dbValue)
        {
            return DbToEnum.TryGetValue(dbValue, out var transac)
                ? transac.GetLabel()
                : dbValue;
        }
    }
}
