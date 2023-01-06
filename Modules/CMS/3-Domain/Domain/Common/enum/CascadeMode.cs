namespace Domain.Common.@enum
{
    /// <summary>
    /// Specifies how rules should cascade when one fails.
    /// </summary>
    public enum CascadeMode
    {
        /// <summary>
        /// When a rule fails, execution continues to the next rule.
        /// </summary>
        Continue,
        /// <summary>
        /// When a rule fails, validation is stopped and all other rules in the chain will not be executed.
        /// </summary>
        [Obsolete("Use CascadeMode.Stop instead. The behaviour of StopOnFirstFailure was ambiguous when used at validator-level. For more details, see https://docs.fluentvalidation.net/en/latest/conditions.html#stop-vs-stoponfirstfailure")]
        StopOnFirstFailure,

        /// <summary>
        /// When a rule fails, validation is immediately halted.
        /// </summary>
        Stop,
    }
}
