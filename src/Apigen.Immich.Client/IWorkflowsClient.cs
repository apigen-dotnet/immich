using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Workflows operations
/// </summary>
public interface IWorkflowsClient
{
  /// <summary>
  /// List all workflows
  /// Operation: GET /workflows
  /// </summary>
  Task<List<WorkflowResponseDto>> GetWorkflowsAsync();

  /// <summary>
  /// Create a workflow
  /// Operation: POST /workflows
  /// </summary>
  Task<WorkflowResponseDto> CreateAsync(Apigen.Immich.Models.WorkflowCreateDto workflowCreateDto);

  /// <summary>
  /// Delete a workflow
  /// Operation: DELETE /workflows/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a workflow
  /// Operation: GET /workflows/{id}
  /// </summary>
  Task<WorkflowResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a workflow
  /// Operation: PUT /workflows/{id}
  /// </summary>
  Task<WorkflowResponseDto> UpdateAsync(string id, Apigen.Immich.Models.WorkflowUpdateDto workflowUpdateDto);

}
