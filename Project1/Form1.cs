namespace Study_string1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSearch.Text = "검색어를 입력하세요"; // 기본 텍스트 설정
            txtSearch.ForeColor = Color.Gray; // 회색으로 표시 (플레이스홀더 효과)

            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;

        }
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "검색어를 입력하세요")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black; // 입력할 때 검은색으로 변경
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "검색어를 입력하세요";
                txtSearch.ForeColor = Color.Gray; // 다시 기본 텍스트로 변경
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
            string strText = lblText.Text;
            string searchText = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText) || searchText == "검색어를 입력하세요")
            {
                MessageBox.Show("검색어를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
