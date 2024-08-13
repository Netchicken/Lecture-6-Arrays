using System.Diagnostics;

namespace Lecture_6_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringReference();
            intValue();
            ArrayReference();

        }


        private void StringReference()
        {
            //Initially, str1 and str2 both reference the same string "Hello".
            string str1 = "Hello";
            string str2 = str1; // str2 references the same string as str1

            Debug.WriteLine("Before modification:");
            Debug.WriteLine("str1 " + str1); // Output: Hello
            Debug.WriteLine("str2 " + str2); // Output: Hello

            str2 = "World"; // str2 now references a new string
            //When str2 is assigned a new value "World", it references a new string, while str1 still references the original string "Hello"
            Debug.WriteLine("After modification:");
            Debug.WriteLine("str1 " + str1); // Output: Hello
            Debug.WriteLine("str2 " + str2); // Output: World




        }

        private static void ArrayReference()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1; // array2 references the same array as array1

            Debug.WriteLine("array1 " + array1[0]); // Output: 1
            Debug.WriteLine("array2 " + array2[0]); // Output: 1

            array2[0] = 10; // Changing array2 also changes array1

            Debug.WriteLine("array1 " + array1[0]); // Output: 10
            Debug.WriteLine("array2 " + array2[0]); // Output: 10
        }

        private void intValue()
        {
            int a = 10;
            int b = a; // b is now a just a copy of a. Its has its own memoery place and just copied the value of a over
            b = 20;
            Debug.WriteLine(a); // Output: 10
            Debug.WriteLine(b); // Output: 20
        }



    }





}

