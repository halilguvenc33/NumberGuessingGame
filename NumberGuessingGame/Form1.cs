using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        int dijit_no = 4;
        int dijit1_num = 0;
        int dijit10_num = 0;
        int dijit100_num = 0;
        int dijit1000_num = 0;
        int game_count = 1;
        int pc_secret_num = 0;
        int user_plus_val = 0;
        int user_minus_val = 0;

        int r = 123, n, i = 0, j = 0, t = -1;

        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[10];
        int[] d = new int[10];
        int[] B = new int[10];
        int[] C = new int[10];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            zero_btn.Enabled = false;

            pc_secret_num = produce_random_number();

            guess_user_number(0, 0);
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(0);
            zero_btn.Enabled = false;
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(1);
            one_btn.Enabled = false;
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(2);
            two_btn.Enabled = false;
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(3);
            three_btn.Enabled = false;
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(4);
            four_btn.Enabled = false;
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(5);
            five_btn.Enabled = false;
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(6);
            six_btn.Enabled = false;
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(7);
            seven_btn.Enabled = false;
        }

        private void eigth_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(8);
            eigth_btn.Enabled = false;
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            write_num_textbox(9);
            nine_btn.Enabled = false;
        }

        private void enter_pc_btn_Click(object sender, EventArgs e)
        {
            int user_num = get_number(dijit1_num, dijit10_num, dijit100_num, dijit1000_num);

            int plus_num = DigitControl_Plus(user_num, pc_secret_num);
            int minus_num = DigitControl_Neg(user_num, pc_secret_num);

            pc_txt.AppendText(game_count + ") " + user_num + " +" + plus_num + " -" + minus_num + "\n");

            game_count++;
            clear_objects();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            clear_objects();
        }

        private void write_num_textbox(int num)
        {
            switch (dijit_no)
            {
                case 1:
                    dijit1_num = num;
                    dijit1_txt.Text = num + "";
                    dijit_no = 0;
                    disable_buttons();
                    break;
                case 2:
                    dijit10_num = num;
                    dijit10_txt.Text = num + "";
                    dijit_no = 1;
                    break;
                case 3:
                    dijit100_num = num;
                    dijit100_txt.Text = num + "";
                    dijit_no = 2;
                    break;
                case 4:
                    dijit1000_num = num;
                    dijit1000_txt.Text = num + "";
                    dijit_no = 3;
                    zero_btn.Enabled = true;
                    break;
                case 0:
                    break;
            }

        }
        private void enable_buttons()
        {
            one_btn.Enabled = true;
            two_btn.Enabled = true;
            three_btn.Enabled = true;
            four_btn.Enabled = true;
            five_btn.Enabled = true;
            six_btn.Enabled = true;
            seven_btn.Enabled = true;
            eigth_btn.Enabled = true;
            nine_btn.Enabled = true;
        }

        private void disable_buttons()
        {
            zero_btn.Enabled = false;
            one_btn.Enabled = false;
            two_btn.Enabled = false;
            three_btn.Enabled = false;
            four_btn.Enabled = false;
            five_btn.Enabled = false;
            six_btn.Enabled = false;
            seven_btn.Enabled = false;
            eigth_btn.Enabled = false;
            nine_btn.Enabled = false;
        }

        private void reset_numbers()
        {
            dijit1_num = 0;
            dijit10_num = 0;
            dijit100_num = 0;
            dijit1000_num = 0;
        }

        int get_number(int dijit1, int dijit10, int dijit100, int dijit1000)
        {
            return dijit1 + (dijit10 * 10) + (dijit100 * 100) + (dijit1000 * 1000);
        }

        private void clear_objects()
        {
            dijit1_txt.Text = String.Empty;
            dijit10_txt.Text = String.Empty;
            dijit100_txt.Text = String.Empty;
            dijit1000_txt.Text = String.Empty;
            enable_buttons();
            dijit_no = 4;
        }

        int DigitControl_Plus(int user_num, int pc_random)  // controlling pc_random and user_num that decided which digit(s) is(are) same
        {
            int[] user_numm = new int[4];
            int[] pc_num = new int[4];
            int count_pos = 0;
            user_numm[0] = user_num / 1000;
            user_numm[1] = (user_num % 1000) / 100;
            user_numm[2] = ((user_num % 1000) % 100) / 10;
            user_numm[3] = ((user_num % 1000) % 100) % 10;


            pc_num[0] = pc_random / 1000;
            pc_num[1] = (pc_random % 1000) / 100;
            pc_num[2] = ((pc_random % 1000) % 100) / 10;
            pc_num[3] = ((pc_random % 1000) % 100) % 10;

            // 0. digit control
            if (pc_num[0] == user_numm[0])
            {
                count_pos = count_pos + 1;
            }

            // 1. digit control
            if (pc_num[1] == user_numm[1])
            {
                count_pos = count_pos + 1;
            }

            // 2. digit control
            if (pc_num[2] == user_numm[2])
            {
                count_pos = count_pos + 1;
            }

            // 3. digit control
            if (pc_num[3] == user_numm[3])
            {
                count_pos = count_pos + 1;
            }

            return count_pos;  // true number true digit
        }

        int DigitControl_Neg(int user_num, int pc_random)  //controlling pc_random and user_num that decided digit(s) true but place is wrong
        {
            int[] user_numm = new int[4];
            int[] pc_num = new int[4];
            int count_neg = 0;
            user_numm[0] = user_num / 1000;
            user_numm[1] = (user_num % 1000) / 100;         // assign digits for user_num
            user_numm[2] = ((user_num % 1000) % 100) / 10;
            user_numm[3] = ((user_num % 1000) % 100) % 10;

            pc_num[0] = pc_random / 1000;
            pc_num[1] = (pc_random % 1000) / 100;           // assign digits for pc_random
            pc_num[2] = ((pc_random % 1000) % 100) / 10;
            pc_num[3] = ((pc_random % 1000) % 100) % 10;

            if (pc_num[0] == user_numm[1] || pc_num[0] == user_numm[2] || pc_num[0] == user_numm[3])
            {
                count_neg = count_neg + 1;
            }

            if (pc_num[1] == user_numm[0] || pc_num[1] == user_numm[2] || pc_num[1] == user_numm[3])
            {
                count_neg = count_neg + 1;
            }

            if (pc_num[2] == user_numm[0] || pc_num[2] == user_numm[1] || pc_num[2] == user_numm[3])
            {
                count_neg = count_neg + 1;
            }
            if (pc_num[3] == user_numm[0] || pc_num[3] == user_numm[1] || pc_num[3] == user_numm[2])
            {
                count_neg = count_neg + 1;
            }
            return count_neg;  // true number wrong digit
        }

        int produce_random_number() 
        {
            
            int[] num = new int[4];
            int rand_num;
            for (int i = 0; i < 4; i++)
            {
                num[i] = rnd.Next(10) % 10; // random number assign for num[0], num[1], num[2], num[3],
            }
            while (true) // controlling same number for every digit 
            {
                if (!(num[0] == num[1] || num[1] == num[2] || num[2] == num[3] || num[3] == num[1] || num[3] == num[0] || num[2] == num[0]))

                    break;
                for (int i = 0; i < 4; i++)
                {
                    num[i] = rnd.Next(10) % 10;
                }
                if (num[3] == 0) { num[3]++; } // controlling n[3] for be sure that different then 0 

            }

            rand_num = num[0] + (num[1] * 10) + (num[2] * 100) + (num[3] * 1000); // achieve random number

            return rand_num;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            user_plus_val++;
            plus_txt.Text = user_plus_val + "";
        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            user_minus_val++;
            minus_txt.Text = user_minus_val + "";
        }

        private void enter_user_btn_Click(object sender, EventArgs e)
        {
            B[i] = user_plus_val;
            C[i] = user_minus_val;

            int guessing_num = guess_user_number(user_plus_val, user_minus_val);

            if (guessing_num != -1) 
            {
                user_txt.AppendText(game_count + ") " + "I guess :  " + guessing_num + "\n");

                game_count++;
            }
            else 
            {
                user_txt.Text = "\nThere must be something wrong with the given responses";
            }

            

            j = j + 1;

            plus_txt.Text = String.Empty;
            minus_txt.Text = String.Empty;
            user_plus_val = 0;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            plus_txt.Text = String.Empty;
            minus_txt.Text = String.Empty;
            user_plus_val = 0;
         
        }

        private int guess_user_number(int plus_val, int minus_val) 
        {    
            label2:
                if (r == 10000)
                {
                    return -1;
                }
                if (j == 0 ) // 9/10 times a random number will be chosen
                {
                    d[j] = rnd.Next(10) % 10;
                    c[j] = rnd.Next(10) % 10;
                    b[j] = rnd.Next(10) % 10;
                    a[j] = 1 + rnd.Next(10) % 9;
                }
                // 1/10 times the smallest number that satisfies the given responses will be chosen
                else
                {
                    n = r;
                    d[j] = n % 10; n = n / 10;
                    c[j] = n % 10; n = n / 10;
                    b[j] = n % 10; n = n / 10;
                    a[j] = n % 10; n = n / 10;
                    r = r + 1;
                }
                if ((a[j] == b[j] || a[j] == c[j] || a[j] == d[j]) || (b[j] == c[j] || b[j] == d[j]) || (c[j] == d[j])) { goto label2; }
            label3:
                if (a[j] == b[i] || a[j] == c[i] || a[j] == d[i]) { C[j] = C[j] + 1; }
                if (a[j] == a[i]) { B[j] = B[j] + 1; }
                if (b[j] == a[i] || b[j] == c[i] || b[j] == d[i]) { C[j] = C[j] + 1; }
                if (b[j] == b[i]) { B[j] = B[j] + 1; }
                if (c[j] == b[i] || c[j] == a[i] || c[j] == d[i]) { C[j] = C[j] + 1; }
                if (c[j] == c[i]) { B[j] = B[j] + 1; }
                if (d[j] == b[i] || d[j] == c[i] || d[j] == a[i]) { C[j] = C[j] + 1; }
                if (d[j] == d[i]) { B[j] = B[j] + 1; }
                while (i > 0)
                {
                    if (B[j] != B[i] || C[j] != C[i])
                    {
                        B[j] = C[j] = 0;
                        i = t;
                        goto label2;
                    }
                    i = i - 1;
                    B[j] = C[j] = 0;
                    goto label3;
                }
                i = t + 1; t = i; r = 1000;

                a[i] = a[j];
                b[i] = b[j];
                c[i] = c[j];
                d[i] = d[j];

                return get_number(d[j], c[j], b[j], a[j]);
        }
    }
}
