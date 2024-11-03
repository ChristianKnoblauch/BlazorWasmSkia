using Microsoft.AspNetCore.Components;
using SkiaSharp;
using SkiaSharp.Views.Blazor;

namespace BlazorWasmSkia.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    ILogger<Home>? logger { get; set; }

    SKCanvasView? canvasView1;
    SKCanvasView? canvasView2;

    public string Visible { get; set; } = "";

    void ToggleVisible()
    {
        Visible = Visible == "" ? "none" : "";

        canvasView1?.Invalidate();
        canvasView2?.Invalidate();
        
        StateHasChanged();
    }

    private void OnPaintSurface(SKPaintSurfaceEventArgs args)
    {
        args.Surface.Canvas.Clear(SKColor.Parse("ff0000"));

        logger?.LogInformation("w/h {0}/{1}", args.Info.Width, args.Info.Height);
    }
}
