namespace cs0509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPropety.Text = "�����ꂽ";
            buttonPropety.Left = 0;
            buttonPropety.Visible = false;

            //���������@MessageBox.show�͓����֐�
            MessageBox.Show("hello");
        }
    }
}
