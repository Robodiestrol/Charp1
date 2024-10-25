/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 22/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GIT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.a1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.a2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(79, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(79, 70);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(177, 26);
			this.name.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(79, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "PRIMER APELLIDO";
			// 
			// a1
			// 
			this.a1.Location = new System.Drawing.Point(79, 130);
			this.a1.Name = "a1";
			this.a1.Size = new System.Drawing.Size(177, 26);
			this.a1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(263, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "SEGUNDO APELLIDO";
			// 
			// a2
			// 
			this.a2.Location = new System.Drawing.Point(263, 129);
			this.a2.Name = "a2";
			this.a2.Size = new System.Drawing.Size(189, 26);
			this.a2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(79, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "TELEFONO";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(79, 189);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(177, 26);
			this.textBox4.TabIndex = 7;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(263, 189);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(189, 26);
			this.textBox5.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(263, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "DIRECCION";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(459, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "SEMESTRE";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1° Semestre",
									"2° Semestre",
									"3° Semestre",
									"4° Semestre",
									"5° Semestre",
									"6° Semestre"});
			this.comboBox1.Location = new System.Drawing.Point(459, 189);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 28);
			this.comboBox1.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(727, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(203, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "FECHA DE NACIMIENTO";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(79, 272);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(266, 23);
			this.label8.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(79, 272);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "RFC";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(79, 299);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 30);
			this.button1.TabIndex = 16;
			this.button1.Text = "SACAR RFC";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(134, 271);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(211, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = " ";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(667, 76);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 21;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 386);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.a2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.a1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "GIT";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox a2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox a1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label1;
	}
}
