namespace Study_string1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSearch.Text = "�˻�� �Է��ϼ���"; // �⺻ �ؽ�Ʈ ����
            txtSearch.ForeColor = Color.Gray; // ȸ������ ǥ�� (�÷��̽�Ȧ�� ȿ��)

            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;

        }
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "�˻�� �Է��ϼ���")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black; // �Է��� �� ���������� ����
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "�˻�� �Է��ϼ���";
                txtSearch.ForeColor = Color.Gray; // �ٽ� �⺻ �ؽ�Ʈ�� ����
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string strText = lblText.Text;
             label7.Text = strText.Contains("Test").ToString();*/

            // lblText�� ǥ�õ� �ؽ�Ʈ�� �����´�.
            string strText = lblText.Text;

            // ����ڰ� �Է��� �˻� ���ڿ��� �����ɴϴ�.
            string searchText = txtSearch.Text;

            // �˻� ���ڿ��� lblText.Text�� ���ԵǾ� �ִ��� Ȯ���մϴ�.
            label7.Text = strText.Contains(searchText).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
