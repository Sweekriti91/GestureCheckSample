using System;

#if IOS
using UIKit;
#endif

namespace GestureCheckSample.Controls
{
	public class MyBoxControl : Image
	{
		public MyBoxControl()
		{
            ModifyBoxView();
		}

		void ModifyBoxView()
		{
			Microsoft.Maui.Handlers.ImageHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
			{
#if ANDROID
				handler.PlatformView.LongClick += PlatformView_LongClick;

#endif
#if IOS
  
			handler.PlatformView.UserInteractionEnabled = true;  
			handler.PlatformView.AddGestureRecognizer(new UILongPressGestureRecognizer(HandleLongClick));  
#endif

			});
		}

#if IOS
    private void HandleLongClick(UILongPressGestureRecognizer sender)  
    {
            Console.WriteLine("Long Press iOS");
        }  
#endif
#if ANDROID
        private void PlatformView_LongClick(object sender, Android.Views.View.LongClickEventArgs e)
        {
			Console.WriteLine("Long Press Android");
        }
#endif
    }
}

