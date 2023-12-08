namespace WinFormsApp7_2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;

        public Form1()
        {
            InitializeComponent();

            // 電話帳に名前を登録する
            this.phoneBook = new Dictionary<string, string>();
            this.phoneBook.Add("山田一郎","090-1234-5678");
            this.phoneBook.Add("山田二郎", "090-2345-6789");
            this.phoneBook.Add("山田三郎", "090-3456-7890");
            this.phoneBook.Add("山田史郎", "090-4567-8901");

            // リストに名前を表示させる
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