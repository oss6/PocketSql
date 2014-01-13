using System.Collections.Generic;
using System.IO;

namespace PocketSql
{
    public class SchemaLogico
    {
        List<Relazione> sl;

        public SchemaLogico(string nome)
        {
            sl = new List<Relazione>();
            Nome = nome;
        }

        public string Nome { get; set; }

        public void AggiungiRelazione(Relazione relazione)
        {
            sl.Add(relazione);
        }

        public static SchemaLogico Analizza(string nome, string str)
        {
            SchemaLogico s = new SchemaLogico(nome);
            string[] relazioni = str.Split(';');

            foreach (string rel in relazioni)
                if (rel != "")
                    s.AggiungiRelazione(Relazione.Analizza(rel.Trim()));

            return s;
        }

        public string GeneraSQL(bool formatted = false)
        {
            string sql = "", newLine = formatted ? "\n" : "", tab = formatted ? "\t" : "", pkConstraint;
            List<string> primaryKeys, foreignKeys;

            // Creazione e uso del database per poter aggiungere le tabelle
            sql += "create database " + Nome + ";" + newLine;
            sql += "use " + Nome + ";" + newLine;

            foreach (Relazione rel in sl)
            {
                primaryKeys = new List<string>();
                foreignKeys = new List<string>();
                pkConstraint = "pk_" + rel.Nome;

                // Intestazione
                sql += "create table " + rel.Nome + newLine + "(" + newLine;

                // Aggiunta degli attributi
                for (int i = 0; i < rel.QAttributi; i++)
                {
                    if (rel[i].PK)
                        primaryKeys.Add(rel[i].Nome);

                    if (rel[i].FK != "")
                        foreignKeys.Add(rel[i].FK);

                    string opt = rel[i].Opzionale ? " null" : " not null";
                    sql += tab + (rel[i].Nome + " " + rel[i].Tipo + opt);

                    // Controllo ultimo campo
                    sql += ((i == rel.QAttributi - 1 && primaryKeys.Count == 0 && foreignKeys.Count == 0) ? newLine + ");" + newLine : "," + newLine);
                }

                // Aggiunta di eventuali chiavi primarie
                if (primaryKeys.Count != 0)
                {
                    sql += tab + "CONSTRAINT " + pkConstraint + " PRIMARY KEY (";
                    for (int i = 0; i < primaryKeys.Count; i++)
                        sql += (i == primaryKeys.Count - 1 ? primaryKeys[i] + ")" : primaryKeys[i] + ",");
                    sql += (foreignKeys.Count == 0 ? newLine + ");" + newLine : "," + newLine);
                }

                if (foreignKeys.Count != 0)
                    for (int i = 0; i < foreignKeys.Count; i++)
                    {
                        string refTable = foreignKeys[i].Split('.')[0].Trim();
                        string refPK = foreignKeys[i].Split('.')[1].Trim();

                        sql += tab + "CONSTRAINT " + refPK + " FOREIGN KEY " + "(" + refPK + ") REFERENCES " + refTable + "(" + refPK + ")";
                        sql += (i == foreignKeys.Count - 1 ? newLine + ");" + newLine : "," + newLine);
                    }
            }

            return sql;
        }

        public bool Salva(string percorso)
        {
            StreamWriter sw = new StreamWriter(percorso);

            try
            {
                sw.WriteLine("{");
                sw.WriteLine("\t'nome_schema' : " + "'" + Nome + "',");
                foreach (Relazione rel in sl)
                {
                    sw.WriteLine("\t{");
                    sw.WriteLine("\t\t'nome_relazione' : " + "'" + rel.Nome + "',");
                    sw.Write("\t\t'campi' : [");
                    for (int i = 0; i < rel.QAttributi; i++)
                        sw.Write(i == rel.QAttributi - 1 ? "'" + rel[i] + "'" : "'" + rel[i] + "',");
                    sw.WriteLine("]");
                    sw.WriteLine("\t},");
                }
                sw.WriteLine("}");

                sw.Close();
            }
            catch
            { return false; }

            return true;
        }
    }
}