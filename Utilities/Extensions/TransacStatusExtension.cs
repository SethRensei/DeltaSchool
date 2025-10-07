using System.Collections.Generic;

namespace DeltaSchool.Utilities.Extensions
{
    public static class TransacStatusExtension
    {
        public static string GetLabel(this TransacStatus transac)
        {
            switch (transac)
            {
                case    TransacStatus.PARTIAL:
                    return "Paiement partiel";
                case TransacStatus.SUSPENDED:
                    return "Paiement Suspendu";
                case TransacStatus.PAID:
                    return "Payé";
                default:
                    return transac.ToString();
            }
        }
    }

    public enum TransacStatus
    {
        PARTIAL,
        SUSPENDED,
        PAID,
    }

    public class TransacStatusItem
    {
        public TransacStatus Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }

    public static class TransacStatusMapper
    {
        public static readonly Dictionary<string, TransacStatus> DbToEnum = new Dictionary<string, TransacStatus>
        {
            { "PARTIAL", TransacStatus.PARTIAL },
            { "SUSPENDED", TransacStatus.SUSPENDED },
            { "PAID", TransacStatus.PAID },
        };

        public static string GetLabelFromDbValue(string dbValue)
        {
            return DbToEnum.TryGetValue(dbValue, out var transac)
                ? transac.GetLabel()
                : dbValue;
        }
    }
}
