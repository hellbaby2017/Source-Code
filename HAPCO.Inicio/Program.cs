using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using SVP;
namespace HAPCO.Inicio
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        //static SplashScreen splashscreen;
       
        [STAThread]
        static void Main()
        {
     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            //splashscreen = new SplashScreen();
            //splashscreen.Show();
            SplashScreen main = new SplashScreen();
            main.FormClosed += MainForm_Closed; // agrega esto aquí
            main.Show();
            Application.Run();
            //main.Shown += main_Shown;
            //main.FormClosed += main_FormClosed;
            //Application.Run(main);
            //if ( ==1 then)
            //    {

            //} 
            //Application.Run(main2);
            //Application.Run(new frmlogin());
        }
        //static void main_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    // Lo escondemos  
        //    Form form = sender as Form;
        //    form.Hide();

        //    // Mostramos la pantalla de bienvenida y cerramos 
        //    splashscreen.Show(); 
        //    System.Threading.Thread.Sleep(1000);   // Pausamos un segundo.
        //}
        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
        //static void main_Shown(object sender, EventArgs e)
        //{
        //    // Escondemos la pantalla. 

        //    splashscreen.Hide();
        //}
    }
    
}
