namespace DasFrameWurks
{
    using System.Collections.Generic;

    /// <summary>
    /// The BasicMatchingSearch interface.
    /// </summary>
    public interface IBasicMatchingSearch
    {
        #region Public Methods and Operators

        /// <summary>
        /// The contains.
        /// </summary>
        /// <param name="haystack">
        /// The haystack.
        /// </param>
        /// <param name="needle">
        /// The needle.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Contains(List<string> haystack, string needle);

        #endregion
    }
}