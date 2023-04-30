using MuinsomTestProgram.SaveToFile;
namespace MuinsomTestProgram
{
    public partial class Form1 : Form
    {
        private string SaveUrl { get; set; }
        List<string> StringsToSave { get; set; }
        SaveFile save;
        public Form1()
        {
            InitializeComponent();
            StringsToSave = new List<string>();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            CreatingList();
            save = new SaveFile();
        }

        private void CreatingList()
        {
            /*
             Nu er dette bare en liste med strings.
            Det kunne også nemt have været en model af opkald. Hvor jeg kunne sortere på Modellens ID eller Dato.
            For nemhedens skyld lavede jeg en liste med strings.
             */
            for(int i = 1; i < 10001; i++)
            {
                string str = DateTime.Now +  ": Dette er opkald " + i;
                StringsToSave.Add(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveUrl = saveFileDialog1.FileName;
                bool result = save.SaveFileMethod(StringsToSave, SaveUrl);

                if(result)
                {
                    textBox2.Text = "Filen er gemt";
                }
                else
                {
                    textBox2.Text = "Der skete en fejl i forsøget";
                }
            }
            
        }
    }
}