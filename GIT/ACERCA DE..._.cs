/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 24/10/2024
 * Time: 08:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIT
{
	/// <summary>
	/// Description of ACERCA_DE____.
	/// </summary>
	public partial class ACERCA_DE____ : Form
	{
		public ACERCA_DE____()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string mat,epo;
			mat=mate.Text;
			epo=escl.Text;
			label3.Text=epo+", "+mat+", "+", RFC Alumnos, "+"4.4, "+DateTime.Now.ToString("dd/MM/yyyy")+", YAEL LOPEZ GARCIA";
		}
	}
}
