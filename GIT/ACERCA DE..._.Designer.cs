/*
 * Created by SharpDevelop.
 * User: yaell
 * Date: 24/10/2024
 * Time: 08:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GIT
{
	partial class ACERCA_DE____
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
			this.escl = new System.Windows.Forms.TextBox();
			this.mate = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE DE TU ESCUELA";
			// 
			// escl
			// 
			this.escl.Location = new System.Drawing.Point(13, 40);
			this.escl.Name = "escl";
			this.escl.Size = new System.Drawing.Size(219, 26);
			this.escl.TabIndex = 1;
			// 
			// mate
			// 
			this.mate.FormattingEnabled = true;
			this.mate.Items.AddRange(new object[] {
									"LENGUA Y COMUNICASION",
									"PENAMIENTO MATEMATICO",
									"FRAMEWORKS",
									"METODOLOGIAS AGILES",
									"SOSIOEMOCIONAL",
									"INGLES",
									"HUMANIDADES",
									"ECOSISTEMAS"});
			this.mate.Location = new System.Drawing.Point(13, 99);
			this.mate.Name = "mate";
			this.mate.Size = new System.Drawing.Size(250, 28);
			this.mate.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "MATERIA";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(163, 39);
			this.button1.TabIndex = 4;
			this.button1.Text = "SACAR DATOS";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(805, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = " ";
			// 
			// ACERCA_DE____
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 383);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mate);
			this.Controls.Add(this.escl);
			this.Controls.Add(this.label1);
			this.Name = "ACERCA_DE____";
			this.Text = "ACERCA_DE____";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox mate;
		private System.Windows.Forms.TextBox escl;
		private System.Windows.Forms.Label label1;
	}
}
