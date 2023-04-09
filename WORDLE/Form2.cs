using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WORDLE
{
    public partial class Form2 : Form
    {
        public int guess = 0;
        public int i_x = 0;
        public int i_y = 0;
        public string[] dbword = new string[500];
        public int dbword_count = 0;
        public string word;
        public char[] current = new char[5];
        public Form2(int num)
        {
            // variabel untuk jumlah tebakan pemain
            guess = num;
            if(guess > 10) guess = 10;
            InitializeComponent();
            // fungsi untuk menampilkan textbox sesuai jumlah tebakan yang diinputkan
            showbox(guess);
            // membaca file list_word.txt untuk mendapatkan list dari kata dalam permainan
            // kemudian menyimpan ke variabel array dbword[]
            using (StreamReader file = new StreamReader("list_word.txt"))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    dbword[dbword_count]= ln;
                    dbword_count++;
                }
                file.Close();
            }

            // memilih kata random untuk ditebak oleh pemain
            Random r = new Random();
            int rInt = r.Next(0, dbword_count-1);
            word = dbword[rInt];
        }
        // fungsi untuk menampilkan textbox sesuai dengan jumlah tebakan
        public void showbox(int num)
        {
            num++;
            for(int i = num; i <= 10; i++)
            {
                line(i, false);
            }
        }
        // fungsi pendukung showbox()
        public void line(int l, bool x)
        {
            if(l == 5)
            {
                box4_0.Visible = x;
                box4_1.Visible = x;
                box4_2.Visible = x;
                box4_3.Visible = x;
                box4_4.Visible = x;
            } else if (l == 6)
            {
                box5_0.Visible = x;
                box5_1.Visible = x;
                box5_2.Visible = x;
                box5_3.Visible = x;
                box5_4.Visible = x;
            } else if (l == 7) 
            { 
                box6_0.Visible= x;
                box6_1.Visible= x;
                box6_2.Visible= x;
                box6_3.Visible= x;
                box6_4.Visible= x;
            } else if (l == 8)
            {
                box7_0.Visible= x;
                box7_1.Visible= x;
                box7_2.Visible= x;
                box7_3.Visible= x;
                box7_4.Visible= x;
            }
            else if (l == 9)
            {
                box8_0.Visible = x;
                box8_1.Visible = x;
                box8_2.Visible = x;
                box8_3.Visible = x;
                box8_4.Visible = x;
            }
            else if (l == 10)
            {
                box9_0.Visible = x;
                box9_1.Visible = x;
                box9_2.Visible = x;
                box9_3.Visible = x;
                box9_4.Visible = x;
            }
        }

        public void fill(int xx, int yy, char c)
        {
            current[xx] = c;
            if(yy == 0)
            {
                switch (xx)
                {
                    case 0:
                        box0_0.Text = c.ToString();
                        break;
                    case 1:
                        box0_1.Text = c.ToString();
                        break;
                    case 2:
                        box0_2.Text = c.ToString();
                        break;
                    case 3:
                        box0_3.Text = c.ToString();
                        break;
                    case 4:
                        box0_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 1)
            {
                switch (xx)
                {
                    case 0:
                        box1_0.Text = c.ToString();
                        break;
                    case 1:
                        box1_1.Text = c.ToString();
                        break;
                    case 2:
                        box1_2.Text = c.ToString();
                        break;
                    case 3:
                        box1_3.Text = c.ToString();
                        break;
                    case 4:
                        box1_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 2)
            {
                switch (xx)
                {
                    case 0:
                        box2_0.Text = c.ToString();
                        break;
                    case 1:
                        box2_1.Text = c.ToString();
                        break;
                    case 2:
                        box2_2.Text = c.ToString();
                        break;
                    case 3:
                        box2_3.Text = c.ToString();
                        break;
                    case 4:
                        box2_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 3)
            {
                switch (xx)
                {
                    case 0:
                        box3_0.Text = c.ToString();
                        break;
                    case 1:
                        box3_1.Text = c.ToString();
                        break;
                    case 2:
                        box3_2.Text = c.ToString();
                        break;
                    case 3:
                        box3_3.Text = c.ToString();
                        break;
                    case 4:
                        box3_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 4)
            {
                switch (xx)
                {
                    case 0:
                        box4_0.Text = c.ToString();
                        break;
                    case 1:
                        box4_1.Text = c.ToString();
                        break;
                    case 2:
                        box4_2.Text = c.ToString();
                        break;
                    case 3:
                        box4_3.Text = c.ToString();
                        break;
                    case 4:
                        box4_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 5)
            {
                switch (xx)
                {
                    case 0:
                        box5_0.Text = c.ToString();
                        break;
                    case 1:
                        box5_1.Text = c.ToString();
                        break;
                    case 2:
                        box5_2.Text = c.ToString();
                        break;
                    case 3:
                        box5_3.Text = c.ToString();
                        break;
                    case 4:
                        box5_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 6)
            {
                switch (xx)
                {
                    case 0:
                        box6_0.Text = c.ToString();
                        break;
                    case 1:
                        box6_1.Text = c.ToString();
                        break;
                    case 2:
                        box6_2.Text = c.ToString();
                        break;
                    case 3:
                        box6_3.Text = c.ToString();
                        break;
                    case 4:
                        box6_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 7)
            {
                switch (xx)
                {
                    case 0:
                        box7_0.Text = c.ToString();
                        break;
                    case 1:
                        box7_1.Text = c.ToString();
                        break;
                    case 2:
                        box7_2.Text = c.ToString();
                        break;
                    case 3:
                        box7_3.Text = c.ToString();
                        break;
                    case 4:
                        box7_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 8)
            {
                switch (xx)
                {
                    case 0:
                        box8_0.Text = c.ToString();
                        break;
                    case 1:
                        box8_1.Text = c.ToString();
                        break;
                    case 2:
                        box8_2.Text = c.ToString();
                        break;
                    case 3:
                        box8_3.Text = c.ToString();
                        break;
                    case 4:
                        box8_4.Text = c.ToString();
                        break;
                }
            }
            else if (yy == 9)
            {
                switch (xx)
                {
                    case 0:
                        box9_0.Text = c.ToString();
                        break;
                    case 1:
                        box9_1.Text = c.ToString();
                        break;
                    case 2:
                        box9_2.Text = c.ToString();
                        break;
                    case 3:
                        box9_3.Text = c.ToString();
                        break;
                    case 4:
                        box9_4.Text = c.ToString();
                        break;
                }
            }
        }

        public void add_char(char c)
        {
            if(i_x <= 4)
            {
                fill(i_x,i_y,c);
                i_x++;
            }
        }

        // fungsi untuk mengecek apakah input user termasuk dalam list kata yang valid atau tidak
        public bool check_exist(string wrd)
        {
            bool res = false;
            for(int i = 0; i < dbword_count; i++)
            {
                if(wrd == dbword[i])
                    res = true;
            }
            return res;
        }

        // ketika user klik tombol enter
        public void add_enter()
        {
            // hanya bisa enter ketika 5 kolom terisi
            if(i_x == 5)
            {
                string currentStr = new string(current);
                // mengecek apakah input valid
                if (check_exist(currentStr))
                {
                    // jika kata yang ditebak benar, maka pemain menang
                    if (currentStr == word)
                    {
                        MessageBox.Show("You Win!\n the word is '" + word + "'");
                    }
                    // jika tidak, mengecek kemiripan dengan kata asli yang harus ditebak
                    else
                    {
                        char[] charWord = word.ToCharArray();
                        for (int i = 0; i < 5; i++)
                        {
                            if (current[i] == charWord[i])
                                change_color(i, i_y, Color.GreenYellow);
                            else
                            {
                                bool exist = false;
                                for (int j = 0; j < 5; j++)
                                {
                                    if (j != i)
                                        if (current[i] == charWord[j])
                                            exist = true;
                                }
                                if (exist)
                                    change_color(i, i_y, Color.Yellow);
                            }
                        }
                        i_y++;
                        i_x = 0;
                    }
                }
                else
                {
                    // memberi pesan bahwa kata yang diinput tidak valid
                    MessageBox.Show("This is not a word!");
                    for (int i = 0; i < 5; i++)
                    {
                        fill(i,i_y,'_');
                    }
                    i_x = 0;
                }
            }
            if(i_y == guess)
            {
                MessageBox.Show("Game Over!\n the word is '" + word + "'");
            }
        }

        // fungsi untuk mengubah warna dari textbox
        public void change_color(int xx, int yy, Color c)
        {
            if (yy == 0)
            {
                switch (xx)
                {
                    case 0:
                        box0_0.BackColor = c;
                        break;
                    case 1:
                        box0_1.BackColor = c;
                        break;
                    case 2:
                        box0_2.BackColor = c;
                        break;
                    case 3:
                        box0_3.BackColor = c;
                        break;
                    case 4:
                        box0_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 1)
            {
                switch (xx)
                {
                    case 0:
                        box1_0.BackColor = c;
                        break;
                    case 1:
                        box1_1.BackColor = c;
                        break;
                    case 2:
                        box1_2.BackColor = c;
                        break;
                    case 3:
                        box1_3.BackColor = c;
                        break;
                    case 4:
                        box1_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 2)
            {
                switch (xx)
                {
                    case 0:
                        box2_0.BackColor = c;
                        break;
                    case 1:
                        box2_1.BackColor = c;
                        break;
                    case 2:
                        box2_2.BackColor = c;
                        break;
                    case 3:
                        box2_3.BackColor = c;
                        break;
                    case 4:
                        box2_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 3)
            {
                switch (xx)
                {
                    case 0:
                        box3_0.BackColor = c;
                        break;
                    case 1:
                        box3_1.BackColor = c;
                        break;
                    case 2:
                        box3_2.BackColor = c;
                        break;
                    case 3:
                        box3_3.BackColor = c;
                        break;
                    case 4:
                        box3_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 4)
            {
                switch (xx)
                {
                    case 0:
                        box4_0.BackColor = c;
                        break;
                    case 1:
                        box4_1.BackColor = c;
                        break;
                    case 2:
                        box4_2.BackColor = c;
                        break;
                    case 3:
                        box4_3.BackColor = c;
                        break;
                    case 4:
                        box4_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 5)
            {
                switch (xx)
                {
                    case 0:
                        box5_0.BackColor = c;
                        break;
                    case 1:
                        box5_1.BackColor = c;
                        break;
                    case 2:
                        box5_2.BackColor = c;
                        break;
                    case 3:
                        box5_3.BackColor = c;
                        break;
                    case 4:
                        box5_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 6)
            {
                switch (xx)
                {
                    case 0:
                        box6_0.BackColor = c;
                        break;
                    case 1:
                        box6_1.BackColor = c;
                        break;
                    case 2:
                        box6_2.BackColor = c;
                        break;
                    case 3:
                        box6_3.BackColor = c;
                        break;
                    case 4:
                        box6_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 7)
            {
                switch (xx)
                {
                    case 0:
                        box7_0.BackColor = c;
                        break;
                    case 1:
                        box7_1.BackColor = c;
                        break;
                    case 2:
                        box7_2.BackColor = c;
                        break;
                    case 3:
                        box7_3.BackColor = c;
                        break;
                    case 4:
                        box7_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 8)
            {
                switch (xx)
                {
                    case 0:
                        box8_0.BackColor = c;
                        break;
                    case 1:
                        box8_1.BackColor = c;
                        break;
                    case 2:
                        box8_2.BackColor = c;
                        break;
                    case 3:
                        box8_3.BackColor = c;
                        break;
                    case 4:
                        box8_4.BackColor = c;
                        break;
                }
            }
            else if (yy == 9)
            {
                switch (xx)
                {
                    case 0:
                        box9_0.BackColor = c;
                        break;
                    case 1:
                        box9_1.BackColor = c;
                        break;
                    case 2:
                        box9_2.BackColor = c;
                        break;
                    case 3:
                        box9_3.BackColor = c;
                        break;
                    case 4:
                        box9_4.BackColor = c;
                        break;
                }
            }
        }

        // fungsi untuk menghapus karakter / huruf yang diinputkan pemain
        public void add_delete()
        {
            if(i_x >= 0)
            {
                i_x--;
                fill(i_x, i_y, '_');
            }
        }

        // fungsi" handler untuk keyboard virtual
        private void buttonQ_Click(object sender, EventArgs e)
        {
            add_char('Q');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            add_char('W');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            add_char('E');
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            add_char('R');
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            add_char('T');
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            add_char('Y');
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            add_char('U');
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            add_char('I');
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            add_char('O');
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            add_char('P');
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            add_char('A');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            add_char('S');
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            add_char('D');
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            add_char('F');
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            add_char('G');
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            add_char('H');
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            add_char('J');
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            add_char('K');
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            add_char('L');
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            add_char('Z');
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            add_char('X');
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            add_char('C');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_char('V');
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            add_char('B');
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            add_char('N');
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            add_char('M');
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            add_enter();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            add_delete();
        }
    }
}
