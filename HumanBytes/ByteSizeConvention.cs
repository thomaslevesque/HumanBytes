namespace HumanBytes
{
    /// <summary>
    /// Defines the conventions used for byte size units
    /// </summary>
    public enum ByteSizeConvention
    {
        /// <summary>
        /// Customary convention : binary multiples (1024), decimal prefixes (K/M/G...).
        /// </summary>
        Customary,
        /// <summary>
        /// Binary convention : binary multiples (1024), binary prefixes (Ki/Mi/Gi...).
        /// Equivalent à IEC.
        /// </summary>
        Binary,
        /// <summary>
        /// Decimal convention : decimal multiples (1000), decimal prefixes (K/M/G...).
        /// Equivalent à SI.
        /// </summary>
        Decimal,
        /// <summary>
        /// IEC 60027 convention : binary multiples (1024), binary prefixes (Ki/Mi/Gi...).
        /// Same as Binary.
        /// </summary>
        IEC = Binary,
        /// <summary>
        /// International System of Units convention : decimal multiples (1000), decimal prefixes (K/M/G...).
        /// Same as Decimal.
        /// </summary>
        SI = Decimal
    }
}