using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class AnimarPanel
{
    private Timer timer;
    private Panel panel;
    private Panel panelContenedor;
    private Button expMenu;
    private Button[] botones;
    private bool expandido = true;

    // Almacenar estados originales
    private int panelAnchoOriginal;
    private int panelContenedorAnchoOriginal;
    private Rectangle expMenuOriginal;
    private Rectangle[] botonesOriginales;
    private int[] posicionesVerticalesContraido;
    private string[] posicionesNombres;

    // Configuración de animación
    private const int velocidad = 15;
    private const int margenError = 2;
    private const int posicionVertical = 137;
    private const int offsetDerecha = 20;

    public AnimarPanel(Panel panel, Panel panelContenedor, Button expMenu, params Button[] botones)
    {
        this.panel = panel;
        this.panelContenedor = panelContenedor;
        this.expMenu = expMenu;
        this.botones = botones;

        // Guardar estados iniciales
        panelAnchoOriginal = panel.Width;
        panelContenedorAnchoOriginal = panelContenedor.Width;
        expMenuOriginal = expMenu.Bounds;
        botonesOriginales = new Rectangle[botones.Length];

        for (int i = 0; i < botones.Length; i++)
        {
            // Guardar posición original incluyendo la coordenada Y
            botonesOriginales[i] = new Rectangle(
                botones[i].Left,
                botones[i].Top,  // Guardamos la posición vertical original
                botones[i].Width,
                botones[i].Height
            );
        }

        posicionesVerticalesContraido = new int[]
        {
            137,  // Posición Y para el primer botón
            205, // Posición Y para el segundo botón
            273, // Y así sucesivamente...
            341
        };

        posicionesNombres = new String[]
        {
            "Usuarios",  // Posición Y para el primer botón
            "Productos", // Posición Y para el segundo botón
            "Órdenes", // Y así sucesivamente...
            "Distribuidores"
        };


        timer = new Timer { Interval = 16 };
        timer.Tick += Animacion;
    }

    public void AlternarAnimacion()
    {
        if (!timer.Enabled) timer.Start();
    }

    private void Animacion(object sender, EventArgs e)
    {
        // Determinar dirección de la animación
        //int objetivoPanel = expandido ? -panelAnchoOriginal + expMenu.Width : 0;
        // Versión modificada para mostrar la mitad
        int objetivoPanel = expandido ? -(panelAnchoOriginal * 75 / 100) : 0; // 50% del ancho
        int objetivoPanelContenedor = expandido ? 55 : panel.Width - 55; // 55 para poder esconder el logo detras del panel contenedor

        // Mover el panel principal
        panel.Left = Suavizar(panel.Left, objetivoPanel, velocidad);
        panel.SendToBack();
        panelContenedor.Left = Suavizar(panelContenedor.Left, objetivoPanelContenedor, velocidad);


        // Aplicar movimiento a los botones
        foreach (var (boton, i) in botones.Select((b, i) => (b, i)))
        {
            if (expandido)
            {
                //expMenu.Left += 1; // Movimiento más suave
                expMenu.Left = Suavizar(expMenu.Left, 175, 2); // Movimiento más suave
                expMenu.Top = 34;
                // Contraer: Mover horizontalmente y a posición Y específica
                boton.ResetText();
                boton.Left = Suavizar(boton.Left, 175, velocidad);
                //boton.Left = Suavizar(boton.Left+19, expMenu.Left, velocidad);
                boton.Top = Suavizar(boton.Top, posicionesVerticalesContraido[i], velocidad);
            }
            else
            {
                //expMenu.Left -= 1; // Movimiento más suave
                expMenu.Left = Suavizar(expMenu.Left, 122, 2); // Movimiento más suave
                expMenu.Top = 34;
                // Expandir: Restaurar posición original
                boton.Left = Suavizar(boton.Left, botonesOriginales[i].Left, velocidad);
                //boton.Left = Suavizar(boton.Left-19, botonesOriginales[i].Left, velocidad);
                boton.Top = Suavizar(boton.Top, botonesOriginales[i].Top, velocidad);
                boton.Text = posicionesNombres[i];

            }

            // Mantenemos el ajuste de ancho si es necesario
            boton.Width = Suavizar(boton.Width, expandido ? expMenu.Width : botonesOriginales[i].Width, velocidad);

        }

        // Verificar finalización
        if (Math.Abs(panel.Left - objetivoPanel) < margenError)
        {
            timer.Stop();
            expandido = !expandido;
            AjustarValoresFinales();
        }
    }

    private int Suavizar(int actual, int objetivo, int paso)
    {
        if (actual < objetivo) return Math.Min(actual + paso, objetivo);
        if (actual > objetivo) return Math.Max(actual - paso, objetivo);
        return actual;
    }

    private void AjustarValoresFinales()
    {
        // Ajuste preciso final para el panel
        //panel.Left = expandido ? 0 : -panelAnchoOriginal + expMenu.Width;
        // Ajuste preciso final para el panel (mitad del ancho)
        panel.Left = expandido ? 0 : -(panelAnchoOriginal * 75 / 100);
        panelContenedor.Left = !expandido ? 55 : panel.Width - 55;

        // Ajuste preciso para los botones
        foreach (var (boton, i) in botones.Select((b, i) => (b, i)))
        {
            boton.Top = expandido ? posicionesVerticalesContraido[i] : botonesOriginales[i].Top;
            boton.Text = expandido ? posicionesNombres[i] : boton.Text = string.Empty;

        }

        //var panelMenuMod = panel.Width;
        //panelContenedor.Width = !expandido ? panelContenedorAnchoOriginal : panelContenedorAnchoOriginal;
        //panelContenedor.Left = !expandido ? 55 : panel.Width;

    }
}