using System.Collections.Generic;

namespace Prise.AssemblyScanning
{
    public interface IDirectoryTraverser
    {
        IEnumerable<string> TraverseDirectories(string startingPath);
        IEnumerable<string> TraverseFiles(string directory, IEnumerable<string> fileTypes);
    }
}