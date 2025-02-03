using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class unidades : ContentPage
    {
        public unidades()
        {
            InitializeComponent();
            CriarBotoesLocalizacao();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void CriarBotoesLocalizacao()
        {
            // Lista de localizações
            var localizacoes = new List<Localizacao>
            {
                new Localizacao { Nome = "Mauá Plaza Shopping", Latitude = -23.66405419975353, Longitude = -46.46047115523703, StackLayout = stackLayoutmaua },
                new Localizacao { Nome = "Homero Thon", Latitude = -23.6708, Longitude = -46.5294, StackLayout = stackLayouthomero },
                new Localizacao { Nome = "Ribeirão Pires", Latitude = -23.710427886574, Longitude = -46.405861646652774, StackLayout = stackLayoutribeirao },
                new Localizacao { Nome = "Avenida Portugal", Latitude = -23.675260543777522, Longitude = -46.459784095018236, StackLayout = stackLayoutavenida },
                new Localizacao { Nome = "Valo Velho", Latitude = -23.683784155980188, Longitude = -46.79885241617073, StackLayout = stackLayoutvalo },
                new Localizacao { Nome = "Pereira Barreto", Latitude = -23.67507630146826,  Longitude = -46.53669080899921, StackLayout = stackLayoutpereira },
                new Localizacao { Nome = "Rio Branco", Latitude = -23.531618820260878,  Longitude = -46.646164485942194, StackLayout = stackLayoutriobranco },
                new Localizacao { Nome = "Itamarati", Latitude = -23.645775513280487,  Longitude = -46.50224332994923, StackLayout = stackLayoutitamarati },
                new Localizacao { Nome = "Esquível", Latitude = -23.685441570366997,  Longitude = -46.61549616797901, StackLayout = stackLayoutesquivel },
                new Localizacao { Nome = "Av. Goiás", Latitude = -23.61630463661742,  Longitude = -46.560504511440264, StackLayout = stackLayoutavgoias },
                new Localizacao { Nome = "Guilhermina", Latitude = -24.006382156766055,  Longitude = -46.42595049681094, StackLayout = stackLayoutguilhermina },
                new Localizacao { Nome = "Boqueirão", Latitude = -24.013240545196705,  Longitude = -46.413877605630944, StackLayout = stackLayoutboqueirao },
                new Localizacao { Nome = "Parque do Carmo", Latitude = -23.56672589150274,  Longitude = -46.46865964812368, StackLayout = stackLayoutcarmo },
                new Localizacao { Nome = "Giovani Breda", Latitude = -23.72365595294981,  Longitude = -46.57472566507778, StackLayout = stackLayoutgiovani },
                new Localizacao { Nome = "Zaíra", Latitude = -23.65057987943183,  Longitude = -46.44003069238441, StackLayout = stackLayoutzaira },
                new Localizacao { Nome = "Heliópolis", Latitude = -23.60620818262094,  Longitude = -46.59357714676989, StackLayout = stackLayoutheliopolis },
                new Localizacao { Nome = "Pimentas", Latitude = -23.448599274762163,  Longitude = -46.425150194906045, StackLayout = stackLayoutpimentas },
                new Localizacao { Nome = "Guaianases", Latitude = -23.547958335590717,  Longitude = -46.42657571214353, StackLayout = stackLayoutguaianases },
                new Localizacao { Nome = "Bom Clima", Latitude = -23.4554510782256,  Longitude = -46.51587291524391, StackLayout = stackLayoutclima },
                new Localizacao { Nome = "Campo Grande - MS", Latitude = -20.45983840696294,  Longitude = -54.61864374036686, StackLayout = stackLayoutcampogrande },
                new Localizacao { Nome = "Mogi das Cruzes", Latitude = -23.53078308779292, Longitude =  -46.20369961372492, StackLayout = stackLayoutmogi },
                new Localizacao { Nome = "Jaguaré", Latitude = -23.545304133634833,  Longitude = -46.74664311099942, StackLayout = stackLayoutjaguare },
                new Localizacao { Nome = "Jardim - GO", Latitude = -16.698955682571345,  Longitude = -49.24194410185421, StackLayout = stackLayoutjardim },
                new Localizacao { Nome = "Passeio das Águas - GO", Latitude = -16.63668285008143,  Longitude = -49.283298331586685, StackLayout = stackLayoutpasseio },
                new Localizacao { Nome = "Extrema - Minas Gerais", Latitude = -22.849696325588464,  Longitude = -46.31482941551496, StackLayout = stackLayoutextrema },
                new Localizacao { Nome = "Itaquera - Tennessee", Latitude = -23.5355931903994,  Longitude = -46.455954883643884, StackLayout = stackLayoutitaquera },
                new Localizacao { Nome = "Alameda", Latitude = -23.63984566628242,  Longitude = -46.55522558144441, StackLayout = stackLayoutalameda },
                new Localizacao { Nome = "Indaiatuba", Latitude = -23.09477370105967,  Longitude = -47.225150212221564, StackLayout = stackLayoutindaiatuba },
                new Localizacao { Nome = "São Vicente", Latitude = -23.967267575097818,  Longitude = -46.377565831647566, StackLayout = stackLayoutsaovicente },
                new Localizacao { Nome = "Camilópolis", Latitude = -23.62149164028088,  Longitude = -46.52884509906852, StackLayout = stackLayoutcamilopolis },
                new Localizacao { Nome = "Vila Prudente", Latitude = -23.58205385978668,  Longitude = -46.55863196500068, StackLayout = stackLayoutprudente },
                new Localizacao { Nome = "Laranjal Paulista", Latitude = -23.04299636377129,  Longitude = -47.83415171641764, StackLayout = stackLayoutlaranjal },
                new Localizacao { Nome = "Carapicuíba", Latitude = -23.561450305893562,  Longitude = -46.83749280231446, StackLayout = stackLayoutcarapicuiba },
                new Localizacao { Nome = "Sacomã", Latitude = -23.608253594547758,  Longitude = -46.597168790437095, StackLayout = stackLayoutsacoma },
                new Localizacao { Nome = "Vila Nova - GO", Latitude = -16.658800712601604,  Longitude = -49.2469659041844, StackLayout = stackLayoutvilanova },
                new Localizacao { Nome = "Jardim São Paulo", Latitude = -23.439082317855256,  Longitude =-46.529466484347175, StackLayout = stackLayoutjardimsp },
                new Localizacao { Nome = "Poá", Latitude = -23.528348215508984,  Longitude = -46.34550734226822, StackLayout = stackLayoutpoa },
                new Localizacao { Nome = "Sapopemba", Latitude = -23.595847897864065,  Longitude = -46.52439267837388, StackLayout = stackLayoutsapopemba },
            };

            // Criar botões dinâmicos
            foreach (var loc in localizacoes)
            {
                var button = new Button
                {
                    Text = $"Localização",
                    BackgroundColor = Color.FromHex("#FD5B1F"),
                    TextColor = Color.White,
                    FontSize = 15,
                    FontAttributes = FontAttributes.Bold,
                    HeightRequest = 50,
                    Margin = new Thickness(10) // Margem ao redor do botão
                };

                // Evento de clique para abrir a localização no Google Maps
                button.Clicked += (sender, e) => AbrirLocalizacao(loc.Latitude, loc.Longitude, loc.Nome);

                // Adiciona o botão ao layout correspondente
                loc.StackLayout.Children.Add(button);
            }
        }

        private async void AbrirLocalizacao(double latitude, double longitude, string nome)
        {
            var location = new Location(latitude, longitude);
            var options = new MapLaunchOptions { Name = nome };
            await Map.OpenAsync(location, options);
        }
    }

    // Classe para armazenar informações sobre a localização
    public class Localizacao
    {
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public StackLayout StackLayout { get; set; } // Referência ao StackLayout onde o botão será adicionado
    }
}