using Microsoft.Maui.Platform;
using View = Android.Views.View;

namespace MauiAndroidDragEventBug.Handlers;

public partial class BorderHandler : Microsoft.Maui.Handlers.BorderHandler
{
    protected override void ConnectHandler(ContentViewGroup platformView)
    {
        PlatformView.LongClick += OnLongClick; // fires on long click
        PlatformView.Touch += OnTouch; // fires on touch
        PlatformView.Drag += OnDrag; // never ever fires
        base.ConnectHandler(platformView);
    }

    private void OnTouch(object? sender, View.TouchEventArgs e)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Red;
        }
    }

    private void OnDrag(object? sender, View.DragEventArgs e)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Gold;
        }
    }

    private void OnLongClick(object? sender, View.LongClickEventArgs e)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Aqua;
        }
    }

    protected override void DisconnectHandler(ContentViewGroup platformView)
    {
        PlatformView.LongClick -= OnLongClick;
        PlatformView.Drag -= OnDrag;
        PlatformView.Touch -= OnTouch;

        base.DisconnectHandler(platformView);
    }
}