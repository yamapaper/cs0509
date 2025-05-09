namespace cs0509
{
    public partial class Form1 : Form
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPropety.Text = "âüÇ≥ÇÍÇΩ";
            buttonPropety.Left = 0;
            buttonPropety.Visible = false;

            //ìØä˙èàóùÅ@MessageBox.showÇÕìØä˙ä÷êî
            MessageBox.Show("hello");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left + 1;
            button1.Top = button1.Top + 1;
            if (button1.Top == 20 && button1.Left == 20)
            {
                button1.Top = 0;
                button1.Left = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Top -= 1;
            button3.Left -= 1;
            button5.Top += 1;
            button4.Left += 1;
            count1++;
            if (count1 == 10)
            {
                button2.Top += 10;
                button3.Top += 10;
                button5.Top += 10;
                button4.Top += 10;
                count1 = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Top -= 1;
            button3.Left -= 1;
            button5.Top += 1;
            button4.Left += 1;
            if (count1 == 10)
            {
                button2.Top += 10;
                button3.Top += 10;
                button5.Top += 10;
                button4.Top += 10;
                count1 = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            count2++;
            if (count2 == 10)
            {
               
                count2 = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            count3++;
            if (count3 == 10)
            {
                
                count3 = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            count4++;
            if (count4 == 10)
            {
                
                count4 = 0;
            }
        }
    }
}
