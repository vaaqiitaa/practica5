using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBotonMultiplicaClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.Numero1.Text);
		int num2=int.Parse(this.Numero2.Text);
		int resul = num1 * num2;
		this.Resultado.Text = resul.ToString();
	}

	protected void OnBotonDivideClicked (object sender, EventArgs e)
	{
		float num1=float.Parse(this.Numero1.Text);
		float num2=float.Parse(this.Numero2.Text);
		float resul = num1 / num2;
		this.Resultado.Text = resul.ToString();
	}

	protected void OnBotonRestaClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.Numero1.Text);
		int num2=int.Parse(this.Numero2.Text);
		int resul = num1 - num2;
		this.Resultado.Text = resul.ToString();
	}

	protected void OnBotonSumaClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.Numero1.Text);
		int num2=int.Parse(this.Numero2.Text);
		int resul = num1 + num2;
		this.Resultado.Text = resul.ToString();
	}
}
