//N9350
//program 2
//Due 3/5/19
//CIS-199-75
//calculates the tax due based on income and filing status
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const int SINGLE_1 = 9700;     //constants for single filer tax thresholds
            const int SINGLE_2 = 39475;
            const int SINGLE_3 = 84200;
            const int SINGLE_4 = 160725;
            const int SINGLE_5 = 204100;
            const int SINGLE_6 = 510300;
            const int JOINT_1 = 19400;    //constants for married joint filer thresholds
            const int JOINT_2 = 78950;
            const int JOINT_3 = 168400;
            const int JOINT_4 = 321450;
            const int JOINT_5 = 408200;
            const int JOINT_6 = 612350;
            const int HEAD_1 = 13850;  // head of household threshholds
            const int HEAD_2 = 52850;
            const int HEAD_3 = 84200;
            const int HEAD_4 = 160700;
            const int HEAD_5 = 204100;
            const int HEAD_6 = 510300;
            const int SEPERATE_1 = 9700; // married seperate filer thresholds
            const int SEPERATE_2 = 39475;
            const int SEPERATE_3 = 84200;
            const int SEPERATE_4 = 160725;
            const int SEPERATE_5 = 204100;
            const int SEPERATE_6 = 306175;
            const double BRACKET_1 = 0.10; //constants for each tax bracket
            const double BRACKET_2 = 0.12;
            const double BRACKET_3 = 0.22;
            const double BRACKET_4 = 0.24;
            const double BRACKET_5 = 0.32;
            const double BRACKET_6 = 0.35;
            const double BRACKET_7 = 0.37;

            int income; // stores the input income value

            double marginTax; // stores the marignal tax value for the approrpiate bracket
            double tax; //store the amount of dax due

            if (int.TryParse(incomeText.Text, out income))
            {
                if (singleButton.Checked)
                {
                    if (income >= SINGLE_6)
                    {
                        marginTax = BRACKET_7;
                        tax = (income - SINGLE_6) * BRACKET_7
                            + (SINGLE_6 - SINGLE_5) * BRACKET_6
                            + (SINGLE_5 - SINGLE_4) * BRACKET_5
                            + (SINGLE_4 - SINGLE_3) * BRACKET_4
                            + (SINGLE_3 - SINGLE_2) * BRACKET_3
                            + (SINGLE_2 - SINGLE_1) * BRACKET_2
                            + (SINGLE_1 * BRACKET_1);
                        marginText.Text = ($"{marginTax:P}");
                        dueTaxText.Text = ($"{tax:C}");
                    }
                    else
                    {
                        if (income > SINGLE_5 && income < SINGLE_6)
                        {

                            marginTax = BRACKET_6;
                            tax = (income - SINGLE_5) * BRACKET_6
                                + (SINGLE_5 - SINGLE_4) * BRACKET_5
                                + (SINGLE_4 - SINGLE_3) * BRACKET_4
                                + (SINGLE_3 - SINGLE_2) * BRACKET_3
                                + (SINGLE_2 - SINGLE_1) * BRACKET_2
                                + (SINGLE_1 * BRACKET_1);
                            marginText.Text = ($"{marginTax:P}");
                            dueTaxText.Text = ($"{tax:C}");
                        }
                        else
                        {
                            if (income > SINGLE_4 && income < SINGLE_5)
                            {
                                marginTax = BRACKET_5;
                                tax = (income - SINGLE_4) * BRACKET_5
                                    + (SINGLE_4 - SINGLE_3) * BRACKET_4
                                    + (SINGLE_3 - SINGLE_2) * BRACKET_3
                                    + (SINGLE_2 - SINGLE_1) * BRACKET_2
                                    + (SINGLE_1 * BRACKET_1);
                                marginText.Text = ($"{marginTax:P}");
                                dueTaxText.Text = ($"{tax:C}");
                            }
                            else
                            {
                                if (income > SINGLE_3 && income < SINGLE_4)
                                {

                                    marginTax = BRACKET_4;
                                    tax = (income - SINGLE_3) * BRACKET_4
                                        + (SINGLE_3 - SINGLE_2) * BRACKET_3
                                        + (SINGLE_2 - SINGLE_1) * BRACKET_2
                                        + (SINGLE_1 * BRACKET_1);
                                    marginText.Text = ($"{marginTax:P}");
                                    dueTaxText.Text = ($"{tax:C}");
                                }
                                else
                                {
                                    if (income > SINGLE_2 && income < SINGLE_3)
                                    {
                                        marginTax = BRACKET_3;
                                        tax = (income - SINGLE_2) * BRACKET_3
                                            + (SINGLE_2 - SINGLE_1) * BRACKET_2
                                            + (SINGLE_1 * BRACKET_1);

                                        marginText.Text = ($"{marginTax:P}");
                                        dueTaxText.Text = ($"{tax:C}");
                                    }
                                    else
                                    {
                                        if (income > SINGLE_1 && income < SINGLE_2)
                                        {
                                            marginTax = BRACKET_2;
                                            tax = (income - SINGLE_1) * BRACKET_2
                                                + (SINGLE_1 * BRACKET_1);

                                            marginText.Text = ($"{marginTax:P}");
                                            dueTaxText.Text = ($"{tax:C}");
                                        }
                                        else
                                        {
                                            if (income <= SINGLE_1)
                                            {
                                                marginTax = BRACKET_1;
                                                tax = income * BRACKET_1;
                                                marginText.Text = ($"{marginTax:P}");
                                                dueTaxText.Text = ($"{tax:C}");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if(jointButton.Checked)
                    {
                        if (income >= JOINT_6)
                        {

                            marginTax = BRACKET_7;
                            tax = (income - JOINT_6) * BRACKET_7
                                + (JOINT_6 - JOINT_5) * BRACKET_6
                                + (JOINT_5 - JOINT_4) * BRACKET_5
                                + (JOINT_4 - JOINT_3) * BRACKET_4
                                + (JOINT_3 - JOINT_2) * BRACKET_3
                                + (JOINT_2 - JOINT_1) * BRACKET_2
                                + (JOINT_1 * BRACKET_1);
                            marginText.Text = ($"{marginTax:P}");
                            dueTaxText.Text = ($"{tax:C}");
                        }
                        else
                        {
                            if (income > JOINT_5 && income < JOINT_6)
                            {

                                marginTax = BRACKET_6;
                                tax = (income - JOINT_5) * BRACKET_6
                                    + (JOINT_5 - JOINT_4) * BRACKET_5
                                    + (JOINT_4 - JOINT_3) * BRACKET_4
                                    + (JOINT_3 - JOINT_2) * BRACKET_3
                                    + (JOINT_2 - JOINT_1) * BRACKET_2
                                    + (JOINT_1 * BRACKET_1);
                                marginText.Text = ($"{marginTax:P}");
                                dueTaxText.Text = ($"{tax:C}");
                            }
                            else
                            {
                                if (income > JOINT_4 && income < JOINT_5)
                                {
                                    marginTax = BRACKET_5;
                                    tax = (income - JOINT_4) * BRACKET_5
                                        + (JOINT_4 - JOINT_3) * BRACKET_4
                                        + (JOINT_3 - JOINT_2) * BRACKET_3
                                        + (JOINT_2 - JOINT_1) * BRACKET_2
                                        + (JOINT_1 * BRACKET_1);
                                    marginText.Text = ($"{marginTax:P}");
                                    dueTaxText.Text = ($"{tax:C}");
                                }
                                else
                                {
                                    if (income > JOINT_3 && income < JOINT_4)
                                    {

                                        marginTax = BRACKET_4;
                                        tax = (income - JOINT_3) * BRACKET_4
                                            + (JOINT_3 - JOINT_2) * BRACKET_3
                                            + (JOINT_2 - JOINT_1) * BRACKET_2
                                            + (JOINT_1 * BRACKET_1);

                                        marginText.Text = ($"{marginTax:P}");
                                        dueTaxText.Text = ($"{tax:C}");
                                    }
                                    else
                                    {
                                        if (income > JOINT_2 && income < JOINT_3)
                                        {
                                            marginTax = BRACKET_3;
                                            tax = (income - JOINT_2) * BRACKET_3
                                                + (JOINT_2 - JOINT_1) * BRACKET_2
                                                + (JOINT_1 * BRACKET_1);

                                            marginText.Text = ($"{marginTax:P}");
                                            dueTaxText.Text = ($"{tax:C}");
                                        }
                                        else
                                        {
                                            if (income > JOINT_1 && income < JOINT_2)
                                            {
                                                marginTax = BRACKET_2;
                                                tax = (income - JOINT_1) * BRACKET_2
                                                    + (JOINT_1 * BRACKET_1);

                                                marginText.Text = ($"{marginTax:P}");
                                                dueTaxText.Text = ($"{tax:C}");
                                            }
                                            else
                                            {
                                                if (income <= JOINT_1)
                                                {
                                                    marginTax = BRACKET_1;
                                                    tax = income * BRACKET_1;
                                                    marginText.Text = ($"{marginTax:P}");
                                                    dueTaxText.Text = ($"{tax:C}");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if(headButton.Checked)
                        {
                            if (income >= HEAD_6)
                            {

                                marginTax = BRACKET_7;
                                tax = (income - HEAD_6) * BRACKET_7
                                    + (HEAD_6 - HEAD_5) * BRACKET_6
                                    + (HEAD_5 - HEAD_4) * BRACKET_5
                                    + (HEAD_4 - HEAD_3) * BRACKET_4
                                    + (HEAD_3 - HEAD_2) * BRACKET_3
                                    + (HEAD_2 - HEAD_1) * BRACKET_2
                                    + (HEAD_1 * BRACKET_1);
                                marginText.Text = ($"{marginTax:P}");
                                dueTaxText.Text = ($"{tax:C}");
                            }
                            else
                            {
                                if (income > HEAD_5 && income < HEAD_6)
                                {

                                    marginTax = BRACKET_6;
                                    tax = (income - HEAD_5) * BRACKET_6
                                        + (HEAD_5 - HEAD_4) * BRACKET_5
                                        + (HEAD_4 - HEAD_3) * BRACKET_4
                                        + (HEAD_3 - HEAD_2) * BRACKET_3
                                        + (HEAD_2 - HEAD_1) * BRACKET_2
                                        + (HEAD_1 * BRACKET_1);
                                    marginText.Text = ($"{marginTax:P}");
                                    dueTaxText.Text = ($"{tax:C}");
                                }
                                else
                                {
                                    if (income > HEAD_4 && income < HEAD_5)
                                    {
                                        marginTax = BRACKET_5;
                                        tax = (income - HEAD_4) * BRACKET_5
                                            + (HEAD_4 - HEAD_3) * BRACKET_4
                                            + (HEAD_3 - HEAD_2) * BRACKET_3
                                            + (HEAD_2 - HEAD_1) * BRACKET_2
                                            + (HEAD_1 * BRACKET_1);

                                        marginText.Text = ($"{marginTax:P}");
                                        dueTaxText.Text = ($"{tax:C}");
                                    }
                                    else
                                    {
                                        if (income > HEAD_3 && income < HEAD_4)
                                        {

                                            marginTax = BRACKET_4;
                                            tax = (income - HEAD_3) * BRACKET_4
                                                + (HEAD_3 - HEAD_2) * BRACKET_3
                                                + (HEAD_2 - HEAD_1) * BRACKET_2
                                                + (HEAD_1 * BRACKET_1);

                                            marginText.Text = ($"{marginTax:P}");
                                            dueTaxText.Text = ($"{tax:C}");
                                        }
                                        else
                                        {
                                            if (income > HEAD_2 && income < HEAD_3)
                                            {
                                                marginTax = BRACKET_3;
                                                tax = (income - HEAD_2) * BRACKET_3   
                                                    + (HEAD_2 - HEAD_1) * BRACKET_2
                                                    + (HEAD_1 * BRACKET_1);

                                                marginText.Text = ($"{marginTax:P}");
                                                dueTaxText.Text = ($"{tax:C}");
                                            }
                                            else
                                            {
                                                if (income > HEAD_1 && income < HEAD_2)
                                                {
                                                    marginTax = BRACKET_2;
                                                    tax = (income - HEAD_1) * BRACKET_2
                                                        + (HEAD_1 * BRACKET_1);

                                                    marginText.Text = ($"{marginTax:P}");
                                                    dueTaxText.Text = ($"{tax:C}");
                                                }
                                                else
                                                {
                                                    if (income <= HEAD_1)
                                                    {
                                                        marginTax = BRACKET_1;
                                                        tax = income * BRACKET_1;
                                                        marginText.Text = ($"{marginTax:P}");
                                                        dueTaxText.Text = ($"{tax:C}");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if(seperateButton.Checked)
                            {
                                if (income >= SEPERATE_6)
                                {

                                    marginTax = BRACKET_7;
                                    tax = (income - SEPERATE_6) * BRACKET_7
                                        + (SEPERATE_6 - SEPERATE_5) * BRACKET_6
                                        + (SEPERATE_5 - SEPERATE_4) * BRACKET_5
                                        + (SEPERATE_4 - SEPERATE_3) * BRACKET_4
                                        + (SEPERATE_3 - SEPERATE_2) * BRACKET_3
                                        + (SEPERATE_2 - SEPERATE_1) * BRACKET_2
                                        + (SEPERATE_1 * BRACKET_1);
                                    marginText.Text = ($"{marginTax:P}");
                                    dueTaxText.Text = ($"{tax:C}");
                                }
                                else
                                {
                                    if (income > SEPERATE_5 && income < SEPERATE_6)
                                    {

                                        marginTax = BRACKET_6;
                                        tax = (income - SEPERATE_5) * BRACKET_6
                                            + (SEPERATE_5 - SEPERATE_4) * BRACKET_5
                                            + (SEPERATE_4 - SEPERATE_3) * BRACKET_4
                                            + (SEPERATE_3 - SEPERATE_2) * BRACKET_3
                                            + (SEPERATE_2 - SEPERATE_1) * BRACKET_2
                                            + (SEPERATE_1 * BRACKET_1);

                                        marginText.Text = ($"{marginTax:P}");
                                        dueTaxText.Text = ($"{tax:C}");
                                    }
                                    else
                                    {
                                        if (income > SEPERATE_4 && income < SEPERATE_5)
                                        {
                                            marginTax = BRACKET_5;
                                            tax = (income - SEPERATE_4) * BRACKET_5


                                                + (SEPERATE_4 - SEPERATE_3) * BRACKET_4
                                                + (SEPERATE_3 - SEPERATE_2) * BRACKET_3
                                                + (SEPERATE_2 - SEPERATE_1) * BRACKET_2
                                                + (SEPERATE_1 * BRACKET_1);

                                            marginText.Text = ($"{marginTax:P}");
                                            dueTaxText.Text = ($"{tax:C}");
                                        }
                                        else
                                        {
                                            if (income > SEPERATE_3 && income < SEPERATE_4)
                                            {

                                                marginTax = BRACKET_4;
                                                tax = (income - SEPERATE_3) * BRACKET_4
                                                    + (SEPERATE_3 - SEPERATE_2) * BRACKET_3
                                                    + (SEPERATE_2 - SEPERATE_1) * BRACKET_2
                                                    + (SEPERATE_1 * BRACKET_1);

                                                marginText.Text = ($"{marginTax:P}");
                                                dueTaxText.Text = ($"{tax:C}");
                                            }
                                            else
                                            {
                                                if (income > SEPERATE_2 && income < SEPERATE_3)
                                                {
                                                    marginTax = BRACKET_3;
                                                    tax = (income - SEPERATE_2) * BRACKET_3          
                                                        + (SEPERATE_2 - SEPERATE_1) * BRACKET_2
                                                        + (SEPERATE_1 * BRACKET_1);

                                                    marginText.Text = ($"{marginTax:P}");
                                                    dueTaxText.Text = ($"{tax:C}");
                                                }
                                                else
                                                {
                                                    if (income > SEPERATE_1 && income < SEPERATE_2)
                                                    {
                                                        marginTax = BRACKET_2;
                                                        tax = (income - SEPERATE_1) * BRACKET_2
                                                            + (SEPERATE_1 * BRACKET_1);

                                                        marginText.Text = ($"{marginTax:P}");
                                                        dueTaxText.Text = ($"{tax:C}");
                                                    }
                                                    else
                                                    {
                                                        if (income <= SEPERATE_1)
                                                        {
                                                            marginTax = BRACKET_1;
                                                            tax = income * BRACKET_1;
                                                            marginText.Text = ($"{marginTax:P}");
                                                            dueTaxText.Text = ($"{tax:C}");
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
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
