/*
 * Created by SharpDevelop.
 * User: Sergio Ruiz
 * Date: 9/6/2019
 * Time: 9:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace act_3_casino
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.coin20Status = new System.Windows.Forms.Button();
			this.coin10Status = new System.Windows.Forms.Button();
			this.coin5Status = new System.Windows.Forms.Button();
			this.coin2Status = new System.Windows.Forms.Button();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(363, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "$10";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(420, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(46, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "$5";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(524, 34);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "$1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(472, 33);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(46, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "$2";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(13, 226);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(174, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Calculate Change $$";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(363, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 33);
			this.label1.TabIndex = 5;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(58, 239);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(218, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "3 Coins = $175 Earned";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(363, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Enter Coins:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(8, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(64, 11);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(50, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(120, 11);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(50, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Location = new System.Drawing.Point(176, 11);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(50, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox5.Location = new System.Drawing.Point(232, 11);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(50, 50);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			// 
			// treeView1
			// 
			this.treeView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView1.Location = new System.Drawing.Point(13, 91);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(122, 124);
			this.treeView1.TabIndex = 15;
			// 
			// coin20Status
			// 
			this.coin20Status.BackColor = System.Drawing.Color.Yellow;
			this.coin20Status.Cursor = System.Windows.Forms.Cursors.Default;
			this.coin20Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.coin20Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coin20Status.Location = new System.Drawing.Point(141, 91);
			this.coin20Status.Name = "coin20Status";
			this.coin20Status.Size = new System.Drawing.Size(46, 23);
			this.coin20Status.TabIndex = 16;
			this.coin20Status.Text = "$20";
			this.coin20Status.UseVisualStyleBackColor = false;
			this.coin20Status.Click += new System.EventHandler(this.ActivateCoin20);
			// 
			// coin10Status
			// 
			this.coin10Status.BackColor = System.Drawing.Color.Yellow;
			this.coin10Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.coin10Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coin10Status.Location = new System.Drawing.Point(141, 118);
			this.coin10Status.Name = "coin10Status";
			this.coin10Status.Size = new System.Drawing.Size(46, 23);
			this.coin10Status.TabIndex = 17;
			this.coin10Status.Text = "$10";
			this.coin10Status.UseVisualStyleBackColor = false;
			this.coin10Status.Click += new System.EventHandler(this.ActivateCoin10);
			// 
			// coin5Status
			// 
			this.coin5Status.BackColor = System.Drawing.Color.Yellow;
			this.coin5Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.coin5Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coin5Status.Location = new System.Drawing.Point(141, 147);
			this.coin5Status.Name = "coin5Status";
			this.coin5Status.Size = new System.Drawing.Size(46, 23);
			this.coin5Status.TabIndex = 18;
			this.coin5Status.Text = "$5";
			this.coin5Status.UseVisualStyleBackColor = false;
			this.coin5Status.Click += new System.EventHandler(this.ActivateCoin5);
			// 
			// coin2Status
			// 
			this.coin2Status.BackColor = System.Drawing.Color.Yellow;
			this.coin2Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.coin2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coin2Status.Location = new System.Drawing.Point(141, 176);
			this.coin2Status.Name = "coin2Status";
			this.coin2Status.Size = new System.Drawing.Size(46, 23);
			this.coin2Status.TabIndex = 19;
			this.coin2Status.Text = "$2";
			this.coin2Status.UseVisualStyleBackColor = false;
			this.coin2Status.Click += new System.EventHandler(this.ActivateCoin2);
			// 
			// buttonPlay
			// 
			this.buttonPlay.BackColor = System.Drawing.Color.Gray;
			this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPlay.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlay.Location = new System.Drawing.Point(64, 36);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(77, 34);
			this.buttonPlay.TabIndex = 20;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.UseVisualStyleBackColor = false;
			this.buttonPlay.Click += new System.EventHandler(this.Button6Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.coin20Status);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Controls.Add(this.coin2Status);
			this.panel1.Controls.Add(this.coin10Status);
			this.panel1.Controls.Add(this.coin5Status);
			this.panel1.Location = new System.Drawing.Point(363, 184);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(206, 288);
			this.panel1.TabIndex = 0;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(64, 255);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 24;
			this.button6.Text = "Withdraw All";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(94, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 16);
			this.label8.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 19);
			this.label7.TabIndex = 22;
			this.label7.Text = "Inactive =";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(43, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "Active =";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(94, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 16);
			this.label5.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 35);
			this.label4.TabIndex = 20;
			this.label4.Text = "Press the respective coin button to turn off or on";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(42, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Cost to Play: $17";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.buttonPlay);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel2.Location = new System.Drawing.Point(364, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(205, 82);
			this.panel2.TabIndex = 22;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkOrange;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.pictureBox5);
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(26, 132);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(294, 72);
			this.panel3.TabIndex = 23;
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
			// 
			// timer4
			// 
			this.timer4.Tick += new System.EventHandler(this.Timer4Tick);
			// 
			// timer5
			// 
			this.timer5.Tick += new System.EventHandler(this.Timer5Tick);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Black;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Broadway BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Gold;
			this.label10.Location = new System.Drawing.Point(26, 320);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(294, 102);
			this.label10.TabIndex = 24;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(26, 12);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(294, 88);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 25;
			this.pictureBox6.TabStop = false;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(58, 215);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(218, 23);
			this.label11.TabIndex = 26;
			this.label11.Text = "4 Diamonds = $500 Earned";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(58, 263);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(218, 23);
			this.label12.TabIndex = 27;
			this.label12.Text = "3 Apples = $101 Earned";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(58, 288);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(218, 23);
			this.label13.TabIndex = 28;
			this.label13.Text = "2 Cherries = $10 Earned";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gold;
			this.ClientSize = new System.Drawing.Size(594, 501);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "act_3_casino";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Timer timer5;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button coin2Status;
		private System.Windows.Forms.Button coin5Status;
		private System.Windows.Forms.Button coin10Status;
		private System.Windows.Forms.Button coin20Status;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
	

        private System.Windows.Forms.Button button6;
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
