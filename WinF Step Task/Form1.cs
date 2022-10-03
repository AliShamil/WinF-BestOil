using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinF_Step_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\StepTask");
        private void btn_add_change_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new(txt_Name.Text, txt_Surname.Text, txt_Email.Text, txt_Phone.Text, BirthDate.Value);
                listBox1.Items.Add(user);
                listBox1.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);

            foreach (var user in listBox1.Items)
                File.WriteAllText($@"{directory.FullName}\{(user as User)?.Name}.json", JsonSerializer.Serialize(user));
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            if (!directory.Exists)
            {
                MessageBox.Show("File not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User? user = null;
            if (listBox1.SelectedItem is null)
            {
                MessageBox.Show("User not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains((listBox1.SelectedItem as User).Name))
                    user = JsonSerializer.Deserialize<User>(File.ReadAllText(file.FullName));
            }
            if (user is null)
            {
                MessageBox.Show("User not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txt_Name.Text = user.Name;
            txt_Surname.Text = user.Surname;
            txt_Email.Text = user.Email;
            txt_Phone.Text = user.Phone;
            BirthDate.Value = user.BirthDate;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (directory.Exists)
            {
                foreach (var file in directory.GetFiles())
                {
                    listBox1.Items.Add(JsonSerializer.Deserialize<User>(File.ReadAllText(file.FullName))!);
                    listBox1.DisplayMember = "Name";
                }
            }
            
        }
    }


}
