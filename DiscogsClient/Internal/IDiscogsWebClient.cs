﻿using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace DiscogsClient.Internal
{
    internal interface IDiscogsWebClient
    {
        IRestRequest GetSearchRequest();

        IRestRequest GetReleaseRequest(int relaseId);

        IRestRequest GetMasterRequest(int masterId);

        IRestRequest GetMasterReleaseVersion(int masterId);

        IRestRequest GetArtistRequest(int artistId);

        IRestRequest GetLabelRequest(int artistId);

        IRestRequest GetArtistReleaseVersion(int artistId);

        Task<T> Execute<T>(IRestRequest request, CancellationToken cancellationToken);
    }
}