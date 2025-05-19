// MainWindow.xaml.cs
using System.Windows;
// GLControl in den Host -Container einfügen
using System.Windows.Forms.Integration;
using OpenTK.WinForms;
using System.Windows.Forms;


namespace ManufacturingTool
{
    public partial class MainWindow : Window
    {
        private GLControl glControl;
        public MainWindow()
        {
              InitializeComponent();
              // OpenGL-Steuerung erstellen
              glControl = new GLControl();
              glControl.Dock = DockStyle.Fill;

              // Ereignisse (z. B. Zeichnen)
              glControl.Paint += GlControl_Paint;

              // In WindowsFormsHost einfügen
              glHost.Child = glControl;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo von WPF!");
        }
         private void GlControl_Paint(object sender, PaintEventArgs e)
        {
            // Hier kannst du mit OpenGL zeichnen, z. B.:
            OpenTK.Graphics.OpenGL.GL.ClearColor(0.1f, 0.2f, 0.3f, 1f);
            OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit);

            glControl.SwapBuffers();
        }
    }
}
