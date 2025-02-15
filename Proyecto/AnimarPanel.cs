using System;
using System.Windows.Forms;

public class AnimarPanel
{
    private Timer timer;
    private Panel panel;
    private Button boton;
    private Panel contenedor;
    private int velocidad;
    private bool expandido;
    private int panelAncho;

    public AnimarPanel(Panel pnl, Button btn, Panel cont)
    {
        panel = pnl; // Panel del menu lateral
        boton = btn; // Boton que activa la animacion
        contenedor = cont; // Panel principal
        velocidad = 10;  // Velocidad de animacion
        expandido = true;
        panelAncho = panel.Width;

        timer = new Timer();
        timer.Interval = 10;  // Tiempo en milisegundos
        timer.Tick += Animacion;
    }

    public void AlternarAnimacion()
    {
        timer.Start();
    }

    private void Animacion(object sender, EventArgs e)
    {
        if (expandido)
        {
            if (panel.Left > -(panelAncho * 75 / 100)) // dejamos que sobre el 25% del panel
            {
                panel.Left -= velocidad;
                //boton.Left -= velocidad;
                contenedor.Left -= velocidad;
            }
            else
            {
                timer.Stop();
                expandido = false;
                //boton.Image = Image.FromFile("Imagenes/Expand.svg");
            }
        }
        else
        {
            if (panel.Left < 0)
            {
                panel.Left += velocidad;
                //boton.Left += velocidad;
                contenedor.Left += velocidad;
            }
            else
            {
                timer.Stop();
                expandido = true;
                //boton.Image = Image.FromFile("Imagenes/Expand2.svg");
            }
        }
    }
}
