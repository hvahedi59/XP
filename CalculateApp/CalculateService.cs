using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateApp
{
    public class CalculateService
    {
        static private List<float> memory = new List<float>();
        static private List<string> History = new List<string>();

        public void Clear()
        {
        }

        public string Calculate(string param)
        {
            History.Add(param);
            System.Data.DataTable myDT = new System.Data.DataTable();
            return myDT.Compute(param, null).ToString();
        }

        public void ClearMemory()
        {
            memory.Clear();
        }

        /// <summary>
        /// با محدودیت ذخیره یک عدد در حافظه
        /// </summary>
        /// <param name="param"></param>
        public void SaveMemory(float param)
        {
            if (memory.Count == 0)
                memory.Add(param);
            else
                memory[0] = param;
        }

        public float? ReadMemory(byte index)
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