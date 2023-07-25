namespace GestureCheckSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void SwipeGestureRecognizer_SwipedUp(object sender, SwipedEventArgs e)
    {
        Console.WriteLine("Swiped Up");
    }

    private void SwipeGestureRecognizer_SwipedDown(object sender, SwipedEventArgs e)
    {
        Console.WriteLine("Swiped Down");
    }

    private void SwipeGestureRecognizer_SwipedLeft(object sender, SwipedEventArgs e)
    {
        Console.WriteLine("Swiped Left");
    }

    private void SwipeGestureRecognizer_SwipeRight(object sender, SwipedEventArgs e)
    {
        Console.WriteLine("Swiped Right");
    }

    private void TapGestureRecognizer_TappedTwice(object sender, TappedEventArgs args)
    {
        Console.WriteLine("Tapped Button twice");
    }
}


