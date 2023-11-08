using System;

namespace MangaDexApiWrapper.Basic.Interfaces
{
    public interface ITagIdGetter
    {
        public Task<string[]> GetIdArray(string[] names);   
    }
}
