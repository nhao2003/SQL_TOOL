namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string[] inp = rb_Input.Text.Split('\n');
            List<string> pro = new List<string>();
            foreach (string s in inp)
            {
                if (!s.Trim().Contains(' '))
                {
                    if (pro.Count > 0)
                    {
                        rb_Output.Text += TaoLenh(pro);
                    }
                    pro.Clear();
                }
                pro.Add(s);
            }
            rb_Output.Text += TaoLenh(pro);
        }

        private string TaoLenh(List<string> inp)
        {
            if (inp.Count == 0) return "\n";
            string cmd = $"CREATE TABLE {inp[0]} (\n";
            for (int i = 1; i < inp.Count; i++)
            {
                string[] process = inp[i].Split(" ");
                if (process.Length == 0) continue;
                cmd += "\t" + process[0] + " " + process[^1];
                if (i != inp.Count - 1) cmd += ", \n";
            }

            cmd += ",\n)\n";
            return cmd;
        }
    }
}