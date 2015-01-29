﻿using System.Threading.Tasks;
using FireSharp.EventStreaming;
using FireSharp.Response;

namespace FireSharp.Interfaces
{
    public interface IFirebaseClient
    {
        Task<FirebaseResponse> GetAsync(string path);
        Task<SetResponse> SetAsync<T>(string path, T data);
        Task<PushResponse> PushAsync<T>(string path, T data);
        Task<DeleteResponse> DeleteAsync(string path);
        Task<FirebaseResponse> UpdateAsync<T>(string path, T data);

        Task<FirebaseResponse> ListenAsync(string path,
            ValueAddedEventHandler added = null,
            ValueChangedEventHandler changed = null,
            ValueRemovedEventHandler removed = null);
    }
}