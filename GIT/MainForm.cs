/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 22/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GIT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			string nam,ap1,ap2,fech,p,o,i,dia,mes,anio;
			nam=name.Text;
			ap1=a1.Text;
			ap2=a2.Text;
			fech=monthCalendar1.SelectionStart.ToString("ddMMyy");
			
			p=nam.Substring(0,1);
			o=ap1.Substring(0,2);
			i=ap2.Substring(0,1);
			
			label11.Text=o.ToUpper()+i+p+fech;
			
			
		}
		
		
		

		

		
	}
}
