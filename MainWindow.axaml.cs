using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CarCostCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
        Car car = null;

        // Determine the base model
        var selectedModel = CarModelComboBox.SelectedItem as ComboBoxItem;
        switch (selectedModel?.Content)
        {
            case "C":
                car = new CModel();
                break;
            case "E":
                car = new EModel();
                break;
            case "CS":
                car = new CSModel();
                break;
            default:
                // Handle error case
                OrderSummaryTextBlock.Text = "Please select a car model.";
                return;
        }

        // Apply additional features
        if (V8EngineCheckBox.IsChecked == true)
        car = new V8Engine(car);
        if (V12EngineCheckBox.IsChecked == true)
            car = new V12Engine(car);
        if (SunRoofCheckBox.IsChecked == true)
            car = new SunRoof(car);
        if (OversizedGasTankCheckBox.IsChecked == true)
            car = new OversizedGasTank(car);
        if (RadioCheckBox.IsChecked == true)
            car = new BlaupunktRadio(car);
        if (SpareTireCheckBox.IsChecked == true)
            car = new SpareTire(car);

        // Calculate and display the cost and description
        OrderSummaryTextBlock.Text = $"New Order:\nCar: {car.Description}\nCost: ${car.Cost():N2}\nEnd Order";
    }
}
