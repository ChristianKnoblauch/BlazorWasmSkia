# BlazorWasmSkia
Sizing + iOS abnormality: ASP.NET Core 8 Webassembly App using SkiaSharp

# Description

When using SkiaSharp under a ASP.NET Core 8.0 Blazor WebAssembly App, the sizing and visibilitie of the SKCanvasView behaves abnormal.

I see two cases here:

1) Canvas not shown under iOS

Using CSS grid under TailwindCSS "flex justify-around", the canvas is not shown under iOS but under Windows its OK (using Edge browser on booth platforms)

2) Canvas size increases under iOS/Windows 

When using style="display: @Visible" in order to hide/show the parent <div/> also in a CSS grid under Tailwind "place-self-center", the canvas is shown booth under iOS and Windows but increases in size when hidden/shown multiple times.

# Example

The  example project has a button to hide/show the two canvas below the button having red background.

https://github.com/ChristianKnoblauch/BlazorWasmSkia
