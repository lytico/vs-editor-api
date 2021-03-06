//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//
    namespace Microsoft.VisualStudio.Text.Differencing
{
    /// <summary>
    /// The highlight mode for this <see cref="IDifferenceViewer"/>.
    /// </summary>
    public enum DifferenceHighlightMode
    {
        /// <summary>
        /// In this mode, line differences should be displayed only to the last character on each line.
        /// </summary>
        CodeContour,

        /// <summary>
        /// In this mode, line differences should be displayed so that they take up the entire width of the viewport.
        /// </summary>
        WholeLine
    }
}
