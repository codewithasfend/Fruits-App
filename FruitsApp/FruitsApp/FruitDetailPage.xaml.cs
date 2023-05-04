namespace FruitsApp;

public partial class FruitDetailPage : ContentPage
{
	public FruitDetailPage(Fruit fruit)
	{
		InitializeComponent();
		ImgFruit.Source = fruit.ImageName;
		LblFruitName.Text = fruit.Name;
		LblFruitSentence.Text = fruit.Sentence;
	}
}