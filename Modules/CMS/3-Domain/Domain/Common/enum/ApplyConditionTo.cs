namespace Domain.Common.@enum
{
    /// <summary>
    /// Specifies where a When/Unless condition should be applied
    /// </summary>
    public enum ApplyConditionTo
    {
        /// <summary>
        /// Applies the condition to all validators declared so far in the chain.
        /// </summary>
        AllValidators,
        /// <summary>
        /// Applies the condition to the current validator only.
        /// </summary>
        CurrentValidator
    }
}
