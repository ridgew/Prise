using System;
using System.Threading.Tasks;
using Prise.Core;

namespace Prise.AssemblyLoading
{
    public interface IAssemblyLoader : IDisposable
    {
        Task<IAssemblyShim> Load(IPluginLoadContext loadContext);
        Task Unload(IPluginLoadContext loadContext);
    }
}