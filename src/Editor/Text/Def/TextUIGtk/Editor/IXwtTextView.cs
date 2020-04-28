//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//

using System;

using Xwt;
using Microsoft.VisualStudio.Text.Formatting;
using Xwt.Drawing;

namespace Microsoft.VisualStudio.Text.Editor
{
    public interface IXwtTextView : ITextView2
    {
        /// <summary>
        /// Gets the <see cref="NSView"/> that renders the view.
        /// </summary>
        Widget VisualElement { get; }

        /// <summary>
        /// Gets or sets the background for the visual element.
        /// </summary>
        Color Background { get; set; }

        /// <summary>
        /// Occurs when the <see cref="Background"/> is set.
        /// </summary>
        event EventHandler<Color> BackgroundBrushChanged;

        /// <summary>
        /// Occurs when the <see cref="ZoomLevel"/> is set.
        /// </summary>
        event EventHandler<ZoomLevelChangedEventArgs> ZoomLevelChanged;

        void PushCursor(object context, CursorType cursor);

        void PopCursor(object context);


        /// <summary>
        /// Gets or sets the Zoom level for the <see cref="ITextView3"/> between 20% to 400%
        /// </summary>
        double ZoomLevel { get; set; }

        IXPlatAdornmentLayer GetXPlatAdornmentLayer(string name);

        ITextViewLineSource FormattedLineSource { get; }

        void Focus();

        bool IsKeyboardFocused { get; }
        event EventHandler IsKeyboardFocusedChanged;

        IViewSynchronizationManager SynchronizationManager { get; set; }
    }
}
