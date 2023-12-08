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
            /*
            this.phoneBook.Add("山田一郎","090-1234-5678");
            this.phoneBook.Add("山田二郎", "090-2345-6789");
            this.phoneBook.Add("山田三郎", "090-3456-7890");
            this.phoneBook.Add("山田史郎", "090-4567-8901");
            */

            ReadFormFile();
            
            // リストに名前を表示させる
            foreach (KeyValuePair<string,string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        // テキストファイルの読み込み
        private void ReadFormFile()
        {
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\鈴木　映美\source\repos\WinFormsApp7_2\WinFormsApp7_2\data.txt"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    this.phoneBook.Add(data[0], data[1]);
                }
            }
        }
        // 選択した名前に対応する電話番号を表示する
        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name]; // Dictionaryからデータを取り出す
        }
    }
}