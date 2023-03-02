using Microsoft.Maui.Graphics;

namespace MauiSample.Controls;

public class ButtonAction : TriggerAction<VisualElement>
{
    public Color BackgroundColor { get; set; }

    protected override void Invoke(VisualElement visual)
    {
        if (visual is not Button button) return;
        if (BackgroundColor != null) button.BackgroundColor = BackgroundColor;
    }
}

