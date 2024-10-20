namespace kvargasT2.Views;

public partial class vLogin : ContentPage
{
    private List<string> usuarios = new List<string> { "Carlos", "Ana", "Jose" };
    private List<string> contrasenas = new List<string> { "carlos123", "ana123", "jose123" };

    public vLogin()
	{
		InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtPassword.Text;


        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            DisplayAlert("Error", "Debe ingresar un Usuario y una Contraseña", "Cerrar");
        }
        else
        {
            int index = usuarios.IndexOf(usuarioIngresado);
            if (index != -1 && contrasenas[index] == contrasenaIngresada)
            {
                Navigation.PushAsync(new Views.vHome(usuarioIngresado));
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrectos", "Cerrar");
            }
        }
    }
}