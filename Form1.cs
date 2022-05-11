using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIc_tac_Toe
{
    //This is an tic tac toe Ai. Its wins at everytime (:
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            
            InitializeComponent();
            
            AA.Text = " ";
            AB.Text = " ";
            AC.Text = " ";
            BA.Text = " ";
            BB.Text = " ";
            BC.Text = " ";
            CA.Text = " ";
            CB.Text = " ";
            CC.Text = " ";
           



        }

        private void AA_Click(object sender, EventArgs e)
        {
            Boolean gefahr3 = false;
          
        
            if (AA.Text == " ")
            {
                AA.Text = "X";
            }
            if (BA.Text == "X")
            {

                if (CA.Text == " ")
                {
                    CA.Text = "O";
                    gefahr3 = true;
                }
            }
            if (BB.Text == "X")
            {

                if (CC.Text == " ")
                {
                    CC.Text = "O";
                    gefahr3 = true;
                }
            }
            if (AC.Text == "X")
            {

                if (AB.Text == " ")
                {
                    AB.Text = "O";
                    gefahr3 = true;
                }
            }


            if (CC.Text == "X")
                {
                    
                    if (BB.Text == " ")
                    {
                        BB.Text = "O";
                    gefahr3 = true;
                }
                }

            if (gefahr3 == false)
            {

                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                                else
                                                {
                                                    if (AC.Text == " ")
                                                    {
                                                        AC.Text = "O";
                                                    }

                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }








            //testet ob er nicht setzen kann und setzt dann anders
            if (CB.Text == "X")
            {

            
            //test if win 
            if (AA.Text == "X" )
                {
                    


                    if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
                    //test if win 
                    if(CA.Text == "X")
                    {
                        if (CB.Text == "X")
                        {
                            if (CC.Text == "X")
                            {
                                textBox1.Text = "You Win";
                            }
                        }
                    }
                }
            }
        }


private void AB_Click(object sender, EventArgs e)
        {
            Boolean gefahr2 = false;
            Boolean gefahr96 = false;
            
            if (AB.Text == " ")
            {
                AB.Text = "X";
            }
           if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                        gefahr2 = true;
                    }
               }
            }
            if (AC.Text == "X")
            {
                
                
                    if (AA.Text == " ")
                    {
                        AA.Text = "O";
                        gefahr2 = true;
                    }
                
            }
            if (BB.Text == "X")
            {
              
                if (CB.Text == " ")
                {
                    CB.Text = "O";
                    gefahr2 = true;
                }


            }
         if(gefahr2 == false) { 
            if (BB.Text == " ")
            {
                BB.Text = "O";
            }

            else
            {
                if (AC.Text == " ")
                {
                    AC.Text = "O";
                }
                else
                {
                    if (BA.Text == " ")
                    {
                        BA.Text = "O";
                    }
                    else
                    {
                        if (BB.Text == " ")
                        {
                            BB.Text = "O";
                        }
                        else
                        {
                            if (BC.Text == " ")
                            {
                                BC.Text = "O";
                            }
                            else
                            {
                                if (CA.Text == " ")
                                {
                                    CA.Text = "O";
                                }
                                else
                                {
                                    if (CB.Text == " ")
                                    {
                                        CB.Text = "O";
                                    }
                                    else
                                    {
                                        if (CC.Text == " ")
                                        {
                                            CC.Text = "O";
                                        }
                                        else
                                        {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                          
                                            }
                                    }
                                }

                            }
                        }

                    }
                }
            }
           }

            //schaut nach gefahr





            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
            }
            //test if win 
            if (CA.Text == "X")
            {
                if (CB.Text == "X")
                {
                    if (CC.Text == "X")
                    {
                        textBox1.Text = "You Win";
                    }
                }
            }
        }

        private void AC_Click(object sender, EventArgs e)
        {

            Boolean gefahr2 = false;
            if (AC.Text == " ")
            {
                AC.Text = "X";
            }
            if (AC.Text == "X")
            {
                if (CA.Text == "X")
                {
                    gefahr2 = true;
                if (gefahr2 == true )
                {
                        if (BB.Text == " ")
                        {
                            BB.Text = "O";
                        }
                    }
            }
            }
            if (CC.Text == "X")
            {

                if (BC.Text == " ")
                {
                    gefahr2 = true;
                    BC.Text = "O";
                }
            }
            if (BC.Text == "X")
            {

                if (CC.Text == " ")
                {
                    gefahr2 = true;
                    CC.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (CA.Text == " ")
                {
                    gefahr2 = true;
                    CA.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (BA.Text == " ")
                {
                    gefahr2 = true;
                    BA.Text = "O";
                }
            }

            if (gefahr2 == false)
            {
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }
            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
            }
            if (AC.Text == "X")
            {
                if (BC.Text == "X")
                {
                    if (CC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
                //test if win 
                if (CA.Text == "X")
                {
                    if (CB.Text == "X")
                    {
                        if (CC.Text == "X")
                        {
                            textBox1.Text = "You Win";
                        }
                    }
                }
            }
        
    }

        private void BA_Click(object sender, EventArgs e)
        {
           Boolean gefahr95 = false;

            if (BA.Text == " ")
            {
                BA.Text = "X";
            }
            if(CB.Text == "X")
            {
               
                if (AB.Text == " ")
                {
                    AB.Text = "O";
                    gefahr95 = true;
                }
            }
            if (AA.Text == "X")
            {

                if (CA.Text == " ")
                {
                    CA.Text = "O";
                    gefahr95 = true;
                }
            }
            if (BB.Text == "X")
            {
               
                if (BC.Text == " ")
                {
                    BC.Text = "O";
                    gefahr95 = true;
                }
            }

            if (gefahr95 == false) { 
            
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }
            


            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
                //test if win 
                if (CA.Text == "X")
                {
                    if (CB.Text == "X")
                    {
                        if (CC.Text == "X")
                        {
                            textBox1.Text = "You Win";
                        }
                    }
                }
            }
        }

        public void BB_Click(object sender, EventArgs e)
        {
            Boolean gefahr1 = false;
            Boolean gefahr6 = false;
            Boolean gefahr7 = false;

            if (BB.Text == " ")
            {
                BB.Text = "X";
            }
            //guckt ob der diagonale weg genommen werden kann
   
            if (AA.Text == "X")
            {
                 
                if (CC.Text == " " )
                {
                    CC.Text = "O";
                    gefahr6 = true;
                }
            }
            if (AC.Text == "X")
            {

                if (CA.Text == " ")
                {
                    CA.Text = "O";
                    gefahr6 = true;
                }
            }
            if (CC.Text == "X")
            {

                if (AA.Text == " ")
                {
                    AA.Text = "O";
                    gefahr6 = true;
                }
            }
            if (BA.Text == "X")
            {
                
                if (CC.Text == " ")
                {
                    BC.Text = "O";
                    gefahr6 = true;
                }
            }
            if (CB.Text == "X")
            {

                if (AB.Text == " ")
                {
                    AB.Text = "O";
                    gefahr6 = true;
                }
            }
            if (AB.Text == "X")
            {

                if (CB.Text == " ")
                {
                    CB.Text = "O";
                    gefahr6 = true;
                }
            }
            if (CA.Text == "X")
            {

                if (AC.Text == " ")
                {
                    AC.Text = "O";
                    gefahr6 = true;
                }
            }
            if (AC.Text == "X")
            {

                if (BB.Text == " ")
                {
                    CA.Text = "O";
                    gefahr6 = true;
                }
            }
            if (BA.Text == "X")
            {

                if (BC.Text == " ")
                {
                    BC.Text = "O";
                    gefahr6 = true;
                }
            }
            //guckt ob der diagonale weg genommen werden kann
            if (gefahr6 == false)
            {

                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }




            //  test if win 

        }
    








    private void BC_Click(object sender, EventArgs e)
        {

            Boolean gefahr100 = false;
            if (BC.Text == " ")
            {
                BC.Text = "X";
            }
            if (AC.Text == "X")
            {

                if (CC.Text == " ")
                {
                    gefahr100 = true;
                    CC.Text = "O";
                }
            }

       if(gefahr100 == false) {
            if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                            else
                                            {
                                                if (AA.Text == " ")
                                                {
                                                    AA.Text = "O";
                                                }

                                            }

                                        }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }

            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }
            }
        }

        private void CA_Click(object sender, EventArgs e)
        {
            Boolean gefahr5 = false;


            if (CA.Text == " ")
            {
                CA.Text = "X";
            }
            if (AC.Text == "X")
            {
               
                if (BB.Text == " ")
                {
                    gefahr5 = true;
                    BB.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (AC.Text == " ")
                {
                    gefahr5 = true;
                    AC.Text = "O";
                }
            }
            if (CC.Text == "X")
            {

                if (CB.Text == " ")
                {
                    gefahr5 = true;
                    CB.Text = "O";
                }
            }
            if (BA.Text == "X")
            {

                if (AA.Text == " ")
                {
                    gefahr5 = true;
                    AA.Text = "O";
                }
            }
            if (gefahr5 == false)
            {
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                                else
                                                {
                                                    if (AA.Text == " ")
                                                    {
                                                        AA.Text = "O";
                                                    }

                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }

                }

            }

            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }

                //test if win 
                if (CA.Text == "X")
                {
                    if (CB.Text == "X")
                    {
                        if (CC.Text == "X")
                        {
                            textBox1.Text = "You Win";
                        }
                    }
                }
            }
        }

        private void CB_Click(object sender, EventArgs e)
        {
           Boolean gefahr7 = false;
      

            if (CB.Text == " ")
            {
                CB.Text = "X";
            }
            if (CA.Text == "X")
            {

                if (CC.Text == " ")
                {
                    gefahr7 = true;
                    CC.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (AB.Text == " ")
                {
                    gefahr7 = true;
                    AB.Text = "O";
                }
            }
            if (AB.Text == "X")
            {

                if (BB.Text == " ")
                {
                    gefahr7 = true;
                    BB.Text = "O";
                }
            }
            if (CC.Text == "X")
            {

                if (CA.Text == " ")
                {
                    gefahr7 = true;
                    CA.Text = "O";
                }
            }

            if (gefahr7 == false) { 
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                                else
                                                {
                                                    if (AA.Text == " ")
                                                    {
                                                        AA.Text = "O";
                                                    }

                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }

                }
            }


            if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }

                //test if win 
                if (CA.Text == "X")
                {
                    if (CB.Text == "X")
                    {
                        if (CC.Text == "X")
                        {
                            textBox1.Text = "You Win";
                        }
                    }
                }
            }
        }

        private void CC_Click(object sender, EventArgs e)
        {
            Boolean gefahr4;
            gefahr4 = false;
            if (AC.Text == "X")
            {

                if (BC.Text == " ")
                {
                    gefahr4 = true;
                    BC.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (AA.Text == " ")
                {
                    gefahr4 = true;
                    AA.Text = "O";
                }
            }
            if (CB.Text == "X")
            {

                if (CA.Text == " ")
                {
                    gefahr4 = true;
                    CA.Text = "O";
                }
            }
            if (BB.Text == "X")
            {

                if (AC.Text == " ")
                {
                    gefahr4 = true;
                    AC.Text = "O";
                }
            }
            if (CA.Text == "X")
            {

                if (CB.Text == " ")
                {
                    gefahr4 = true;
                    CB.Text = "O";
                }
            }
            if (CC.Text == " ")
            {
                CC.Text = "X";
            }
            if (AA.Text == "X")
            {
                gefahr4 = true;
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }
              
            }
            if (gefahr4 == false)
            {
                if (BB.Text == " ")
                {
                    BB.Text = "O";
                }

                else
                {
                    if (AC.Text == " ")
                    {
                        AC.Text = "O";
                    }
                    else
                    {
                        if (BA.Text == " ")
                        {
                            BA.Text = "O";
                        }
                        else
                        {
                            if (BB.Text == " ")
                            {
                                BB.Text = "O";
                            }
                            else
                            {
                                if (BC.Text == " ")
                                {
                                    BC.Text = "O";
                                }
                                else
                                {
                                    if (CA.Text == " ")
                                    {
                                        CA.Text = "O";
                                    }
                                    else
                                    {
                                        if (CB.Text == " ")
                                        {
                                            CB.Text = "O";
                                        }
                                        else
                                        {
                                            if (CC.Text == " ")
                                            {
                                                CC.Text = "O";
                                            }
                                            else
                                            {
                                                if (AB.Text == " ")
                                                {
                                                    AB.Text = "O";
                                                }
                                                else
                                                {
                                                    if (AA.Text == " ")
                                                    {
                                                        AA.Text = "O";
                                                    }

                                                }

                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }

                }


                //test if win 
                if (AA.Text == "X")
            {
                if (AB.Text == "X")
                {
                    if (AC.Text == "X")
                    {
                        textBox1.Text = "You Winn";
                    }
                }

                //test if win 
                if (CA.Text == "X")
                {
                    if (CB.Text == "X")
                    {
                        if (CC.Text == "X")
                        {
                            textBox1.Text = "You Win";
                        }
                    }
                }
            }
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //Feld leer
            AA.Text = " ";
            AB.Text = " ";
            AC.Text = " ";
            BA.Text = " ";
            BB.Text = " ";
            BC.Text = " ";
            CA.Text = " ";
            CB.Text = " ";
            CC.Text = " ";

        }

        }
    }






