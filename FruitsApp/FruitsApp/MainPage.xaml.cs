namespace FruitsApp;

public partial class MainPage : ContentPage
{
    public List<Fruit> fruitsList = new List<Fruit>()
    {
           new Fruit(){Name = "Apple", ImageName="apple.png",Sentence="An apple a day keeps the doctor away."},
           new Fruit(){ Name="Apricot",ImageName="apricot.png",Sentence="We had apricot trees in the back and side yard of the property."},
           new Fruit(){ Name="Banana",ImageName="banana.png",Sentence="The world is a better place when we share a banana split with someone we love."},
           new Fruit(){ Name="Grape",ImageName="grapes.png",Sentence="I really do not like grapes if they are not seedless."},
           new Fruit(){ Name="Guava",ImageName="guava.png",Sentence="On either side of the road are groves of guava trees."},
           new Fruit(){ Name="Kiwi",ImageName="kiwi.png",Sentence="Life is too short to waste on a bad kiwi"},
           new Fruit(){ Name="Mango",ImageName="mango.png",Sentence="Happiness is a ripe, juicy mango on a sunny day."},
           new Fruit(){ Name="Orange",ImageName="orange.png",Sentence="Oranges are not the only fruit, but they sure are a delicious one."},
           new Fruit(){ Name="Peach",ImageName="peach.png",Sentence="Although my mom cannot touch peaches, she washed and sliced peach for me."},
           new Fruit(){ Name="Pineapple",ImageName="pineapple.png",Sentence="It was a mystery that how that pineapple came to the student center without nobody moving it."},
           new Fruit(){ Name="Strawberry",ImageName="strawberry.png",Sentence="Emma does not love yogurt itself, but she eats strawberry yogurt every day."},
           new Fruit(){ Name="Watermelon",ImageName="watermelon.png",Sentence="My favorite summer fruit is watermelon, I love eating it when it is cold."},
    };
    public MainPage()
    {
        InitializeComponent();
        LvFruit.ItemsSource = fruitsList;
    }

    private void LvFruit_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Fruit;
        if (selectedItem == null) return;
        Navigation.PushAsync(new FruitDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }


    //private void LvFruit_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    var selectedItem = e.SelectedItem as Fruit;
    //    if (selectedItem == null) return;
    //    Navigation.PushAsync(new FruitDetailPage(selectedItem));
    //    ((ListView)sender).SelectedItem = null;
    //}
}

