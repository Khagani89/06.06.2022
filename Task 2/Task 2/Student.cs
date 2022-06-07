using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class Student
    {
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }

        public static int TotalCount;

        public int No { get; }
        public string FullName;
        private string _groupNo;

        public string GroupNo
        {
            get => _groupNo;
            set 
            {
            if(CheckGroupNo(value))
             _groupNo = value;
            }

        }
        public bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && GroupNo.Length == 4)
            {
                if (char.IsLetter(groupNo[0]))
                    for (int i = 1; i < groupNo.Length; i++)
                    {
                        if (!char.IsDigit(groupNo[i]))
                            return false;
                    }
                return true;
            }
             return false;
        }
           
    }
}
