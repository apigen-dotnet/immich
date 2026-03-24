using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueueName
{
    [JsonStringEnumMemberName("thumbnailGeneration")]
    ThumbnailGeneration,
    [JsonStringEnumMemberName("metadataExtraction")]
    MetadataExtraction,
    [JsonStringEnumMemberName("videoConversion")]
    VideoConversion,
    [JsonStringEnumMemberName("faceDetection")]
    FaceDetection,
    [JsonStringEnumMemberName("facialRecognition")]
    FacialRecognition,
    [JsonStringEnumMemberName("smartSearch")]
    SmartSearch,
    [JsonStringEnumMemberName("duplicateDetection")]
    DuplicateDetection,
    [JsonStringEnumMemberName("backgroundTask")]
    BackgroundTask,
    [JsonStringEnumMemberName("storageTemplateMigration")]
    StorageTemplateMigration,
    [JsonStringEnumMemberName("migration")]
    Migration,
    [JsonStringEnumMemberName("search")]
    Search,
    [JsonStringEnumMemberName("sidecar")]
    Sidecar,
    [JsonStringEnumMemberName("library")]
    Library,
    [JsonStringEnumMemberName("notifications")]
    Notifications,
    [JsonStringEnumMemberName("backupDatabase")]
    BackupDatabase,
    [JsonStringEnumMemberName("ocr")]
    Ocr,
    [JsonStringEnumMemberName("workflow")]
    Workflow,
    [JsonStringEnumMemberName("editor")]
    Editor,
}
