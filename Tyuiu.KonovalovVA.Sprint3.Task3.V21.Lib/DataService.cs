﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonovalovVA.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                if(char.IsDigit(c)) value = value.Replace(c,item);
            }
            return value;
        }
    }
}
