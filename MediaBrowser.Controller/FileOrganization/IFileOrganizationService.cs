﻿using MediaBrowser.Model.FileOrganization;
using MediaBrowser.Model.Querying;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.FileOrganization
{
    public interface IFileOrganizationService
    {
        /// <summary>
        /// Processes the new files.
        /// </summary>
        void BeginProcessNewFiles();

        /// <summary>
        /// Deletes the original file.
        /// </summary>
        /// <param name="resultId">The result identifier.</param>
        /// <returns>Task.</returns>
        Task DeleteOriginalFile(string resultId);

        /// <summary>
        /// Clears the log.
        /// </summary>
        /// <returns>Task.</returns>
        Task ClearLog();
        
        /// <summary>
        /// Performs the organization.
        /// </summary>
        /// <param name="resultId">The result identifier.</param>
        /// <returns>Task.</returns>
        Task PerformOrganization(string resultId);

        /// <summary>
        /// Performs the episode organization.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task.</returns>
        Task PerformEpisodeOrganization(EpisodeFileOrganizationRequest request);
        
        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IEnumerable{FileOrganizationResult}.</returns>
        QueryResult<FileOrganizationResult> GetResults(FileOrganizationResultQuery query);

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>FileOrganizationResult.</returns>
        FileOrganizationResult GetResult(string id);

        /// <summary>
        /// Gets the result by source path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>FileOrganizationResult.</returns>
        FileOrganizationResult GetResultBySourcePath(string path);
        
        /// <summary>
        /// Saves the result.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task SaveResult(FileOrganizationResult result, CancellationToken cancellationToken);
    }
}
