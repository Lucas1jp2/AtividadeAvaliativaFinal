using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtividadeAvaliativaFinal.Untils
{
    internal class ShowMessages
    {
        public static void Error(Exception error, string? type = "", string? descripton = "")
        {
            string template = "[ ERR0R ] ";

            if (type.Length > 0) template += type;
            if (descripton.Length > 0) template += $"\n{descripton}";

            else MessageBox.Show($"{template} \n\n{error.Message}");
        }
        public static void InvalidData(string field)
        {
            string template = "[ WRONG FIELD ] ";
            MessageBox.Show($"{template} O campo '{field}' possui dados inválidos/incorretos.");
        }
    }
}
