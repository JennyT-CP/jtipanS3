namespace jtipanS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ";
    string contrasena = " ";

	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string UsuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
		usuario = UsuarioNuevo;
		contrasena = contrasenaNueva;
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new vRegistro());

    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioingresado = txtUsuario.Text;
			string contrasenaIngresada = txtContrasena.Text;

			if (usuario == usuarioingresado && contrasena == contrasenaIngresada)
			{
				await Navigation.PushAsync(new vPrincipal(usuario));
			}
			else
			{
				await DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
				txtUsuario.Text = "";
				txtContrasena.Text = "";
			}
		}
		catch (Exception ex)
		{

            await DisplayAlertAsync("ERROR", ex.Message, "Cerrar");
        }

    }
}