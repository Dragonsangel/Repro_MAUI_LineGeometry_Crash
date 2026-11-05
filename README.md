# Repro_MAUI_LineGeometry_Crash
A simple reproducible example of the bug when a `LineGeometry` is inside a `GeometryGroup`, that it causes a MAUI App to crash on the Windows platform.  
Reported in dotnet/maui as issue #39950

To reproduce:
1. Load solution into VS
2. Run with the `Windows Machine` target
3. Press the `Working` button to see a page with a working example, with a `PathGeometry` instead of `LineGeometry`. Press the icon button to return to the main screen.
4. Press the `Broken` button. At this point the application should crash with the error
    > System.ArgumentException: The parameter is incorrect.
This operation is only allowed after a successful call to CanvasPathBuilder.BeginFigure.
   at ABI.Microsoft.Graphics.Canvas.Geometry.ICanvasPathBuilderMethods.AddLine(IObjectReference _obj, Single x, Single y)
   at Microsoft.Graphics.Canvas.Geometry.CanvasPathBuilder.AddLine(Single x, Single y)
   at Microsoft.Maui.Graphics.Win2D.W2DExtensions.AsPath(PathF path, Single ox, Single oy, Single fx, Single fy, ICanvasResourceCreator creator, CanvasFilledRegionDetermination fillMode)
   at Microsoft.Maui.Graphics.Win2D.W2DCanvasState.ClipPath(PathF path, WindingMode windingMode)
   at Microsoft.Maui.Graphics.ShapeDrawable.ClipPath(ICanvas canvas, PathF path)
   at Microsoft.Maui.Graphics.ShapeDrawable.DrawFillPath(ICanvas canvas, RectF dirtyRect, PathF path)
   at Microsoft.Maui.Graphics.ShapeDrawable.Draw(ICanvas canvas, RectF dirtyRect)
   at Microsoft.Maui.Graphics.Win2D.W2DGraphicsView.OnDraw(CanvasControl sender, CanvasDrawEventArgs args)