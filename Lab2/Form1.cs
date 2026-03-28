using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lab2
{
    public partial class frmMain : Form
    {
        const string space = "  ";
        byte[] bytesOfInitText;
        List<byte> bytesOfGenKey;
        byte[] bytesOfCypher;

        const int degree = 28;
        
        public frmMain()
        {
            InitializeComponent();

            openFileDialog1.Filter = "All files(*.*)|*.*";
            openFileDialog1.Title = "Выбор файла для загрузки";
            saveFileDialog1.Filter = "All files(*.*)|*.*";
            saveFileDialog1.Title = "Выбор файла для сохранения";
            saveFileDialog1.OverwritePrompt = true;
        }

        //Байты -> биты
        private string getBitsFromBytes(byte[] arrOfBytes)
        {
            string str = "";
            int i = 0;
            while (i < arrOfBytes.Length && i < 15) { 
                str += Convert.ToString(arrOfBytes[i], 2).PadLeft(8,'0') + space;
                i++;
            }

            if (arrOfBytes.Length > 30)
            {
                str += "\n ... \n";
                i = arrOfBytes.Length - 15;
            }
            
            while (i < arrOfBytes.Length)
            {
                str += Convert.ToString(arrOfBytes[i], 2).PadLeft(8, '0') + space;
                i++;
            }
            return str;
        }

        //Проверка ключа
        private bool isRightKey()
        {
            string initKey = tbInitKey.Text;

            //Очистка ключа от недопустимых символов(могут быть только 0 и 1)
            initKey = new string(initKey.Where((c) => c == '1' || c == '0').ToArray());

            //Проверка на длину
            if (initKey.Length < degree)
            {
                MessageBox.Show(
                    "Ключ должен состоять из 28 символов. Каждый символ - либо 0, либо 1.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Генерация ключевой последовательности(x^28+x^3+1)
        private string generateKey(string initKey, int sizeOfGenKey)
        {
            byte[] register = new byte[degree];
            bytesOfGenKey = new List<byte>(sizeOfGenKey/8);
            byte currByte = 0;

            //Инициализация регистра
            for (int i = 0;i < degree;i++)
                register[i] = (byte)Char.GetNumericValue(initKey[i]);

            byte resOfXOR;

            //Генерируем ключевую последовательность
            for (int i = 0; i < sizeOfGenKey; i++)
            {
                resOfXOR = (byte)(register[0] ^ register[25]);

                //Сдвиг регистра влево => вываливается бит ключа слева
                currByte = (byte)(currByte << 1); // 00010101 => 00101010
                currByte |=  register[0];

                if ((i+1) % 8 == 0)
                    bytesOfGenKey.Add(currByte);
                
                //Двигаем все разряды регистра влево
                Array.ConstrainedCopy(register, 1, register,0, degree-1);

                //Вставляем результат xor в самый первый разряд регистра
                register[register.Length-1] = resOfXOR;
            }
            return getBitsFromBytes(bytesOfGenKey.ToArray());
        }

        //Получение шифротекста
        private string getResult(byte[] initText, byte[] key)
        {
            bytesOfCypher = new byte[initText.Length];

            for (int i = 0; i < initText.Length; i++)
            {
                bytesOfCypher[i] = (byte)(initText[i] ^ key[i]);
            }

            return getBitsFromBytes(bytesOfCypher);
        }

        //Запись в файл
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialog1.FileName;
            FileStream fStream = File.OpenWrite(fileName);
            fStream.Write(bytesOfCypher, 0, bytesOfCypher.Length);
            fStream.Close();
        }

        //Загрузка файла
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            tbGenKey.Text = "";
            tbCypherText.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog1.FileName;
            FileStream fStream = File.OpenRead(fileName);
            bytesOfInitText = new byte[fStream.Length];

            fStream.Read(bytesOfInitText, 0, bytesOfInitText.Length);
            tbInitFile.Text = getBitsFromBytes(bytesOfInitText); ; 

            fStream.Close();
        }

        //Шифрование
        private void btnCypher_Click(object sender, EventArgs e)
        {
            //Проверка ключа
            if (!isRightKey())
                return;
            //Генерация ключевой последовательности
            tbGenKey.Text = generateKey(tbInitKey.Text, bytesOfInitText.Length * 8);
            //Получаем шифротекст
            tbCypherText.Text = getResult(bytesOfInitText, bytesOfGenKey.ToArray());
        }

        //Расшифровка
        private void btnEncypher_Click(object sender, EventArgs e)
        {
            if (!isRightKey()) 
                return;

            tbGenKey.Text = generateKey(tbInitKey.Text, bytesOfInitText.Length * 8);

            tbCypherText.Text = getResult(bytesOfInitText, bytesOfGenKey.ToArray());
        }

        //Очищаем все поля
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInitFile.Text = "";
            tbGenKey.Text = "";
            tbCypherText.Text = "";
            tbInitKey.Text = "";
        }

        //Отображение всех битов
        private void btnShowAllBytes_Click(object sender, EventArgs e)
        {
            StringBuilder str1 = new StringBuilder("");
            StringBuilder str2 = new StringBuilder("");
            StringBuilder str3 = new StringBuilder("");

            for (int i = 0; i < bytesOfInitText.Length; i++)
            {
                str1.Append(Convert.ToString(bytesOfInitText[i], 2).PadLeft(8, '0'));
                str1.Append(space);
                str2.Append(Convert.ToString(bytesOfGenKey[i], 2).PadLeft(8, '0'));
                str2.Append(space);
                str3.Append(Convert.ToString(bytesOfCypher[i], 2).PadLeft(8, '0'));
                str3.Append(space);
            }

            tbInitFile.Text = str1.ToString();
            tbGenKey.Text = str2.ToString();
            tbCypherText.Text = str3.ToString();
        }
    }
}
