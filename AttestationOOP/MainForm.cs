using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttestationOOP
{
    public partial class MainForm : Form
    {
        private char SYMBOL;
        private double FIRST_NUMBER;
        private double LAST_NUMBER;
        private double TOTAL_NUMBER;
        View number = new View();

        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Button buttonClick = null;

            switch (e.KeyCode)
            {
                case Keys.D0:
                    buttonClick = btn_Zero; break;
                case Keys.D1:
                    buttonClick = btn_One; break;
                case Keys.D2:
                    buttonClick = btn_Two; break;
                case Keys.D3:
                    buttonClick = btn_Three; break;
                case Keys.D4:
                    buttonClick = btn_Four; break;
                case Keys.D5:
                    buttonClick = btn_Five; break;
                case Keys.D6:
                    buttonClick = btn_Six; break;
                case Keys.D7:
                    buttonClick = btn_Seven; break;
                case Keys.D8:
                    buttonClick = btn_Eight; break;
                case Keys.D9:
                    buttonClick = btn_Nine; break;
                case Keys.Clear:
                    buttonClick = btn_CE; break;
                case Keys.Decimal:
                    buttonClick = btn_Percent; break;
                case Keys.Divide:
                    buttonClick = btn_Splitter; break;
                case Keys.Multiply:
                    buttonClick = btn_Multi; break;
                case Keys.Subtract:
                    buttonClick = btn_Minus; break;
                case Keys.Enter:
                    buttonClick = btn_Total; break;
                case Keys.Add:
                    buttonClick = btn_Plus; break;
                case Keys.Back:
                    buttonClick = btn_Backspace; break;

            }   
        }

/*         ПОЛДУМАТЬ, КАК ДОРАБОТАТЬ СОБЫТИЯ КЛАВИШ НА ТО, ЧТОБЫ ОНИ В ЗАВИСИМОСТИ ОТ ТОГО БЫЛА ЛИ ПОСЛЕДНЯЯ КЛАВИША НАЖАТА РАВНО ИЛИ НЕТ,
 *         ЕСЛИ КЛАВИША РАВНО БЫЛА НАЖАТА, ТО ПРИ НАЖАТИИ ЦИФРЫ, ОНА ЗАМЕНЯЕТ ВСЕ ЦИФРЫ, КОТОРЫЕ НАХОДЯТСЯ В ПОЛЕ, ЛИБО ЕСЛИ КЛАВИША НЕ БЫЛА
 *         НАЖАТА, ТО ЦИФРА ПРОСТО ДОПОЛНЯЕТСЯ К ЧИСЛУ

*/

        private void btn_Zero_Click_1(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "0";
        }

        private void btn_One_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "1";
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "2";
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "3";
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "4";
        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "5";
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "6";
        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "7";
        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "8";
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += "9";
        }


        private void btn_Comma_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text += ",";
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {

            FIRST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";
            SYMBOL = '+';
        }



        private void btn_Minus_Click(object sender, EventArgs e)
        {
            FIRST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";
            SYMBOL = '-';
        }


        private void btn_Splitter_Click(object sender, EventArgs e)
        {
            FIRST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";
            SYMBOL = '/';
        }

        private void btn_RemainderOfDivision_Click(object sender, EventArgs e)
        {
            FIRST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";
            SYMBOL = '%';
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            FIRST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";
            SYMBOL = '*';
        }

        
        // МЕТОД УДАЛЕНИЯ ОДНОГО ЭЛЕМЕНТА ИЗ ТЕКСТОВОГО ПОЛЯ
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            string number_del = tb_TotalCalc.Text;
            tb_TotalCalc.Text = "";
            string NewNumber = number.DeleteNumber(number_del);
            tb_TotalCalc.Text = NewNumber;
        }

        // МЕТОД ОТОБРАЖЕНИЯ ПРОТИВОПОЛОЖНОГО ЧИСЛА
        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            string numberPlus = tb_TotalCalc.Text;
            
            string numberOpposite = number.OppositeNumber(numberPlus);
            tb_TotalCalc.Text = numberOpposite;
        }



        // МЕТОД ПО ВЫПОЛНЕНИЯ РАСЧЕТА С ЧИСЛАМИ 
        private void btn_Total_Click(object sender, EventArgs e)
        {
            LAST_NUMBER = number.ParseNumber(tb_TotalCalc.Text);
            tb_TotalCalc.Text = "";

            Model model = new Model(FIRST_NUMBER, LAST_NUMBER, SYMBOL);

            TOTAL_NUMBER = model.CalcValue();


            tb_TotalCalc.Text = TOTAL_NUMBER.ToString();
        }




        // МЕТОД ОЧИСТКИ ПОЛЯ ВЫВОДА РЕЗУЛЬТАТА

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tb_TotalCalc.Text = "";
        }




    }
}
