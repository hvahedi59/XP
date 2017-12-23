using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateApp
{
    public class CalculateService
    {
        static private List<float> memory = new List<float>();

        public void Clear()
        {

        }

        public float Calculate(string param)
        {
            System.Data.DataTable myDT = new System.Data.DataTable();
            return (float)myDT.Compute(param, null);
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
    }
}