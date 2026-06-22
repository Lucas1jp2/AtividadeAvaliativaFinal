using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Untils
{
    class Checker
    {
        // # Check nums in text
        public static bool NumInText(string text)
        {
            try
            {
                foreach (char c in text.ToCharArray())
                {
                    if (Convert.ToInt16(c) >= 48 && Convert.ToInt16(c) <= 57) return true;
                }
                

                return false;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Check numbers in text");
                return false;
            }
            
        }

        // # Check text in nums
        public static bool TextInNums(string nums)
        {
            try
            {
                foreach (char c in nums.ToCharArray())
                {
                    if (Convert.ToInt16(c) < 48 && Convert.ToInt16(c) > 57) return true;
                }


                return false;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Check text in numbers");
                return false;
            }

        }
        
        // # Check text in nums
        public static bool ValidEmail(string email)
        {
            try
            {
                if(!email.Contains("@"))
                {
                    ShowMessages.InvalidData("Email");
                    return false;
                }
                else
                {
                    string domain = email.Split('@')[1];

                    if (domain.Contains(".com") || domain.Contains(".com.br")) return true;
                    else
                    {
                        ShowMessages.InvalidData("Email");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Check text in numbers");
                return false;
            }

        }

        // # Check phone
        public static bool ValidPhone(string phone)
        {
            try
            {
                phone = phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                if (TextInNums(phone))
                {
                    ShowMessages.InvalidData("Phone Number");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Check phone number");
                return false;
            }

        }

        // # Check CPF
        public static bool ValidCPF(string CPF)
        {
            try
            {
                // Check nums
                if ((CPF == "000.000.000-00" || CPF == "000.000.000-01"))
                {
                    ShowMessages.InvalidData("CPF");
                    return false;
                }
                else
                {
                    if (CPF.Length != 14)
                    {
                        ShowMessages.InvalidData("CPF");
                        return false;
                    }
                    else
                    {
                        CPF = CPF.Replace(".", "").Replace(",", "").Replace("-", "");

                        if (TextInNums(CPF))
                        {
                            ShowMessages.InvalidData("CPF");
                            return false;
                        }
                        else
                        {
                            char[] CPFChar = CPF.ToCharArray();

                            // -- Check vnum 1 --

                            char checkNum1 = CPFChar[9], checkNum2 = CPFChar[10];
                            int nums = 10, counter = 0, calcNum1, calcNum2;
                            Array.Resize(ref CPFChar, CPFChar.Length - 2);

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
                                // -- Check vnum 2 --
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
                }
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Check CPF");
                return false;
            }
        }
    }
}
