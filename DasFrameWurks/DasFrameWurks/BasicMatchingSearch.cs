﻿namespace DasFrameWurks
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The basic matching search.
    /// </summary>
    public class BasicMatchingSearch : IBasicMatchingSearch
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool Contains(List<string> haystack, string needle)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}