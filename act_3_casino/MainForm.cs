/*
 * Created by SharpDevelop.
 * User: Sergio Ruiz
 * Date: 9/6/2019
 * Time: 9:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Timers;

namespace act_3_casino
{
    /*Sergio Ruiz Ruvalcaba
     *Act 3: Seminario de Algo.
     *Use a Greedy algorithm to calculate the change and simulate a casiono slot machine.
     */
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int won, invested;
	
		bool coin20, coin10, coin5, coin2;
		//int coin20, coin10, coin5, coin2;
		int credit;
		int change;
		Bitmap cherry, lemon, gold, diamond, apple ;
		List<Bitmap> slotImage;
		List<int> slotPos;
		int index, loop;
		int rn1, rn2, rn3, rn4, rn5;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			index=0;
			loop=0;
			credit=0;
			won=0;
			invested=0;
			slotImage = new List<Bitmap>();

            //cherry = new Bitmap("cherries.png");
            //lemon =new Bitmap("lemon.png");
            //slotImage.Add(cherry);
            slotImage.Add(cherry = new Bitmap("cherries.png"));
			slotImage.Add(lemon =new Bitmap("lemon.png"));
			slotImage.Add(diamond =new Bitmap("diamond.png"));
			slotImage.Add(gold =new Bitmap("gold.png"));
			slotImage.Add(apple =new Bitmap("apple.png"));
			label1.Text = "Credit: $";
			//buttonPlay.Enabled = false;
			
			pictureBox1.Image = slotImage[0];	
			pictureBox2.Image = slotImage[0];
			pictureBox3.Image = slotImage[0];	
			pictureBox4.Image = slotImage[0];	
			pictureBox5.Image = slotImage[0];		
			//
			coin20=true; 
			coin10=true;
			coin5=true; 
			coin2=true;
			change=0;
			

			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{			
			coinChange(10);			
		}
		void Button2Click(object sender, EventArgs e)
		{
			coinChange(5);
		}	
		void Button3Click(object sender, EventArgs e)
		{
			coinChange(1);
		}		
		void Button4Click(object sender, EventArgs e)
		{
			coinChange(2);
		}
		
		
		void coinChange(int c){
		/*	if(c==10){
				credit=credit+c;
			}
			else if(c==5){
				credit=credit+c;
			}
			else if(c==2){
				credit=credit+c;
			}
			else if(c==1){
				credit=credit+c;
			}*/
			credit=credit+c;
			invested=invested+c;
			label1.Text = string.Format("Credit: ${0}", credit);
			
			if(credit>16)
			buttonPlay.BackColor = Color.Gold;
			
			
			
		}
		
		
		
		
		void Button5Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
			treeView1.BeginUpdate();
			greedAlgo();
			treeView1.EndUpdate();
			
		}
		void greedAlgo(){
			int divisor=1;
			change=credit;
			//while(credit!=0){
			if(coin20){
				if(credit/20>=1){
					divisor = change/20;
					change = change - (20 * divisor);
					//treeView1.Nodes.Add("$20")).Nodes.Add(string.Format(* divisor.ToString());
					treeView1.Nodes.Add(string.Format("Coins of $20: {0} ",divisor ));
					
				}
			}
			if(coin10){
				//ELSE IF
				if(credit/10>=1){
					divisor = change/10;
					change = change - (10 * divisor);
					treeView1.Nodes.Add(string.Format("Coins of $10: {0} ",divisor ));
				}
			}
				
			if(coin5){
				if(credit/5>=1){
					divisor = change/5;
					change = change - (5 * divisor);
					treeView1.Nodes.Add(string.Format("Coins of $5: {0} ",divisor ));
				}
			}
			
			if(coin2){
				if(credit/2>=1){
					divisor = change/2;
					change = change - (2 * divisor);
					treeView1.Nodes.Add(string.Format("Coins of $2: {0} ",divisor ));
				}
			}
				
			
			treeView1.Nodes.Add(string.Format("Coins of $1: {0}  ", change ));
	
							
			
		
		}
		
		void Button6Click(object sender, EventArgs e)
		{ 
			label10.Text ="";
			if(credit>16){
				buttonPlay.BackColor = Color.Gold;
				credit= credit-17;
				label1.Text = string.Format("Credit: ${0}", credit);
				
				Random rn = new Random();
				rn1 = rn.Next(0, 5);
				rn2 = rn.Next(0, 5);
				rn3 = rn.Next(0, 5);
				rn4 = rn.Next(0, 5);
				rn5 = rn.Next(0, 5);
				
				slotPos = new List<int>();
				playGame();
			}
			if(credit<17)
				//buttonPlay.BackColor = Color.FromArgb(224, 224, 224);
				buttonPlay.BackColor = Color.Gray;
			
			
		}


        void playGame(){
		
			timer1.Start();//
	
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			index++;
			if(index>4){
			index=0;
			loop++;	
		}
		pictureBox1.Image = slotImage[index];
		if(loop==4 && index == rn1){
			slotPos.Add(index);
            index = 0;
			loop=0;
			timer1.Stop();
			timer2.Start();
	
		}else{
			
			timer1.Start();
		}
		
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			
			index++;
			if(index>4){
				index=0;
				loop++;	
			}
			pictureBox2.Image = slotImage[index];
			if(loop==4 && index == rn2){
				slotPos.Add(index);
				loop=0;
                index = 0;
                timer2.Stop();	
				timer3.Start();
			}else{
				timer2.Start();
			}
			
		}
		
			void Timer3Tick(object sender, EventArgs e)
		{
			
			index++;
			if(index>4){
				index=0;
				loop++;	
			}
			pictureBox3.Image = slotImage[index];
			if(loop==4 && index == rn3){
				slotPos.Add(index);
				loop=0;
                index = 0;
                timer3.Stop();	
				timer4.Start();
			}else{
				timer3.Start();
			}
			
			
		}
		void Timer4Tick(object sender, EventArgs e)
		{
			
			index++;
			if(index>4){
				index=0;
				loop++;	
			}
			pictureBox4.Image = slotImage[index];
			if(loop==4 && index == rn4){

				slotPos.Add(index);
				loop=0;
                index = 0;
                timer4.Stop();	
				timer5.Start();
			}else{
				timer4.Start();
			}
		}

        private void button6_Click(object sender, EventArgs e)
        {
        	/*
        	//110 - (508 -500)
        	invested= invested- (credit - won);
        	*/
        	invested=0;
        
        	won=0;
        	credit = 0;
            label1.Text = string.Format("Credit: $");
          
            label10.Text = "THANK YOU FOR PLAYING";
            treeView1.Nodes.Clear();
            
        }

        void Timer5Tick(object sender, EventArgs e)
		{
		
			index++;
			if(index>4){
				index=0;
				loop++;	
			}
			pictureBox5.Image = slotImage[index];
          //  MessageBox.Show(index.ToString());
            if (loop==4 && index == rn5){
                
                slotPos.Add(index);
				loop=0;
               // index = 0;
                timer5.Stop();// I dont think this is a definiate stop, because the anaimation still isnt done
                // or maybe it is a definate end, but all the recursive starts need to finish first
              //  pictureBox5.Image = slotImage[index];
               // MessageBox.Show(index.ToString());
                endGame();
				
			}else{
				timer5.Start();
			}
			
			
		}
		
		
		void endGame(){
            var m = slotPos.FindAll(s => s == 0);//cherries
            var n  = slotPos.FindAll(s => s == 1);//lemon
            var o = slotPos.FindAll(s => s == 2);//diamond
            var p = slotPos.FindAll(s => s == 3);//gold coin
            var q = slotPos.FindAll(s => s == 4);//apple

            int prize =0;
            //if (sumS == 3)
            if (o.Count().ToString() == "4")
            {// 2 DIAMONFS
                prize = 500;
                credit = credit + prize;
            }
            else if (p.Count().ToString() == "3"){// 3 GOLD C
                prize = 175;
                credit = credit + prize;
            }
            
            
            else if (q.Count().ToString() == "3")//3 apples
            {// 
                prize = 101;
                credit = credit + prize;
            }
            else if (m.Count().ToString() == "2")//2 cherries
            {// 
                prize = 10;
                credit = credit + prize;
            }
          

            // else
            //{
            if (prize>0)
                label10.Text = string.Format("YOU'V WON ${0}!", prize);
            else
            	label10.Text = string.Format("NO LUCK.");
            label1.Text = string.Format("Credit: ${0}", credit);
            if(credit>16)
            	buttonPlay.BackColor = Color.Gold;
            //abel10.Text = "NO LUCK! PLAY AGAIN!!";
            //}
            won = won+ prize;
      
        }
		
		void ActivateCoin20(object sender, EventArgs e)
		{
			if(coin20){
				coin20Status.BackColor = Color.Red;
				coin20=false;	
				
			}
			
			else{
				coin20Status.BackColor = Color.Yellow;
				coin20=true;
				
			}
			
		}
		
	
		void ActivateCoin10(object sender, EventArgs e)
		{
			if(coin10){
				coin10Status.BackColor = Color.Red;
				coin10=false;	
				
			}
			
			else{
				coin10Status.BackColor = Color.Yellow;
				coin10=true;
			}
		}
		

		void ActivateCoin5(object sender, EventArgs e)
		{
			if(coin5){
				coin5Status.BackColor = Color.Red;
				coin5=false;	
				
			}
			
			else{
				coin5Status.BackColor = Color.Yellow;
				coin5=true;
			}
		}
		
		void ActivateCoin2(object sender, EventArgs e)
		{
			if(coin2){
				coin2Status.BackColor = Color.Red;
				coin2=false;	
				
			}
			
			else{
				coin2Status.BackColor = Color.Yellow;
				coin2=true;
			}
		}
		
	}
}
