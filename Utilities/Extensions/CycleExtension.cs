using System.Collections.Generic;

namespace DeltaSchool.Utilities.Extensions
{
    public static class CycleExtension
    {
        public static string GetLabel(this Cycle cycle)
        {
            switch (cycle)
            {
                case Cycle.Kindergarten:
                    return "Maternelle";
                case Cycle.ElementarySchool:
                    return "Primaire";
                case Cycle.MiddleSchool:
                    return "Collège";
                case Cycle.HighSchool:
                    return "Lycée";
                default:
                    return cycle.ToString();
            }
        }
    }

    public enum Cycle
    {
        Kindergarten,
        ElementarySchool,
        MiddleSchool,
        HighSchool
    }


    public class CycleItem
    {
        public Cycle Value { get; set; }
        public string Label { get; set; }

        public override string ToString() => Label;
    }

    public static class CycleMapper
    {
        public static readonly Dictionary<string, Cycle> DbToEnum = new Dictionary<string, Cycle>
        {
            { "Kindergarten", Cycle.Kindergarten },
            { "ElementarySchool", Cycle.ElementarySchool },
            { "MiddleSchool", Cycle.MiddleSchool },
            { "HighSchool", Cycle.HighSchool }
        };

        public static string GetLabelFromDbValue(string dbValue)
        {
            return DbToEnum.TryGetValue(dbValue, out var cycle)
                ? cycle.GetLabel()
                : dbValue; // fallback si valeur inconnue
        }
    }

}
