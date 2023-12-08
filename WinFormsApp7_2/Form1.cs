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
            /*
            this.phoneBook.Add("�R�c��Y","090-1234-5678");
            this.phoneBook.Add("�R�c��Y", "090-2345-6789");
            this.phoneBook.Add("�R�c�O�Y", "090-3456-7890");
            this.phoneBook.Add("�R�c�j�Y", "090-4567-8901");
            */

            ReadFormFile();
            
            // ���X�g�ɖ��O��\��������
            foreach (KeyValuePair<string,string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        // �e�L�X�g�t�@�C���̓ǂݍ���
        private void ReadFormFile()
        {
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\��؁@�f��\source\repos\WinFormsApp7_2\WinFormsApp7_2\data.txt"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    this.phoneBook.Add(data[0], data[1]);
                }
            }
        }
        // �I���������O�ɑΉ�����d�b�ԍ���\������
        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name]; // Dictionary����f�[�^�����o��
        }
    }
}