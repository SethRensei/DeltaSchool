using System.Collections.Generic;

namespace DeltaSchool.Utilities.Extensions
{
    public static class PeriodicityExtension
    {
        public static string GetLabel(this Periodicity pe)
        {
            switch (pe)
            {
                case Periodicity.HOURLY:
                    return "Horaire";
                case Periodicity.DAILY:
                    return "Journalière";
                case Periodicity.WEEKLY:
                    return "Hebdomadaire";
                case Periodicity.MONTHLY:
                    return "Mensuelle";
                case Periodicity.YEARLY:
                    return "Annuelle";
                default:
                    return pe.ToString();
            }
        }
    }

    public enum Periodicity
    {
        HOURLY,
        DAILY,
        WEEKLY,
        MONTHLY,
        YEARLY
    }

    public class PeriodicityItem
    {
        public Periodicity Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }

    public static class PeriodicityMapper
    {
        public static readonly Dictionary<string, Periodicity> DbToEnum = new Dictionary<string, Periodicity>
        {
            { "HOURLY", Periodicity.HOURLY },
            { "DAILY", Periodicity.DAILY },
            { "WEEKLY", Periodicity.WEEKLY },
            { "MONTHLY", Periodicity.MONTHLY },
            { "YEARLY", Periodicity.YEARLY }
        };

        public static string GetLabelFromDbValue(string dbValue)
        {
            return DbToEnum.TryGetValue(dbValue, out var pe)
                ? pe.GetLabel()
                : dbValue;
        }
    }
}
