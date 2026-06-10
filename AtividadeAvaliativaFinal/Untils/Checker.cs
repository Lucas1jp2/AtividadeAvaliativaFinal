using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Untils
{
    class Checker
    {
       // Check nums in text
        public static bool NumInText(string text)
        {
            try
            {
                char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                bool contains = false;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (text.Contains(nums[i]))
                    {
                        contains = true;
                        break;
                    }

                }

                return contains;
            }
            catch (Exception error)
            {
                ShowMessages.Error(error, "Check numbers in text.");
                return false;
            }
            
        }

        // Check CPF
        public static bool CPF(string CPF)
        {
            try
            {
                CPF = CPF.Replace(".", "").Replace(",", "").Replace("-", "");
                char[] CPFChar = CPF.ToCharArray();

                if (CPFChar.Length != 11)
                {
                    ShowMessages.InvalidData("CPF");
                    return false;
                }
                else
                {
                    char checkNum1 = CPFChar[9], checkNum2 = CPFChar[10];
                    int nums = 10, counter = 0, calcNum1, calcNum2;
                    Array.Resize(ref CPFChar, CPFChar.Length - 2);

                    // Check num 1
                    foreach (char num in CPFChar) 
                    {
                        counter += (Convert.ToInt32(num) * nums);
                        nums--;
                    }

                    calcNum1 = counter % 11;

                    if (calcNum1 < 2) calcNum1 = 0; 
                    else calcNum1 = 11 - calcNum1;

                    if (calcNum1 != Convert.ToInt16(checkNum1)) return false;
                    else
                    {
                        // Check num 2
                        nums = 11; 
                        counter = 0;
                        CPFChar[CPFChar.Length - 1] = checkNum1;

                        foreach (char num in CPFChar)
                        {
                            counter += (Convert.ToInt32(num) * nums);
                            nums--;
                        }

                        calcNum2 = counter % 11;

                        if (calcNum2 < 2) calcNum1 = 0;
                        else calcNum2 = 11 - calcNum2;

                        if (calcNum2 != Convert.ToInt16(checkNum2)) return false;
                        else return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar CPF.");
                return false;
            }
        }
    }
}
