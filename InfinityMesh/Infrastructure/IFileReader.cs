using System.Collections.Generic;
using InfinityMesh.Models;

namespace InfinityMesh.Infrastructure
{
    public interface IFileReader
    {
        List<City> ReadResults(string path);
    }
}
