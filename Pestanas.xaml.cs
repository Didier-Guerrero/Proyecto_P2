namespace Proyecto_P2;

public partial class Pestanas : TabbedPage
{
	public Pestanas()
	{
		InitializeComponent();
        List<Habitacion> habitaciones = new List<Habitacion>
        {
            new Habitacion {Numero = 1, Tipo = "Habitacion doble" },
            new Habitacion {Numero = 2, Tipo = "Habitaci�n triple"},
            new Habitacion {Numero = 3, Tipo = "Habitaci�n matrimonial"}
        };

        habitacionesListView.ItemsSource = habitaciones;
    }
}