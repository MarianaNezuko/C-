
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Frame
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			convertir();
	
		}
		
		public  void convertir() {
			
			Console.WriteLine("Número Binario: ");
			
			int numero = int.Parse(txtBin.Text);
			int count;
			int acum;
			int aux;
			String resultado = "";
			
			
			while (numero > 0) {
				
				count = 0;
				acum = 0;
				
				while (count < 4){
					 
					aux = numero%10;
					if (aux == 1) {
						if (count == 0) {
							acum = acum+1;
						} else if (count == 1) { //Puede ser sustituido por una estructura switch 
							acum = acum+2;
						} else if (count == 2) {
							acum = acum+4;
						} else if (count == 3) {
							acum = acum+8;
						}
					}
					
					numero = numero/10;
					count++;
				}
				
				if (acum <= 9) {
					resultado = acum + resultado;
				} else if (acum > 9){
					if (acum == 10) {
						resultado = "A" + resultado;
					} else if (acum == 11){
						resultado = "B" + resultado;   //Puede ser sustituido por una estructura switch 
					} else if (acum == 12){
						resultado = "C" + resultado;
					} else if (acum == 13){
						resultado = "D" + resultado;
					} else if (acum == 14){
						resultado = "E" + resultado;
					} else if (acum == 15){
						resultado = "F" + resultado;
					}
				}
				
				txtHexa.Text = resultado.ToString();
			}
			
		}
	}
}
