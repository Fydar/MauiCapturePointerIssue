# MauiCapturePointerIssue

When using a [MAUI Blazor Hybrid](https://github.com/dotnet/maui) application, using [HTMLElement.setPointerCapture](https://developer.mozilla.org/en-US/docs/Web/API/Element/setPointerCapture) does not capture the pointer movements when the cursor leaves the WebView.

Reproduced on Windows 10. [Demo project](https://github.com/Fydar/MauiCapturePointerIssue) based on the example from [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/API/Element/setPointerCapture) is attached.

## Video Demonstration

https://fydar.github.io/MauiCapturePointerIssue/rundown-video.mp4

## Expected Behaviour

<p align="center">
  <img src="https://raw.githubusercontent.com/Fydar/MauiCapturePointerIssue/main/docs/expected-behaviour-in-edge.gif" alt="Expected behaviour GIF"/></br>
  <sub><b>Figure 1</b>: <i>Expected behaviour demonstrated using Microsoft Edge.</i></sub>
</p>


## Actual Behaviour

<p align="center">
  <img src="https://raw.githubusercontent.com/Fydar/MauiCapturePointerIssue/main/docs/actual-behaviour-in-maui.gif" alt="Actual behaviour GIF"/></br>
  <sub><b>Figure 2</b>: <i>Actual behaviour demonstrated in a MAUI Blazor Hybrid application.</i></sub>
</p>
