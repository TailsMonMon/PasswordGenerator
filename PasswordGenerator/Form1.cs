using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void buttonGenerate_Click(object sender, EventArgs e) {
            buttonGenerate.Text = "Genererat! ➡️";
            char[] wordWrap = new char[]{'\r', '\n'};
            string[] name = textBoxName.Text.Split(wordWrap, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            for(int i = 0; i < name.Length; i++) {
                result += String.Format($"{name[i].Substring(0, 3)}{i} - {GeneratePassword()} \r\n");
            }
            textBoxUsernamePassword.Text = result;
        }

        private static string GeneratePassword() {
            string result = "";
            String charsForPassword = "abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ1234567890,.-;:_*#%&";
            Random random = new Random();
            for(int i = 0; i < 8; i++) {
                result += charsForPassword[random.Next(charsForPassword.Length-1)].ToString();
                System.Threading.Thread.Sleep(10); //10 milliseconds
            }
            return result;
        }
    }
}
