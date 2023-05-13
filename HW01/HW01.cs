using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class ImyaFamylya
{
    static void Main()
    {
        string name, surname, txt;
        name = Interaction.InputBox("Введите ваше имя", "Ваше имя");
        surname = Interaction.InputBox("Введите ваше фамилию", "Ваша фамилия");
        txt = "Фамилия: " + surname + " Имя: " + name + ".";
        MessageBox.Show(txt, "Карточка работника");
    }
}
