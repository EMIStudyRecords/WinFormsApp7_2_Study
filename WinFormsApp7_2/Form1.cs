namespace WinFormsApp7_2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;

        public Form1()
        {
            InitializeComponent();

            // �d�b���ɖ��O��o�^����
            this.phoneBook = new Dictionary<string, string>();
            this.phoneBook.Add("�R�c��Y","090-1234-5678");
            this.phoneBook.Add("�R�c��Y", "090-2345-6789");
            this.phoneBook.Add("�R�c�O�Y", "090-3456-7890");
            this.phoneBook.Add("�R�c�j�Y", "090-4567-8901");

            // ���X�g�ɖ��O��\��������
            foreach (KeyValuePair<string,string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {

        }
    }
}