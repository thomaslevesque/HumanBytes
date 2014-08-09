namespace HumanBytes
{
    /// <summary>
    /// Defines rounding rules for byte sizes
    /// </summary>
    public enum ByteSizeRounding
    {
        /// <summary>
        /// Rounded to the closest value
        /// </summary>
        Closest,
        /// <summary>
        /// Rounded to the lower value
        /// </summary>
        Down,
        /// <summary>
        /// Rounded to the upper value
        /// </summary>
        Up
    }
}