namespace EvaluationDSL.Entities;

public enum Status
{
    NotStarted,
    InProgress = 0,
    CompletedTooManyBlocks = 5,
    CompletedPerfect = 10,
}