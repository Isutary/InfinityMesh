using System.Collections.Generic;
using System.IO;
using InfinityMesh.Models;

namespace InfinityMesh.Infrastructure
{
    public class FileReader : IFileReader
    {
        private readonly IFormatter _formatter;
        
        public FileReader(IFormatter formatter) => _formatter = formatter;

        public List<City> ReadResults(string path)
        {
            var cities = new List<City>();
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(",");
                cities.Add(new City());
                cities[i].Name = line[0];
                for (int j = 1; j < line.Length; j++) 
                {
                    cities[i].Candidates.Add(new Candidate() { Votes = line[j++], Name = _formatter.Format(line[j]) });
                }
            }

            return cities;
        }
    }
}