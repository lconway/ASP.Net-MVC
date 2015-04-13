using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse;
        private bool formChanged;           // has form formChanged?
        private string selectedFolder;      // folder selected by Folder button
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            currentExcuse = new Excuse();
            currentExcuse.LastUsed = lastUsed.Value;

            formChanged = false;
            selectedFolder = "";
            fileDateLabel.Text = "";
            folderButton.Enabled = true;
            saveButton.Enabled = false;
            openButton.Enabled = false;
            randomButton.Enabled = false;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.selectedFolder = folderBrowserDialog1.SelectedPath;
                // Once folder has been selected, enable Save, Open and Random buttons
                this.saveButton.Enabled = true;
                this.openButton.Enabled = true;
                this.randomButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.excuseText.Text) ||       // Must have an excuse and a result to save excuse
                String.IsNullOrEmpty(this.resultsText.Text))
            {
                MessageBox.Show("Please specify an excuse and result",

                    "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.FileName = excuseText.Text + ".excuse";    // filename to be saved is the excuse string
            saveFileDialog1.Filter = 
                "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //  Save the file by the filename selected in the Dialog
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                saveFileDialog1.FileName = excuseText.Text + ".excuse";    // filename to be saved is the excuse string
                saveFileDialog1.Filter =
                    "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //  Open the file by the filename selected in the Dialog
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                // Choose an excuse selected randomly out of the selectedFolder
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        // Check if there are any edits to the form
        //   If there are, then display dialog before opening a new excuse
        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            // Either the form has not been edited or
            //   form has been edited and user wants to lose changes
            //   by saveing the form anyway
            return true;
        }

        private void excuseText_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuseText.Text;
            UpdateForm(true);
        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = resultsText.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        // If formChanged is false: 
        //   1) update the controls on the form
        //   2) display the form title without "*"
        //   3) if the ExcusePath has not yet been opened (a new Excuse object has
        //        just been created), set the fileDateLabel on the form.
        // Otherwise display the form title with "*"
        private void UpdateForm(bool formChanged)
        {
            if (!formChanged)
            {
                this.excuseText.Text = currentExcuse.Description;
                this.resultsText.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath)) 
                {
                    fileDateLabel.Text =                    // set the File Date label
                        File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Excuse Manager";
            }
            else
            {
                this.Text = "Excuse Manager*";
            }
            this.formChanged = formChanged;
        }

        [Serializable]
        class Excuse
        {
            public string Description { get; set; }
            public string Results { get; set; }
            public DateTime LastUsed { get; set; }
            public string ExcusePath { get; set; }   // Set in constructor, 
                                                     //  it is not a displayed on the control 
            // Used at form initialization
            public Excuse()
            {
                ExcusePath = "";
            }

            // Used when opening an excuse
            public Excuse(string excusePath)
            {
                Open(excusePath);
            }

            // Used when opening a random excuse
            public Excuse(Random random, string folder)
            {
                string[] fileNames = Directory.GetFiles(folder, "*.excuse");
                Open(fileNames[random.Next(fileNames.Length)]);
            }

            public void Open(string excusePath)
            {
                this.ExcusePath = excusePath;
                Excuse tempExcuse;
                using (Stream input = File.OpenRead(excusePath))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    tempExcuse = (Excuse)bf.Deserialize(input);
                }
                Description = tempExcuse.Description;
                Results = tempExcuse.Results;
                LastUsed = tempExcuse.LastUsed;

                //using (StreamReader reader = new StreamReader(excusePath))
                //{
                //    Description = reader.ReadLine();
                //    Results = reader.ReadLine();
                //    LastUsed = Convert.ToDateTime(reader.ReadLine());
                //}
            }

            public void Save(string fileName)
            {
                using (Stream output = File.Create(fileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(output, this);
                }

                //using (StreamWriter writer = new StreamWriter(fileName))
                //{
                //    writer.WriteLine(Description);
                //    writer.WriteLine(Results);
                //    writer.WriteLine(LastUsed.ToString());
                //}
            }

        }
    }
}
