using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string inputText = OldText.Text;
            char[] separators = { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ':', ';', '\"', '\'' }; 
            string[] words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string lastWord = words.LastOrDefault();

            HashSet<char> uniqueLetters = new HashSet<char>(lastWord);

            List<string> resultWords = new List<string>();
            foreach (string word in words)
            {
                if (word != lastWord && word.GroupBy(c => c).All(g => g.Count() == 1))
                {
                    resultWords.Add(word);
                }
            }

            string result = string.Join(" ", resultWords);
            ResultText.Text = result;
        }

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(AmountBox.Text, out key))
            {
                MessageBox.Show("Неверно введено значение");
                return;
            }

            string plaintext = OldText.Text;
            string ciphertext = ScytaleEncrypt(plaintext, key);
            ResultText.Text = ciphertext;
        }
        private string ScytaleEncrypt(string plaintext, int key)
        {
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < key; i++)
            {
                for (int j = i; j < plaintext.Length; j += key)
                {
                    encryptedText.Append(plaintext[j]);
                }
            }

            return encryptedText.ToString();
        }
        private string ScytaleDecrypt(string ciphertext, int key)
        {
            int length = ciphertext.Length;
            int rows = (int)Math.Ceiling((double)length / key);
            int cols = key;

            char[,] grid = new char[rows, cols];
            int index = 0;

            for (int i = 0; i < key; i++)
            {
                for (int j = i; j < length; j += key)
                {
                    grid[j / key, j % key] = ciphertext[index++];
                }
            }

            StringBuilder decryptedText = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    decryptedText.Append(grid[i, j]);
                }
            }

            return decryptedText.ToString();
        }

        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(AmountBox.Text, out key))
            {
                MessageBox.Show("Неверно введено значение");
                return;
            }

            string ciphertext = ResultText.Text;
            string plaintext = ScytaleDecrypt(ciphertext, key);
            ResultText.Text = plaintext;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }
    }
}
