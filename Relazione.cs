using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PocketSql
{
    public class Relazione
    {
        List<Attributo> rel;

        public Relazione(string nome)
        {
            rel = new List<Attributo>();
            Nome = nome;
        }

        public string Nome { get; set; }
        public int QAttributi
        {
            get { return rel.Count; }
        }
        public Attributo this[int idx]
        {
            get { return rel[idx]; }
        }

        public void AggiungiAttributo(string val, string tipo, bool opt = false, bool pk = false, string fk = "")
        {
            rel.Add(new Attributo(val, tipo, opt, pk, fk));
        }

        public static Relazione Analizza(string str)
        {
            int idxPar1 = str.IndexOf('{'), idxPar2 = str.IndexOf('}') - 1;
            Relazione r = new Relazione(str.Remove(idxPar1).Trim());
            List<string> attrs = str.Substring(idxPar1 + 1, idxPar2 - idxPar1).Split(',').ToList(), attrParts;
            string fk;

            foreach (string s in attrs)
            {
                attrParts = s.Split('$').Select(attr => attr.Trim()).ToList();
                try
                {
                    fk = attrParts.Single(f => f.Contains("fk") && f.IndexOf("fk") == 0).Trim();
                    fk = Regex.Replace(fk, "[()]", "").Remove(0, 2);
                }
                catch
                { fk = ""; }
                
                r.AggiungiAttributo(attrParts[0].Trim(), attrParts[1].Trim(), attrParts.Count >= 2 && attrParts.Contains("opt"), attrParts.Count >= 2 && attrParts.Contains("pk"), fk); // FK attrParts.Select(f => f.Contains("fk"))[0]
            }

            return r;
        }
    }
}