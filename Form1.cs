using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splish_Splash_Decorators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string CustomerDetails, RoomDetails, EstDetails;

            //Maximizes the application to fit the users screen
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        //Closes the program outright
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double Length, Height, Area;
        //public variables declared before assignment of a value

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                //assigning values to public variables 
                Length = double.Parse(txtLength.Text);
                Height = double.Parse(txtHeight.Text);
                rtxtArea.Clear();
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                if (Length > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLength.Clear();
                }
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                if (Height > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeight.Clear();
                }
                    //else if the user enters a value 6 or less then the program will run as normal. 
                else
                {
                    //working out the area of a wall
                    Area = Length * Height;
                    //displaying the area in the appropriate textbox.
                    rtxtArea.AppendText(Area.ToString("F2"));
                }

            }
            catch (FormatException)
            {
                rtxtArea.Text = ("Please enter a number.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //These are cleared by clicking the clear button
            txtLength.Clear();
            txtHeight.Clear();
            rtxtArea.Clear();

        }
        double NumOFRooms;
        private void btnExc_Click(object sender, EventArgs e)
        {
            NumOFRooms = double.Parse(NumberOfRooms.Text);
            txtOverview_Rooms.AppendText(NumberOfRooms.Text);
            try
            {
                //try, if and catch are in place to make sure no letters or alphanumeric characters can be entered
                //this section of code calls forward the subroutines necessary for the code to function. This section of code is for the user to decide how many walls they require decorating. 
                if ((bool)rbtnTimesOnes.Checked == true)
                    x1();
                else if ((bool)rbtnTimesTwo.Checked == true)
                    x2();
                else if ((bool)rbtnTimesThree.Checked == true)
                    x3();
                else if ((bool)rbtnTimesFour.Checked == true)
                    x4();

            }



            catch (FormatException)
            //exception handler for data entered which cannot be converted using parse()
            {
                rtxtArea.Text = ("Numeric value only");
            }

            catch (OverflowException oEX)
            //exception handler for numbers outside that declared in the data type
            {
                rtxtArea.Text = ("Too large");
            }
            
        }


        double ans;
        //subroutine times 1 on radiobutton
        private void x1()
        {
            double x1 = double.Parse(rtxtArea.Text);

            ans = x1 * 1 * NumOFRooms;
            rtxtTotarea.Text = ans.ToString("F2");
            txtRoomSize.Text = ans.ToString("F2");
            

        }
        //subroutine time 2 on radiobutton                                                                       
        private void x2()
        {
            double x2 = double.Parse(rtxtArea.Text);

            ans = x2 * 2 * NumOFRooms;
            rtxtTotarea.Text = ans.ToString("F2");
            txtRoomSize.Text = ans.ToString("F2");
        }
        //subroutine times 3 on radiobutto                                                                         
        private void x3()
        {
            double x3 = double.Parse(rtxtArea.Text);

            ans = x3 * 3 * NumOFRooms;

            rtxtTotarea.Text = ans.ToString("F2");
            txtRoomSize.Text = ans.ToString("F2");
        }
        //subroutine times 4 on radiobutton                                                                         
        private void x4()
        {
            double x4 = double.Parse(rtxtArea.Text);

            ans = x4 * 4 * NumOFRooms;
            rtxtTotarea.Text = ans.ToString("F2");
            txtRoomSize.Text = ans.ToString("F2");
        }



        //clear all clears all the fields stated                                                                       
        private void btnClearall_Click(object sender, EventArgs e)
        {
            txtLengthD.Clear();
            txtLengthW.Clear();
            txtHeightD.Clear();
            txtHeightW.Clear();
            rtxtAreaW.Clear();
            rtxtAreaD.Clear();
        }
        //declaration of public variables
        double LengthD, HeightD, LengthW, HeightW, AnsDoor, AnsWindow;

        private void btnAccept2_Click(object sender, EventArgs e)
        {
            try
            {
                //assignment of values to variables
                LengthD = double.Parse(txtLengthD.Text);
                HeightD = double.Parse(txtHeightD.Text);
                LengthW = double.Parse(txtLengthW.Text);
                HeightW = double.Parse(txtHeightW.Text);
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                if (LengthD > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLengthD.Clear();
                }
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                else if (HeightD > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeightD.Clear();
                }
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                else if (LengthW > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLengthW.Clear();
                }
                //this if statement deals with the error handling. If the user enters a number larger than 6m then a error message will display and also clear the textbox.
                else if (HeightW > 6)
                {
                    MessageBox.Show("Please enter a value less than 6m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeightW.Clear();
                }
                else
                {
                    //area of the doors by multiplying them together
                    AnsDoor = LengthD * HeightD;
                    //area of the windows by multiplying them together 
                    AnsWindow = LengthW * HeightW;
                    //displaying the results of above to the appropriate textbox 
                    rtxtAreaD.Clear();
                    rtxtAreaW.Clear();
                    rtxtAreaD.AppendText(AnsDoor.ToString("F2"));
                    rtxtAreaW.AppendText(AnsWindow.ToString("F2")); 

                }


            }
            catch (FormatException)
            {
                //catch for if the user enters a letter instead of a numeric value
                txtLengthD.Text = ("Please enter a value");
                txtHeightD.Text = ("Please enter a value");
                txtLengthW.Text = ("Please enter a value");
                txtHeightW.Text = ("Please enter a value");
            }

        }


        private void btnAccept3_Click(object sender, EventArgs e)
        {
            try
            {
                //declaration of variable types 
                double AreaD, AreaW, NumD, NumW, TotAreaD, TotAreaW, TotArea, RoomArea, NewRoomArea;
                //assignment of values                                                                                                          
                AreaW = double.Parse(rtxtAreaW.Text);
                AreaD = double.Parse(rtxtAreaD.Text);
                //the numericUpDown component assignment
                NumD = double.Parse(NumUpDownDoor.Text);
                NumW = double.Parse(NumUpDownWindow.Text);
                RoomArea = double.Parse(rtxtTotarea.Text);
                //the calculation for multiplying the area by the number of doors to get the area of multiple doors
                //the calculation for multiplying the area by the number of windows to get the area of multiple windows
                TotAreaD = AreaD * NumD;
                TotAreaW = AreaW * NumW;
                TotArea = TotAreaD + TotAreaW;

                rtxtDWArea.AppendText(TotArea.ToString());
                //the total room area minus the doors and windows 
                NewRoomArea = RoomArea - TotArea;

                rtxtRoomAreaMinus.AppendText(NewRoomArea.ToString("F2"));
            }
            catch (FormatException)
            {
                rtxtRoomAreaMinus.Text = ("Please revise the estimate");
            }
        }


        double RoomArea, NumCoats, MattCost, VinylCost, SilkCost, PaintCost, NumTins;
        private void btnAccept4_Click(object sender, EventArgs e)
        {
            //Declaring the paint & number of tins locally 
            double RoomArea, NumCoats, MattCost, VinylCost, SilkCost, PaintCost, NumTins, LabourPrice, NumberOfHours, gloss, WithGloss1, CostBeforeTax, paintPr, WallpaperPrice;

            {
                //Assigning each paint type a price
                MattCost = 25.00;
                VinylCost = 26.00;
                SilkCost = 27.00;
                gloss = 25.00;
                //Assigning the room area and the number of coats their values
                RoomArea = double.Parse(rtxtRoomAreaMinus.Text);
                NumCoats = double.Parse(nupNumOfCoats.Text);
                //Math.Ceiling will round up the number of tins to avoid having half a tin
                NumTins = Math.Ceiling(RoomArea * NumCoats / 10d / 2.5d);
                NumberOfHours = RoomArea / 8;
                //WallpaperPrice = double.Parse(txtPriceOfWallpaper.Text);
                try
                {
                    if (chkbxPaint.Checked == true)
                    {
                        if (rbtnMatt.Checked)
                        {
                            //the if statement will execute the above if matt paint is checked
                            PaintCost = MattCost * NumTins;
                            LabourPrice = 35.00 * NumberOfHours + PaintCost;
                            CostBeforeTax = LabourPrice + PaintCost;
                            rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                            txtNumOfPaintTins.AppendText(NumTins.ToString());
                            txtHoursReq.AppendText(NumberOfHours.ToString("F2"));


                        }

                        else if (rbtnVinyl.Checked)
                        {
                            //this else if statement will execute the above if vinyl is checked
                            PaintCost = NumTins * VinylCost;
                            LabourPrice = 35.00 * NumberOfHours + PaintCost;
                            CostBeforeTax = LabourPrice + PaintCost;
                            rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                            txtNumOfPaintTins.AppendText(NumTins.ToString());
                            txtHoursReq.AppendText(NumberOfHours.ToString("F2"));


                        }

                        else if (rbtnSilk.Checked)
                        {
                            //this else if statement will execute the above if silk is checked
                            PaintCost = NumTins * SilkCost;
                            LabourPrice = 35.00 * NumberOfHours + PaintCost;
                            CostBeforeTax = LabourPrice + PaintCost;
                            rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                            txtNumOfPaintTins.AppendText(NumTins.ToString());
                            txtHoursReq.AppendText(NumberOfHours.ToString("F2"));
                        }
                        else
                        {

                        }
                    }

                }

                catch (FormatException)
                {
                    rtxtPaintCost.Text = ("Please revise the estimation process again");
                }
            }
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            //The 'Help Button' message that will be displayed
            MessageBox.Show("To find out what a certain object in the program does, highlight the object to see further instructions", "Help messsage",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Tooltip
        private void MouseEnterHelp(object sender, EventArgs e)
        {
            lblExcHelp.Text = "Clicking this will process the chosen" + Environment.NewLine + " number of walls";
        }
        //Tooltip
        private void MouseLeaveHelp(object sender, EventArgs e)
        {
            lblExcHelp.Text = "";
        }
        //Tooltip
        private void MouseEnterAcptHelp(object sender, EventArgs e)
        {
            lblAcptHelp.Text = "Clicking this will calculate the" + Environment.NewLine + " Area.";
        }
        //Tooltip
        private void MouseLeaveAcptHelp(object sender, EventArgs e)
        {
            lblAcptHelp.Text = "";
        }
        //Tooltip
        private void MouseEnterCfrmHelp(object sender, EventArgs e)
        {
            lblCfm1Help.Text = "Clicking this will accept all the entered values" + Environment.NewLine + " and transfer them all to the next part.";
        }
        //Tooltip
        private void MouseLeaveCfrmHelp(object sender, EventArgs e)
        {
            lblCfm1Help.Text = "";
        }
        //Tooltip
        private void MouseEnterClsHelp(object sender, EventArgs e)
        {
            lblCloseHelp.Text = "Clicking this will close the program.";
        }
        //Tooltip
        private void MouseLeaveClsHelp(object sender, EventArgs e)
        {
            lblCloseHelp.Text = "";
        }
        //Tooltip
        private void MouseEnterAcpt2Help(object sender, EventArgs e)
        {
            lblAcpt2Help.Text = "Clicking this will calculate the area of the doors and windows.";
        }
        //Tooltip
        private void MouseLeaveAcpt2Help(object sender, EventArgs e)
        {
            lblAcpt2Help.Text = "";
        }
        //Tooltip
        private void MouseEnterClearAllHelp(object sender, EventArgs e)
        {
            lblClearAllHelp.Text = "This will clear all entries";
        }
        //Tooltip
        private void MouseLeaveClearAllHelp(object sender, EventArgs e)
        {
            lblClearAllHelp.Text = "";
        }
        //Tooltip
        private void MouseEnterWallpaperHelp(object sender, EventArgs e)
        {
            lblWallpaperHelp.Text = "Enter an amount for wallpaper.";
        }
        //Tooltip
        private void MouseLeaveWallpaperHelp(object sender, EventArgs e)
        {
            lblWallpaperHelp.Text = "";
        }
        //this section of code transfers all of the relevant information to the next form, ready for printing. 
        String CustomerDetails, EstDetails;
        //the string variables are declared publically so that they can be recognised by the next form. There numerous values within these string that all get displayed once filled in.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CustomerDetails = "\n \n \n Job Number: " + txtJobNum.Text + "\n \n \n Customer Name: " + txtCustName.Text + "\n \n \n Street Name: " + txtStreetName.Text + "\n \n \n City/Town: " + txtCityTown.Text + "\n \n \n Postcode: " + txtPostCode.Text + "\n \n \n Contact Number: " + txtContactNum.Text + "\n \n \n Date Of estimate:" + txtDate.Text;
            EstDetails = "\n \n \n Number Of Rooms: " + NumberOfRooms.Text + "\n \n \n Room size (m sq):  " + txtRoomSize.Text + "\n \n \n Hours required:  " + txtHoursReq.Text + "\n \n \n Number of paint tins:  " + txtNumOfPaintTins.Text + "\n \n \n 5% Discount amount:  £" + txtDiscount5.Text + "\n \n \n 10% Discount amount:  £" + txtDiscount10.Text + "\n \n \n Job Price with discount(s):  £" + txtJobPriceWDis.Text + "\n \n \n Tax percentage %:   " + txtTaxPer.Text + "%" + "\n \n \n Overall cost:  £" + txtPriceBeforeDis.Text;
        //this code hides the current form and then declares the new form, Output.cs in this case. It then transfers all of the data to the next form by taking the two string variables. 
            this.Hide();
            Output frm = new Output(CustomerDetails, EstDetails);
            //this shows the new form
            frm.Show();
            
         

        }

        //Tooltip
        private void MouseEnterAcpt3Help(object sender, EventArgs e)
        {
            lblAcpt3Help.Text = "Clicking this will accept your window and door areas.";
        }
        //Tooltip
        private void MouseLeaveAcpt3Help(object sender, EventArgs e)
        {
            lblAcpt3Help.Text = "";
        }
        //Tooltip
        private void MouseEnterAcpt4Help(object sender, EventArgs e)
        {
            lblAcpt4Help.Text = "Clicking this will confirm your paint and number of coats.";
        }
        //Tooltip
        private void MouseLeaveAcpt4Help(object sender, EventArgs e)
        {
            lblAcpt4Help.Text = "";
        }
        //Tooltip
        private void MouseEnterRoomSizeHelp(object sender, EventArgs e)
        {
            lblRoomSizeTxtHelp.Text = "Nothing needs to be entered here.";
        }
        //Tooltip
        private void MouseLeaveRoomSizeHelp(object sender, EventArgs e)
        {
            lblRoomSizeTxtHelp.Text = "";
        }

        //this button clears the Paint cost textbox and the number of tins. 
        private void btnClearAll3_Click(object sender, EventArgs e)
        {
            rtxtPaintCost.Clear();
            txtNumOfPaintTins.Clear();
        }
        //this button clears the stated textboxes
        private void btnFinClear_Click(object sender, EventArgs e)
        {
            txtHoursReq.Clear();
            txtHRate.Clear();                                                                                                                                
        }




        double hours, rate, Paint, HoursCost, FinalPrice;
        private void PaintSub()
        {
            //assigning the hours to the corresponding textbox
            hours = double.Parse(txtHoursReq.Text);
            //assigning the rate for the work to the corresponding textbox                                                           
            rate = double.Parse(txtHRate.Text);
            //assigning the paint to the corresponding textbox                                                               
            Paint = double.Parse(rtxtPaintCost.Text);                                                                       
            HoursCost = hours * rate;
            //this is for the final price of labour and paint (Before tax and discounts)
            FinalPrice = HoursCost + Paint;                                                                                
            //displays the final price to the string
            rtxtLabourExcTax.AppendText(FinalPrice.ToString());


        }






        double WallpaperFinal, WallPaperCost;
        //subroutine for wallpaper
        private void WallPaperSub()
        {
            //assigning the hours to the corresponding textbox
            hours = double.Parse(txtHoursReq.Text);                                                                         
            rate = double.Parse(txtHRate.Text);
            WallPaperCost = double.Parse(txtPriceOfWallpaper.Text);
            WallpaperFinal = WallPaperCost + hours * rate;
            // displays the wallpaper price in the correct string 
            rtxtLabourExcTax.AppendText(WallpaperFinal.ToString());
        }

        //this is for the first help button. it displays two messageboxes one after the other
        private void btnPanel1Help_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("Click the 'generate' button to get a job number",
                "Help message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            DialogResult r2 = MessageBox.Show("The following fields require you to enter more details about yourself. Look at the label on the left to see what you need to enter.",
           "Help message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        //this button is for randomly selecting a job number. 
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random Generator = new Random();
            //this code is responsible for cycling between 0 and 150 different numbers randomly. 
            int Gen = Generator.Next(0, 250);
            txtJobNum.Text = Gen.ToString();
        }
     
       
        //this is for the second panel help messaging. it displays a message advising the user on the correct course of action for that section. 
        private void btnPanel2Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this section please enter the measurements for one wall. When that wall has been calculated please choose the number of walls you require painting.", "Help Message",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //this is for the third panel help messaging. it displays a message advising the user on the correct course of action for that section. 
        private void btnPanel3Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this section you need to enter the measurements for both the doors and windows (In metres). Then choose the number of doors and windows needed for the application to calculate the area of doors and windows. The application will then subtract the total area of the doors and windows from the room area to give a new room area without the doors and windows.",
                "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //this is for the fourth panel help messaging. it displays a message advising the user on the correct course of action for that section. 
        private void btnPanel4Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this section you are required to choose either paint or wallpaper. This application does not allow both to be selected.", "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //this code is for the error handling. The user cannot have a door or window larger or wider than a wall. 
        private void txtLengthW_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Lengthw, length;
                Lengthw = double.Parse(txtLengthW.Text);
                length = double.Parse(txtLength.Text);
                //this compares the two textboxes values and reacts according to the two different outcomes. 
                if (Lengthw >= length)
                {
                    MessageBox.Show("You can't have a window wider than a wall.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLengthW.Clear();
                }
            }
            catch (FormatException)
            {
                txtLengthW.Clear();
            }
        }


        //this is for the fifth panel help messaging. it displays a message advising the user on the correct course of action for that section. 
        private void btnPanel5Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter an amount for the wallpaper.", "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //this section is for adding gloss to the paint cost. 
        double Gloss, WithGloss; 
        private void chkbxGloss_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkbxGloss.Checked == true)
                {
                    Gloss = 25.00;
                    PaintCost = Double.Parse(rtxtPaintCost.Text);
                    WithGloss = Gloss + PaintCost;
                    rtxtPaintCost.Clear();
                    rtxtPaintCost.AppendText(WithGloss.ToString());
                    rtxtLabourExcTax.AppendText(WithGloss.ToString());
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please choose the main type of paint you are wanting to use.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //this section is for the value added tax. it calculates the VAT.
        double VAT, CostVAT;
        double FnPrice;
        private void btnCfrmFinal_Click(object sender, EventArgs e)
        {
            try
            {
                VAT = double.Parse(txtTaxPer.Text);
                CostVAT = double.Parse(txtJobPriceWDis.Text);

                FnPrice = (CostVAT / VAT) + CostVAT;
                txtPriceBeforeDis.Clear();
                txtPriceBeforeDis.AppendText(FnPrice.ToString("F2"));
            }
            //if the user enters a letter, this catch will display the message. 
            catch (FormatException)
            {
                MessageBox.Show("Numeric value only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //this section is for the checkbox asking the user if they require paint.
        private void chkbxPaint_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkbxPaint.Checked)
                {
                    //assigning the paint to the corresponding textbox
                    Paint = double.Parse(rtxtPaintCost.Text);                                                                       
                    HoursCost = hours * rate;

                    PaintSub();

                    FinalPrice = HoursCost + Paint;                                                                                 
                    //this is for the final price of labour and paint (Before tax and discounts)
                    rtxtLabourExcTax.AppendText(FinalPrice.ToString());
                }
                else
                {
                    MessageBox.Show("Please choose either paint or wallpaper.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please choose the paint option if you are requiring it", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid contact number.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Lngth = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Hght = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtLengthD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char lnghD = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtHeightD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char hghtD = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtHeightW_KeyPress(object sender, KeyPressEventArgs e)
        {
            char hghtW = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtAreaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char areaD = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtAreaW_KeyPress(object sender, KeyPressEventArgs e)
        {
            char areaW = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Warea = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtTotarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Totarea = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtPaintCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char PntCst = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void txtRoomSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char RmSz = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //if the user enters a letter in the place of a numeric value then this will display a message.
        private void rtxtDWArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DW = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //this code was borrowed from the internet. See documentation for reference. 
        }
        //help message for the sixth help button. 
        private void btnPanel6Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this section most of the textboxes will be automatically filled as you progress throughout the estimate. You do not need to enter anything in the textboxes. The only textbox(s) that require you to enter a value is the 'Hourly rate' and the VAT percentage.",
                "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        //this code monitors the height of the windows next to the height of the wall. 
        private void txtHeightW_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Heightw, height;
                Heightw = double.Parse(txtHeightW.Text);
                height = double.Parse(txtHeight.Text);
                //if the window height is equal to or greater then this message will display. 
                if (Heightw >= height)
                {
                    MessageBox.Show("You can't have a window wider than a wall.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeightW.Clear();
                }
            }
            catch (FormatException)
            {
                txtHeightW.Clear();
            }
        }
        //this code monitors the length of the doors next to the height of the wall.
        private void txtLengthD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Lengthd, Length;
                Lengthd = double.Parse(txtLengthD.Text);
                Length = double.Parse(txtLength.Text);
                //if the length of the door is longer or equal to the length of the wall then this message will display. 
                if (Lengthd >= Length)
                {
                    MessageBox.Show("You can't have a door wider than a wall.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLengthD.Clear();
                }
            }
            catch (FormatException)
            {
                txtLengthD.Clear();
            }
        }
        //this code is for the height of the door. it makes sure that there cant be a door equal to or larger than the size of the wall. 
        private void txtHeightD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double heightD, height;
                heightD = double.Parse(txtHeightD.Text);
                height = double.Parse(txtHeight.Text);

                if (heightD >= height)
                {
                    MessageBox.Show("You can't have a door higher than a wall.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeightD.Clear();
                }
            }
            catch (FormatException)
            {
                txtHeightD.Clear();
            }
        }
        //this section of code is for the wallpaper, it runs if the wallpaper checkbox has been ticked 
        private void btnWallPaperCnfm_Click(object sender, EventArgs e)
        {
                if (chkbxWallpaper.Checked == true)
                {

                    double WallpaperPr, Wallpaper_Labour, NumberOfH, labour_Rate;
                    if (chkbxWallpaper.Checked)
                    {
                        WallpaperPr = double.Parse(txtPriceOfWallpaper.Text);
                        RoomArea = double.Parse(rtxtRoomAreaMinus.Text);
                        labour_Rate = double.Parse(txtHourly_Rate.Text);
                        //works out the number of hours
                        NumberOfH = RoomArea / 8;
                        //works out the labour rate
                        Wallpaper_Labour = labour_Rate * NumberOfH + WallpaperPr;
                        //displays the necessary code to the appropriate string. 
                        txtHoursReq.AppendText(NumberOfH.ToString());
                        txtHRate.AppendText(labour_Rate.ToString("F2")); 
                        rtxtLabourExcTax.AppendText(Wallpaper_Labour.ToString("F2"));

                    }
                }


         }
        
        //this make sure that one of the checkboxes can be checked at a time
        private void chkbxWallpaper_CheckedChanged(object sender, EventArgs e)
        {
            chkbxPaint.Checked = !chkbxWallpaper.Checked;
        }



        //this make sure that one of the checkboxes can be checked at a time
        private void Tr(object sender, EventArgs e)
        {            
                chkbxWallpaper.Checked = !chkbxPaint.Checked;
        }

        private void btnAcceptAll_Click(object sender, EventArgs e)
        {
            if (chkbxPaint.Checked == true)
            {
                //Declaring the paint & number of tins locally 
                double RoomArea, NumCoats, MattCost, VinylCost, SilkCost, PaintCost, NumTins, LabourPrice, NumberOfHours, gloss, WithGloss1, CostBeforeTax, paintPr, WallpaperPrice;

                {
                    //Assigning each paint type a price
                    MattCost = 25.00;
                    VinylCost = 26.00;
                    SilkCost = 27.00;
                    gloss = 25.00;
                    //Assigning the room area and the number of coats their values
                    RoomArea = double.Parse(rtxtRoomAreaMinus.Text);
                    NumCoats = double.Parse(nupNumOfCoats.Text);
                    //Math.Ceiling will round up the number of tins to avoid having half a tin
                    NumTins = Math.Ceiling(RoomArea * NumCoats / 10d / 2.5d);
                    NumberOfHours = RoomArea / 8;
                    
                    //WallpaperPrice = double.Parse(txtPriceOfWallpaper.Text);
                    try
                    {
                        if (chkbxPaint.Checked == true)
                        {
                            if (rbtnMatt.Checked)
                            {
                                //the if statement will execute the above if matt paint is checked
                                PaintCost = MattCost * NumTins;
                                LabourPrice = 35.00 * NumberOfHours + PaintCost;
                                CostBeforeTax = LabourPrice + PaintCost;
                                rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                                txtNumOfPaintTins.AppendText(NumTins.ToString());
                                txtHoursReq.AppendText(NumberOfHours.ToString("F2"));
                                MessageBox.Show("Please now enter the hourly rate of the job. This can be done by looking in the 'estimate overview' section and entering an amount.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



                            }

                            else if (rbtnVinyl.Checked)
                            {
                                //this else if statement will execute the above if vinyl is checked
                                PaintCost = NumTins * VinylCost;
                                LabourPrice = 35.00 * NumberOfHours + PaintCost;
                                CostBeforeTax = LabourPrice + PaintCost;
                                rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                                txtNumOfPaintTins.AppendText(NumTins.ToString());
                                txtHoursReq.AppendText(NumberOfHours.ToString("F2"));
                                MessageBox.Show("Please now enter the hourly rate of the job. This can be done by looking in the 'estimate overview' section and entering an amount.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                            }

                            else if (rbtnSilk.Checked)
                            {
                                //this else if statement will execute the above if silk is checked
                                PaintCost = NumTins * SilkCost;
                                LabourPrice = 35.00 * NumberOfHours + PaintCost;
                                CostBeforeTax = LabourPrice + PaintCost;
                                rtxtPaintCost.AppendText(PaintCost.ToString("F2"));
                                txtNumOfPaintTins.AppendText(NumTins.ToString());
                                txtHoursReq.AppendText(NumberOfHours.ToString("F2"));
                                MessageBox.Show("Please now enter the hourly rate of the job. This can be done by looking in the 'estimate overview' section and entering an amount.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }

                    catch (FormatException)
                    {
                        rtxtPaintCost.Text = ("Please revise the estimation process again");
                    }
                   
                    if (chkbxWallpaper.Checked == true)
                    {

                        double WallpaperPr, Wallpaper_Labour, NumberOfH;
                        if (chkbxWallpaper.Checked)
                        {
                            WallpaperPr = double.Parse(txtPriceOfWallpaper.Text);
                            NumberOfH = RoomArea / 8;
                            Wallpaper_Labour = 35.00 * NumberOfH + WallpaperPr;

                            rtxtLabourExcTax.AppendText(Wallpaper_Labour.ToString("F2"));

                        }
                    }

                }
            }
        }

       
        //this makes sure the hourly rate textbox stays empty.
        private void txtHRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char HR = e.KeyChar;
            //if the user enters a letter or a number then the messagebox will display 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //this code is for the price and discounts. 
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //this part of the code is for assigning and declaring variables.
            double LabourRate, MaterialPaint, LabourHours, Ans, NumberRooms, MaterialWallpaper, Discount1, Discount2, JobPriceWDis, TotalPrice;
            NumberRooms = double.Parse(NumberOfRooms.Text);
            LabourRate = double.Parse(txtHRate.Text);
            LabourHours = double.Parse(txtHoursReq.Text);
       
            Discount1 = 0;
            Discount2 = 0;

            if (chkbxPaint.Checked)
            {
                MaterialPaint = double.Parse(rtxtPaintCost.Text);
                Ans = LabourRate * LabourHours + MaterialPaint;
                rtxtLabourExcTax.AppendText(Ans.ToString("F2"));
                rtxtLabourExcTax.Clear();
            }
            else
            {
                MaterialWallpaper = double.Parse(txtPriceOfWallpaper.Text);
                Ans = LabourRate * LabourHours + MaterialWallpaper;
                rtxtLabourExcTax.AppendText(Ans.ToString("F2"));
                rtxtLabourExcTax.Clear();
            }

            if (NumberRooms == 3)
            {
                Discount1 = Ans / 20;
            }
            if (Ans - Discount1 >= 250)
            {
                Discount2 = (Ans - Discount1) / 10;
            }

            txtDiscount5.Text = Discount1.ToString("F2");
            txtDiscount10.Text = Discount2.ToString("F2");

            JobPriceWDis = Ans - Discount1 - Discount2;
            txtJobPriceWDis.Text = JobPriceWDis.ToString("F2");
            try
            {
                TotalPrice = JobPriceWDis + ((JobPriceWDis / 100) * double.Parse(txtTaxPer.Text));
            }
            catch
            {
                TotalPrice = 0;
            }
            txtPriceBeforeDis.Text = TotalPrice.ToString("F2");
        }




        //start of attention messaging


        private void txtNumOfPaintTins_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Tins = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtHoursReq_KeyPress(object sender, KeyPressEventArgs e)
        {
            char HR = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rtxtLabourExcTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char LAbour = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Dis5 = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Dis10 = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtJobPriceWDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char WDis = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Tx = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPriceBeforeDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char BDis = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPriceOfWallpaper_KeyPress(object sender, KeyPressEventArgs e)
        {
            char WP = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtHourly_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char hrlR = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please leave blank", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       
      

      

       
    }
}	  
	
            



      
    
