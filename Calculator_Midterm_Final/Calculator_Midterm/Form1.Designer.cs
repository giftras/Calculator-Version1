namespace Calculator_Midterm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.history = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.TextBox();
			this.MC = new System.Windows.Forms.Button();
			this.Mplus = new System.Windows.Forms.Button();
			this.Mminus = new System.Windows.Forms.Button();
			this.number7 = new System.Windows.Forms.Button();
			this.number8 = new System.Windows.Forms.Button();
			this.number9 = new System.Windows.Forms.Button();
			this.number4 = new System.Windows.Forms.Button();
			this.number5 = new System.Windows.Forms.Button();
			this.number6 = new System.Windows.Forms.Button();
			this.number1 = new System.Windows.Forms.Button();
			this.number2 = new System.Windows.Forms.Button();
			this.number3 = new System.Windows.Forms.Button();
			this.CE = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.expo2 = new System.Windows.Forms.Button();
			this.expo3 = new System.Windows.Forms.Button();
			this.expoy = new System.Windows.Forms.Button();
			this.DEL = new System.Windows.Forms.Button();
			this.expo = new System.Windows.Forms.Button();
			this.expo10 = new System.Windows.Forms.Button();
			this.mod = new System.Windows.Forms.Button();
			this.equal = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Button();
			this.number0 = new System.Windows.Forms.Button();
			this.n = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.memory = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// history
			// 
			this.history.Location = new System.Drawing.Point(348, 42);
			this.history.Name = "history";
			this.history.Size = new System.Drawing.Size(159, 119);
			this.history.TabIndex = 0;
			this.history.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(351, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "HISTORY";
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.result.Location = new System.Drawing.Point(12, 12);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(330, 38);
			this.result.TabIndex = 2;
			this.result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.result_KeyPress);
			// 
			// MC
			// 
			this.MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.MC.Location = new System.Drawing.Point(13, 57);
			this.MC.Name = "MC";
			this.MC.Size = new System.Drawing.Size(50, 49);
			this.MC.TabIndex = 3;
			this.MC.Text = "MC";
			this.MC.UseVisualStyleBackColor = true;
			this.MC.Click += new System.EventHandler(this.MC_Click);
			// 
			// Mplus
			// 
			this.Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Mplus.Location = new System.Drawing.Point(69, 57);
			this.Mplus.Name = "Mplus";
			this.Mplus.Size = new System.Drawing.Size(50, 49);
			this.Mplus.TabIndex = 4;
			this.Mplus.Text = "M+";
			this.Mplus.UseVisualStyleBackColor = true;
			this.Mplus.Click += new System.EventHandler(this.Mplus_Click);
			// 
			// Mminus
			// 
			this.Mminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Mminus.Location = new System.Drawing.Point(125, 57);
			this.Mminus.Name = "Mminus";
			this.Mminus.Size = new System.Drawing.Size(50, 49);
			this.Mminus.TabIndex = 5;
			this.Mminus.Text = "M -";
			this.Mminus.UseVisualStyleBackColor = true;
			this.Mminus.Click += new System.EventHandler(this.Mminus_Click);
			// 
			// number7
			// 
			this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number7.Location = new System.Drawing.Point(13, 112);
			this.number7.Name = "number7";
			this.number7.Size = new System.Drawing.Size(50, 49);
			this.number7.TabIndex = 6;
			this.number7.Text = "7";
			this.number7.UseVisualStyleBackColor = true;
			this.number7.Click += new System.EventHandler(this.number7_Click);
			// 
			// number8
			// 
			this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number8.Location = new System.Drawing.Point(69, 112);
			this.number8.Name = "number8";
			this.number8.Size = new System.Drawing.Size(50, 49);
			this.number8.TabIndex = 7;
			this.number8.Text = "8";
			this.number8.UseVisualStyleBackColor = true;
			this.number8.Click += new System.EventHandler(this.number8_Click);
			// 
			// number9
			// 
			this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number9.Location = new System.Drawing.Point(125, 112);
			this.number9.Name = "number9";
			this.number9.Size = new System.Drawing.Size(50, 49);
			this.number9.TabIndex = 8;
			this.number9.Text = "9";
			this.number9.UseVisualStyleBackColor = true;
			this.number9.Click += new System.EventHandler(this.number9_Click);
			// 
			// number4
			// 
			this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number4.Location = new System.Drawing.Point(13, 167);
			this.number4.Name = "number4";
			this.number4.Size = new System.Drawing.Size(50, 49);
			this.number4.TabIndex = 9;
			this.number4.Text = "4";
			this.number4.UseVisualStyleBackColor = true;
			this.number4.Click += new System.EventHandler(this.number4_Click);
			// 
			// number5
			// 
			this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number5.Location = new System.Drawing.Point(69, 167);
			this.number5.Name = "number5";
			this.number5.Size = new System.Drawing.Size(50, 49);
			this.number5.TabIndex = 10;
			this.number5.Text = "5";
			this.number5.UseVisualStyleBackColor = true;
			this.number5.Click += new System.EventHandler(this.number5_Click);
			// 
			// number6
			// 
			this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number6.Location = new System.Drawing.Point(125, 167);
			this.number6.Name = "number6";
			this.number6.Size = new System.Drawing.Size(50, 49);
			this.number6.TabIndex = 11;
			this.number6.Text = "6";
			this.number6.UseVisualStyleBackColor = true;
			this.number6.Click += new System.EventHandler(this.number6_Click);
			// 
			// number1
			// 
			this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number1.Location = new System.Drawing.Point(13, 222);
			this.number1.Name = "number1";
			this.number1.Size = new System.Drawing.Size(50, 49);
			this.number1.TabIndex = 12;
			this.number1.Text = "1";
			this.number1.UseVisualStyleBackColor = true;
			this.number1.Click += new System.EventHandler(this.number1_Click);
			// 
			// number2
			// 
			this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number2.Location = new System.Drawing.Point(69, 222);
			this.number2.Name = "number2";
			this.number2.Size = new System.Drawing.Size(50, 49);
			this.number2.TabIndex = 13;
			this.number2.Text = "2";
			this.number2.UseVisualStyleBackColor = true;
			this.number2.Click += new System.EventHandler(this.number2_Click);
			// 
			// number3
			// 
			this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number3.Location = new System.Drawing.Point(125, 222);
			this.number3.Name = "number3";
			this.number3.Size = new System.Drawing.Size(50, 49);
			this.number3.TabIndex = 14;
			this.number3.Text = "3";
			this.number3.UseVisualStyleBackColor = true;
			this.number3.Click += new System.EventHandler(this.number3_Click);
			// 
			// CE
			// 
			this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.CE.Location = new System.Drawing.Point(181, 57);
			this.CE.Name = "CE";
			this.CE.Size = new System.Drawing.Size(50, 49);
			this.CE.TabIndex = 15;
			this.CE.Text = "CE";
			this.CE.UseVisualStyleBackColor = true;
			this.CE.Click += new System.EventHandler(this.CE_Click);
			// 
			// plus
			// 
			this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.plus.Location = new System.Drawing.Point(181, 112);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(50, 49);
			this.plus.TabIndex = 16;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			// 
			// minus
			// 
			this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.minus.Location = new System.Drawing.Point(181, 167);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(50, 49);
			this.minus.TabIndex = 17;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			// 
			// multiply
			// 
			this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.multiply.Location = new System.Drawing.Point(181, 222);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(50, 49);
			this.multiply.TabIndex = 18;
			this.multiply.Text = "x";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.multiply_Click);
			// 
			// C
			// 
			this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.C.Location = new System.Drawing.Point(237, 57);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(50, 49);
			this.C.TabIndex = 19;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = true;
			this.C.Click += new System.EventHandler(this.C_Click);
			// 
			// expo2
			// 
			this.expo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo2.Location = new System.Drawing.Point(237, 112);
			this.expo2.Name = "expo2";
			this.expo2.Size = new System.Drawing.Size(50, 49);
			this.expo2.TabIndex = 20;
			this.expo2.Text = "x^2";
			this.expo2.UseVisualStyleBackColor = true;
			this.expo2.Click += new System.EventHandler(this.expo2_Click);
			// 
			// expo3
			// 
			this.expo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo3.Location = new System.Drawing.Point(237, 167);
			this.expo3.Name = "expo3";
			this.expo3.Size = new System.Drawing.Size(50, 49);
			this.expo3.TabIndex = 21;
			this.expo3.Text = "x^3";
			this.expo3.UseVisualStyleBackColor = true;
			this.expo3.Click += new System.EventHandler(this.expo3_Click);
			// 
			// expoy
			// 
			this.expoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expoy.Location = new System.Drawing.Point(237, 222);
			this.expoy.Name = "expoy";
			this.expoy.Size = new System.Drawing.Size(50, 49);
			this.expoy.TabIndex = 22;
			this.expoy.Text = "x^y";
			this.expoy.UseVisualStyleBackColor = true;
			this.expoy.Click += new System.EventHandler(this.expoy_Click);
			// 
			// DEL
			// 
			this.DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.DEL.Location = new System.Drawing.Point(292, 57);
			this.DEL.Name = "DEL";
			this.DEL.Size = new System.Drawing.Size(50, 49);
			this.DEL.TabIndex = 23;
			this.DEL.Text = "del";
			this.DEL.UseVisualStyleBackColor = true;
			this.DEL.Click += new System.EventHandler(this.DEL_Click);
			// 
			// expo
			// 
			this.expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo.Location = new System.Drawing.Point(292, 167);
			this.expo.Name = "expo";
			this.expo.Size = new System.Drawing.Size(50, 49);
			this.expo.TabIndex = 24;
			this.expo.Text = "Exp";
			this.expo.UseVisualStyleBackColor = true;
			this.expo.Click += new System.EventHandler(this.expo_Click);
			// 
			// expo10
			// 
			this.expo10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo10.Location = new System.Drawing.Point(292, 112);
			this.expo10.Name = "expo10";
			this.expo10.Size = new System.Drawing.Size(50, 49);
			this.expo10.TabIndex = 25;
			this.expo10.Text = "10^x";
			this.expo10.UseVisualStyleBackColor = true;
			this.expo10.Click += new System.EventHandler(this.expo10_Click);
			// 
			// mod
			// 
			this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.mod.Location = new System.Drawing.Point(293, 222);
			this.mod.Name = "mod";
			this.mod.Size = new System.Drawing.Size(50, 49);
			this.mod.TabIndex = 26;
			this.mod.Text = "Mod";
			this.mod.UseVisualStyleBackColor = true;
			this.mod.Click += new System.EventHandler(this.mod_Click);
			// 
			// equal
			// 
			this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.equal.Location = new System.Drawing.Point(237, 277);
			this.equal.Name = "equal";
			this.equal.Size = new System.Drawing.Size(106, 49);
			this.equal.TabIndex = 27;
			this.equal.Text = "=";
			this.equal.UseVisualStyleBackColor = true;
			this.equal.Click += new System.EventHandler(this.equal_Click);
			this.equal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.equal_KeyPress);
			// 
			// divide
			// 
			this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.divide.Location = new System.Drawing.Point(181, 277);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(50, 49);
			this.divide.TabIndex = 28;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = true;
			this.divide.Click += new System.EventHandler(this.divide_Click);
			// 
			// dot
			// 
			this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dot.Location = new System.Drawing.Point(125, 277);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(50, 49);
			this.dot.TabIndex = 29;
			this.dot.Text = ".";
			this.dot.UseVisualStyleBackColor = true;
			this.dot.Click += new System.EventHandler(this.dot_Click);
			// 
			// number0
			// 
			this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number0.Location = new System.Drawing.Point(68, 277);
			this.number0.Name = "number0";
			this.number0.Size = new System.Drawing.Size(50, 49);
			this.number0.TabIndex = 30;
			this.number0.Text = "0";
			this.number0.UseVisualStyleBackColor = true;
			this.number0.Click += new System.EventHandler(this.number0_Click);
			// 
			// n
			// 
			this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.n.Location = new System.Drawing.Point(12, 277);
			this.n.Name = "n";
			this.n.Size = new System.Drawing.Size(50, 49);
			this.n.TabIndex = 31;
			this.n.Text = "n!";
			this.n.UseVisualStyleBackColor = true;
			this.n.Click += new System.EventHandler(this.n_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(351, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 28);
			this.label2.TabIndex = 32;
			this.label2.Text = "MEMORY";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// memory
			// 
			this.memory.Location = new System.Drawing.Point(348, 198);
			this.memory.Name = "memory";
			this.memory.Size = new System.Drawing.Size(159, 122);
			this.memory.TabIndex = 33;
			this.memory.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 332);
			this.Controls.Add(this.memory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.n);
			this.Controls.Add(this.number0);
			this.Controls.Add(this.dot);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.equal);
			this.Controls.Add(this.mod);
			this.Controls.Add(this.expo10);
			this.Controls.Add(this.expo);
			this.Controls.Add(this.DEL);
			this.Controls.Add(this.expoy);
			this.Controls.Add(this.expo3);
			this.Controls.Add(this.expo2);
			this.Controls.Add(this.C);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.CE);
			this.Controls.Add(this.number3);
			this.Controls.Add(this.number2);
			this.Controls.Add(this.number1);
			this.Controls.Add(this.number6);
			this.Controls.Add(this.number5);
			this.Controls.Add(this.number4);
			this.Controls.Add(this.number9);
			this.Controls.Add(this.number8);
			this.Controls.Add(this.number7);
			this.Controls.Add(this.Mminus);
			this.Controls.Add(this.Mplus);
			this.Controls.Add(this.MC);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.history);
			this.Name = "Form1";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox history;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button MC;
		private System.Windows.Forms.Button Mplus;
		private System.Windows.Forms.Button Mminus;
		private System.Windows.Forms.Button number7;
		private System.Windows.Forms.Button number8;
		private System.Windows.Forms.Button number9;
		private System.Windows.Forms.Button number4;
		private System.Windows.Forms.Button number5;
		private System.Windows.Forms.Button number6;
		private System.Windows.Forms.Button number1;
		private System.Windows.Forms.Button number2;
		private System.Windows.Forms.Button number3;
		private System.Windows.Forms.Button CE;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button expo2;
		private System.Windows.Forms.Button expo3;
		private System.Windows.Forms.Button expoy;
		private System.Windows.Forms.Button DEL;
		private System.Windows.Forms.Button expo;
		private System.Windows.Forms.Button expo10;
		private System.Windows.Forms.Button mod;
		private System.Windows.Forms.Button equal;
		private System.Windows.Forms.Button divide;
		private System.Windows.Forms.Button dot;
		private System.Windows.Forms.Button number0;
		private System.Windows.Forms.Button n;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox memory;
	}
}

