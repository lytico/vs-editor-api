using System;
using Xwt;

namespace System.Windows
{
    public class UIElement
    {
#pragma warning disable CS3003 // Type is not CLS-compliant
        public Widget NSView { get; }
#pragma warning restore CS3003 // Type is not CLS-compliant

        public UIElement(Widget view)
        {
            NSView = view;
        }

        public static implicit operator UIElement(Widget view)
        {
            return new UIElement(view);
        }

        public static implicit operator Widget(UIElement uiElement)
        {
            return uiElement.NSView;
        }
    }
}
