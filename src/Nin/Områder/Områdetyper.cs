using System.Collections.Generic;

namespace Nin.Omr�der
{
    public class Omr�detyper
    {
        private static readonly Dictionary<string, Omr�detype> typer = new Dictionary<string, Omr�detype>();

        static Omr�detyper()
        {
            Add("NR", "Naturreservat");
            Add("NP", "Nasjonalpark");
            Add("LVO", "Landskapsvernomr�de");
            Add("D", "Dyrelivsfredning");
            Add("PD", "Plante- og dyrelivsfredning");
            Add("NM", "Naturminne");
            Add("LVOP", "Landskapsvernomr�de med plantelivsfredning");
            Add("DO", "Dyrefredningsomr�de");
            Add("LVOD", "Landskapsvernomr�de med dyrelivsfredning");
            Add("PO", "Plantefredningsomr�de");
            Add("LVOPD", "Landskapsvernomr�de med plante- og dyrelivsfredning");
            Add("PDO", "Plante- og dyrefredningsomr�de");
            Add("MIV", "Midlertidig verna omr�de/objekt");
            Add("P", "Plantelivsfredning");
            Add("BVV", "Biotopvern etter viltloven");
            Add("NRS", "Naturreservat (Svalbardmilj�loven)");
            Add("NPS", "Nasjonalpark (Svalbardmilj�loven)");
            Add("GVS", "Geotopvern (Svalbardmilj�loven)");
            Add("BV", "Biotopvern");
            Add("MAV", "Marint verneomr�de (naturmangfoldloven)");
        }

        private static void Add(string kode, string navn)
        {
            typer.Add(kode, new Omr�detype(kode, navn));
        }

        public static string KodeTilNavn(string kode)
        {
            if (!typer.ContainsKey(kode))
                return $"Andre ({kode})";
            return typer[kode].Navn;
        }
    }
}