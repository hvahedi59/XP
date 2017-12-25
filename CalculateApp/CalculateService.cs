using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CalculateApp
{
    public class CalculateService
    {
        static private List<string> memory = new List<string>();
        static private List<string> History = new List<string>();

        public void Clear()
        {
        }

        public string Calculate(string param)
        {
            try
            {

                if (param.Trim() == string.Empty) return "0";
                History.Add(param);
                System.Data.DataTable myDT = new System.Data.DataTable();
                return myDT.Compute(param, null).ToString();

            }
            catch (Exception)
            {

                throw new ArgumentException();
            }
        }

        public string Calculate2(string param)
        {
            try
            {
                if (param.Trim() == string.Empty) return "0";

                if (param.Contains("^"))
                {
                    var list = param.Split('^');
                    if (list.Count() == 2)
                    {
                        var num1 = this.Calculate2(list[0]);
                        var num2 = this.Calculate2(list[1]);

                        var result = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2));
                        return result.ToString();
                    }
                }

                History.Add(param);
                System.Data.DataTable myDT = new System.Data.DataTable();
                return myDT.Compute(param, null).ToString();

            }
            catch (Exception)
            {

                throw new ArgumentException();
            }
        }

        public void ClearMemory()
        {
            memory.Clear();
        }

        /// <summary>
        /// با محدودیت ذخیره یک عدد در حافظه
        /// </summary>
        /// <param name="param"></param>
        public void SaveMemory(string param)
        {
            if (memory.Count == 0)
                memory.Add(param);
            else
                memory[0] = param;
        }

        public string ReadMemory(byte index)
        {
            if (index >= 0 && index < memory.Count)
            {
                return memory[index];
            }
            else
            {
                return null;
            }
        }

        public string FetchHistory(int index)
        {
            if (History.Count == 0)
                return string.Empty;
            if (History.Count < index)
                return string.Empty;
            return History[index];
        }

        public int GetHistoryLength()
        {
            return History.Count();
        }
    }
}