using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_lab_7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bình phương của số lớn hơn 4:");
            List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };
            var kq1 = nums.Where(x => x > 4).Select(x => x * x);
            foreach (var num in kq1)
            {
                Console.WriteLine(num + " ");
            }

            string str1 = "Chào mừng đến với bình nguyên vô tận";
            var charFrequency = str1.GroupBy(c => c)
                                    .Select(g => new { Character = g.Key, Count = g.Count() })
                                    .OrderBy(item => item.Character);

            Console.WriteLine("\n\nTần suất xuất hiện kí tự: ");
            foreach (var item in charFrequency)
            {
                Console.WriteLine($"Ki tu '{item.Character}': {item.Count}");
            }

        }
    }
}
