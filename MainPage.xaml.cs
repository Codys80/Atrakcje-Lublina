namespace zadanie25._09
{
    using Microsoft.Maui.Controls;


        public class MainPage : ContentPage
        {
            public MainPage()
            {
                // Tworzymy blok tekstu
                var label = new Label
                {
                    Text = "Największe atrakcje Lublina Lublin zachwyca siedmiowiekową historią opowiadaną przez muzea, zabytki, tradycyjne smaki oraz legendy ukryte w uliczkach, zaułkach i murach kamienic. Doświadczanie miasta warto rozpocząć od spaceru po Starym Mieście i podążać szlakiem historycznego bogactwa, wielokulturowych korzeni, a także wciąż żywych tradycji okresu jagiellońskiego i diaspory żydowskiej. Trudno wskazać te najbardziej zachwycające miejsca, podpowiadamy więc gdzie na pewno trzeba być, aby choć trochę poznać Miasto Inspiracji.",
                    FontSize = 18,
                    TextColor = Colors.Black,
                    VerticalOptions = LayoutOptions.Start,
                    HorizontalOptions = LayoutOptions.Center,
                    LineBreakMode = LineBreakMode.WordWrap,
                    Margin = new Thickness(10)
                };

                // Ustawiamy układ strony z elementami
                Content = new StackLayout
                {
                    Padding = 20,
                    Children = { label }
                };
            }
        }
   

}
