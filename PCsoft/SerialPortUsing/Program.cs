using System;
using System.Windows.Forms;

namespace SerialPortUsing
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main(){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//SecurityForm test:
            //SecurityForm form = new SecurityForm();
            //form.ShowFace(@"C:\OneWireArdiuno2015\Photo\manager.png", "Кирилицын Антон Сергеевич", 3000);

			Application.Run(new AdminForm());
		}

	}
}
