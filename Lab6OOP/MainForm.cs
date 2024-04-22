using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6OOP
{
    public partial class MainForm : Form
    {
        int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public MainForm()
        {
            InitializeComponent();
             
        }

        private DateTime getSystemTime()
        {
            return DateTime.Now;
        }

        private async void determineTime()
        {
            DateTime now = await Task.Run(() => { return getSystemTime(); });
            sysTime.Text = now.ToString();
        }

        private async void calculate(int[] vectors)
        {
           int result =  await Task.Run(() => { return function(vectors); });
           resultFuncTB.Text = result.ToString();
        }

        private async Task chatRun() {
            StringBuilder result = new StringBuilder();
            result.Append("Hello World "+Environment.NewLine);
            ChatArea.Text = result.ToString();
            
            await Task.Delay(1000);
            result.Append("Përshendetje Botë" + Environment.NewLine);
            ChatArea.Text = result.ToString();

            await Task.Delay(1000);
            result.Append("ওহে বিশ্ব" + Environment.NewLine);
            ChatArea.Text = result.ToString();
        }

        private async void chatStart()
        {
            await Task.Run(async () => {await chatRun(); });

        } 


        private int function(int[] vector)
        {
            int total = 0;
            foreach (int i in vector)
            {
                total += i;
            }
            total/=vector.Length;
            return total;
        }

        private void calculateAvgVector_Click(object sender, EventArgs e)
        {
            calculate(vector);
        }

        private void getSysTime_Click(object sender, EventArgs e)
        {
            determineTime();
        }

        private void startChat_Click(object sender, EventArgs e)
        {
            chatStart();
        }

        private void inputVectorNumbersBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("(([\\d]+[\\,]){9}\\d+)");
            string input = inputVectorTB.Text.ToString();
            string[] splittedArr;

            if (regex.IsMatch(input))
            {
                splittedArr = input.Split(',');
            }
            else { errorLabel.Text = "Неверный ввод: необходимо 10 чисел через запятую"; return; };

            for (int i = 0; i < splittedArr.Length; i++)
            {
                vector[i] = int.Parse(splittedArr[i]);
            }
            errorLabel.Text = "Сохранено";        }

        private void inputVectorTB_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
