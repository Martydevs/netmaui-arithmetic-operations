namespace calc_aritmeticos_app;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private List<double> ParseDouble()
    {
        double n1 = (NumberOne.Text == null || NumberOne.Text == "")
            ? 0.0
            : Double.Parse(NumberOne.Text);

        double n2 = (NumberTwo.Text == null || NumberTwo.Text == "")
            ? 0.0
            : Double.Parse(NumberTwo.Text);

        List<double> result = new()
        {
            n1,
            n2
        };

        return result;
    }

    private void Addition(object sender, EventArgs e)
    {
        List<double> values = ParseDouble();
        double n1 = values[0];
        double n2 = values[1];
        double addition = n1 + n2;
        ArithmeticResult.Text = addition.ToString();
    }

    private void Substract(object sender, EventArgs e)
    {
        List<double> values = ParseDouble();
        double n1 = values[0];
        double n2 = values[1];
        double substraction = n1 - n2;
        ArithmeticResult.Text = substraction.ToString();
    }

    private void Multiply(object sender, EventArgs e)
    {
        List<double> values = ParseDouble();
        double n1 = values[0];
        double n2 = values[1];
        double multiplication = n1 * n2;
        ArithmeticResult.Text = multiplication.ToString();
    }

    private void Division(object sender, EventArgs e)
    {
        List<double> values = ParseDouble();
        double n1 = values[0];
        double n2 = values[1];
        double division = Math.Round(n1 / n2, 2);
        ArithmeticResult.Text = n2 == 0.0
            ? "No se puede dividir entre cero"
            : division.ToString();
    }

    private void Exit(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    private void Reset(object sender, EventArgs e)
    {
        NumberOne.Text = "";
        NumberTwo.Text = "";
        ArithmeticResult.Text = "";
    }
}

