using UIKit;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace MauiAndroidDragEventBug.Handlers;

public partial class BorderHandler : Microsoft.Maui.Handlers.BorderHandler
{
    private readonly UILongPressGestureRecognizer _longPressGestureRecognizer;
    private readonly UIPanGestureRecognizer _panGestureRecognizer;
    private readonly UITapGestureRecognizer _tapGestureRecognizer;

    public BorderHandler()
    {
        _longPressGestureRecognizer = new UILongPressGestureRecognizer(HandleLongClick);
        _panGestureRecognizer = new UIPanGestureRecognizer(HandleDrag);
        _tapGestureRecognizer = new UITapGestureRecognizer(HandleTap);
    }

    protected override void ConnectHandler(ContentView platformView)
    {
        PlatformView.UserInteractionEnabled = true;
        PlatformView.AddGestureRecognizer(_longPressGestureRecognizer);
        PlatformView.AddGestureRecognizer(_panGestureRecognizer);
        PlatformView.AddGestureRecognizer(_tapGestureRecognizer);
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(ContentView platformView)
    {
        PlatformView.RemoveGestureRecognizer(_longPressGestureRecognizer);
        PlatformView.RemoveGestureRecognizer(_panGestureRecognizer);
        PlatformView.RemoveGestureRecognizer(_tapGestureRecognizer);
        PlatformView.UserInteractionEnabled = false;
        base.DisconnectHandler(platformView);
    }

    private void HandleLongClick(UILongPressGestureRecognizer sender)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Aqua;
        }
    }

    private void HandleDrag(UIPanGestureRecognizer sender)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Gold;
        }
    }

    private void HandleTap(UITapGestureRecognizer sender)
    {
        if (VirtualView is Border border)
        {
            border.BackgroundColor = Colors.Red;
        }
    }
}