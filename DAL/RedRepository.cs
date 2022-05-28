using Entity;
using System.IO;
using System.Collections.Generic;

namespace DAL
{
    public class RedRepository
    {
		public Red Consult(string route)
		{
			int countRows = 0;
			List<int> countColumns = new List<int>();
			List<int> countExits = new List<int>();
			StreamReader reader = new StreamReader(route);
			var line = string.Empty;
			while ((line = reader.ReadLine()) != null)
			{
				countRows++;
				string [] data = line.Split(',');				
				countColumns.Add(data.Length+1);
				string[] salidas = line.Split(';');
				countExits.Add(salidas.Length+1);
			}
			reader.Close();
			Red red = new Red()
			{
				Entrada = countColumns.Count,
				Patrones = countRows,
				Salida = countExits.Count,
			};
			return red;
		}
		public int calculateExits(int columns, string line)
        {

			return 0;
        }
    }
}
