using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading;
using System.Linq;


namespace EzCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dir1Button_Click(object sender, EventArgs e)
        {
            ShowFolderBrowserDialog(Dir1Path);
        }

        private void Dir2Button_Click(object sender, EventArgs e)
        {
            ShowFolderBrowserDialog(Dir2Path);
        }

        private void OutputDirButton_Click(object sender, EventArgs e)
        {
            ShowFolderBrowserDialog(OutputDirPath);
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (Dir1Path.Text == "" || Dir2Path.Text == "" || OutputDirPath.Text == "")
            {
                InfoTextbox.ForeColor = Color.Red;
                InfoTextbox.Text = "Please choose all your desired directories (path) first.";
            }
            else
            {
                new Thread(delegate ()
                {
                    CompareTextFiles(Dir1Path.Text, Dir2Path.Text);
                }).Start();
            }
        }

        #region Select Folder
        public void ShowFolderBrowserDialog(TextBox textBox)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true })
            {
                textBox.Text = dialog.ShowDialog() == CommonFileDialogResult.Ok ? dialog.FileName : null;
            }
        }
        #endregion
        
        #region Compare text files
        private async void CompareTextFiles(string directory1Path, string directory2Path)
        {

            string[] dir1TextFiles = Directory.GetFiles(directory1Path, "*.txt");

            string[] dir2TextFiles = Directory.GetFiles(directory2Path, "*.txt");

            if (dir1TextFiles.Length == 0 || dir2TextFiles.Length == 0)
            {
                InfoTextbox.ForeColor = Color.Red;
                InfoTextbox.Text = "No text files found in " + directory1Path;
            }
            else
            {
                Invoke(new Action(() =>
                {
                    CompareButton.Enabled = false;
                    Dir1Button.Enabled = false;
                    Dir2Button.Enabled = false;
                    OutputDirButton.Enabled = false;
                    RadioButtonDir1.Enabled = false;
                    RadioButtonDir2.Enabled = false;
                    RadioButtonItemTag.Enabled = false;
                    RadioButtonTrans.Enabled = false;
                }));

                string outputDirectoryPath = Path.Combine(OutputDirPath.Text, "EzCompare_result");
                Directory.CreateDirectory(outputDirectoryPath);

                int count = 1;
                for (int i = 0; i < dir1TextFiles.Length; i++)
                {
                    for (int j = 0; j < dir2TextFiles.Length; j++)
                    {
                        string dir1TextFileName = Path.GetFileName(dir1TextFiles[i]);
                        string dir2TextFileName = Path.GetFileName(dir2TextFiles[j]);
                        
                        string[] a_lines = File.ReadAllLines(dir1TextFiles[i], Encoding.Unicode);
                        string[] b_lines = File.ReadAllLines(dir2TextFiles[j], Encoding.Unicode);

                        Invoke(new Action(() =>
                        {
                            InfoTextbox.ForeColor = Color.Green;
                            InfoTextbox.Text = "Comparing pair " + count.ToString() + "...";
                        }));

                        if (RadioButtonDir1.Checked == true)
                        {
                            string outputFileName = dir2TextFileName + ".txt";

                            string a_lines_string = string.Join(",", a_lines).ToLower();

                            using (StreamWriter resultFile = new StreamWriter(Path.Combine(outputDirectoryPath, outputFileName), false, Encoding.Unicode))
                            {
                                await resultFile.WriteLineAsync("Missing line(s) of " + dir1TextFiles[i] + " compare to " + dir2TextFiles[j]);
                                if (RadioButtonItemTag.Checked == true)
                                {
                                    for (int k = 0; k < b_lines.Length; k++)
                                    {
                                        if (!a_lines.Any(line => line.Contains(b_lines[k])))
                                        {
                                            await resultFile.WriteLineAsync(b_lines[k]);
                                        }
                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < b_lines.Length; k++)
                                    {
                                        string[] strip = b_lines[k].ToLower().Split('"');
                                        try
                                        {
                                            if (strip.Length > 2)
                                            {
                                                if (!a_lines_string.Contains('"' + strip[1] + '"'))
                                                {
                                                    await resultFile.WriteLineAsync(b_lines[k]);
                                                }
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            if (e is IndexOutOfRangeException) { }
                                            else { Console.WriteLine("Exception " + e.ToString()); }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            string outputFileName = dir1TextFileName + ".txt";

                            string b_lines_string = string.Join(",", b_lines).ToLower();

                            using (StreamWriter resultFile = new StreamWriter(Path.Combine(outputDirectoryPath, outputFileName), false, Encoding.Unicode))
                            {
                                await resultFile.WriteLineAsync("Missing line(s) of " + dir2TextFiles[i] + " compare to " + dir1TextFiles[j]);
                                if (RadioButtonItemTag.Checked == true)
                                {
                                    for (int k = 0; k < a_lines.Length; k++)
                                    {
                                        if (!b_lines.Any(line => line.Contains(a_lines[k])))
                                        {
                                            await resultFile.WriteLineAsync(a_lines[k]);
                                        }
                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < a_lines.Length; k++)
                                    {
                                        string[] strip = a_lines[k].ToLower().Split('"');
                                        try
                                        {
                                            if (strip.Length > 2)
                                            {
                                                if (!b_lines_string.Contains('"' + strip[1] + '"'))
                                                {
                                                    await resultFile.WriteLineAsync(a_lines[k]);
                                                }
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            if (e is IndexOutOfRangeException) { }
                                            else { Console.WriteLine("Exception " + e.ToString()); }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    count++;
                }
                Invoke(new Action(() =>
                {
                    InfoTextbox.ForeColor = Color.Green;
                    InfoTextbox.Text = "Finish!";
                    CompareButton.Enabled = true;
                    Dir1Button.Enabled = true;
                    Dir2Button.Enabled = true;
                    OutputDirButton.Enabled = true;
                    RadioButtonDir1.Enabled = true;
                    RadioButtonDir2.Enabled = true;
                    RadioButtonItemTag.Enabled = true;
                    RadioButtonTrans.Enabled = true;
                }));
            }
        }
        #endregion
        
    }
}
