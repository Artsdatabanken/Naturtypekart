using System;
using Nin.Omr�der;

namespace Nin.Map.Tiles.Geometri
{
    [Serializable]
    public class Omr�de
    {
        public int AreaId;
        public int Number;
        public string Category;
        public string Name;
        public string kind;
        public AreaType Type;
        public string Value;

        public Omr�de(int areaId, AreaType areaType)
        {
            AreaId = areaId;
            Type = areaType;
        }

        public override string ToString()
        {
            return $"{Type} #{AreaId}: {Name}";
        }

        public static Omr�de Fra(Area area)
        {
            Omr�de omr�de = new Omr�de(area.Id, area.Type)
            {
                Number = area.Number,
                Category = area.Category,
                Name = area.Name,
                kind = Map(area.Type, area.Category),
                Value = area.Value
            };
            return omr�de;
        }

        private static string Map(AreaType t, string category)
        {
            switch (t)
            {
                case AreaType.Grid:
                    return "rutenett";
                case AreaType.Land:
                    return "land";
                case AreaType.Kommune:
                    return "kommune";
                case AreaType.Fylke:
                    return "fylke";
                case AreaType.Naturomr�de:
                case AreaType.Verneomr�de:
                    return category;
                default:
                    throw new ArgumentOutOfRangeException(nameof(t), t, null);
            }
        }
    }
}