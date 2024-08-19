using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;

namespace Lecture_6_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  StringReference();
            //  intValue();
            //  ArrayReference();
            //  DeclareANewArray();


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
            //This unique combination of being a reference type with value type-like behavior due to immutability is what makes string special in C#

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
            int b = a; // b is now a just a copy of a. Its has its own memory place and just copied the value of a over
            b = 20;
            Debug.WriteLine(a); // Output: 10
            Debug.WriteLine(b); // Output: 20
        }


        private void DeclareANewArray()
        {




        }

        private void lbxArrays_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxArrays.Items.Clear();
        }

        private void btnSimpleArray_Click(object sender, EventArgs e)
        {
            //  const int SIZE = 5;

            //simpleArray[0] = 1;
            //simpleArray[1] = 2;
            //simpleArray[2] = 3;
            //simpleArray[3] = 4;
            //simpleArray[4] = 5;

            //add your array to a listbox
            // lbxArrays.Items.AddRange(simpleArray.Cast<object>().ToArray());


            var simpleArray = new int[] { 1, 2, 3, 4, 5 };

            //use a foreach to display arrays and lists
            int count = 0;
            foreach (int item in simpleArray)
            {
                lbxArrays.Items.Add(count + " simpleArray = " + item);
                count++;

            }


            //use a For loop to display your array
            for (int i = 0; i < simpleArray.Length; i++)
            {
                //     lbxArrays.Items.Add(i + " simpleArray = " + simpleArray[i]);
            }


            List<int> simpleList = new List<int> { 1, 2, 3, 4, 5, 6 };

            lbxArrays.Items.AddRange(simpleList.Cast<object>().ToArray());


        }


        private void btnWriteArrayToFile_Click(object sender, EventArgs e)
        {
            // Create an array of names and addresses
            string[] people = new string[]
            {
             "John Doe 123 Main St, Springfield, IL" ,
             "Jane Smith 456 Elm St, Shelbyville, IL" ,
             "Alice Johnson 789 Oak St, Capital City, IL" ,
             "Bob Brown 101 Maple St, Ogdenville, IL" ,
             "Charlie Davis 202 Pine St, North Haverbrook, IL" ,
             "Diana Evans 303 Cedar St, Brockway, IL" ,
             "Ethan Foster 404 Birch St, Springfield, IL" ,
             "Fiona Green 505 Walnut St, Shelbyville, IL" ,
             "George Harris 606 Chestnut St, Capital City, IL" ,
             "Hannah King 707 Ash St, Ogdenville, IL"
            };

            // Path to the output file
            string filePath = "names_and_addresses.txt";

            // Write the array to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string person in people)
                {
                    writer.WriteLine(person);
                }
            }




            //for (int i = 0; i < people.Length; i++)
            //{
            //    writer.WriteLine($"{people[i]}");
            //}


        }

        private void btnReadDataIn_Click(object sender, EventArgs e)
        {
            // Path to the file
            string filePath = "names_and_addresses.txt";

            // Array to store lines temporarily
            string[] lines = File.ReadAllLines(filePath);

            //write a range to the listbox
            lbxArrays.Items.AddRange(lines.Cast<object>().ToArray());
            //write individually to listbox
            foreach (string line in lines)
            {
                lbxArrays.Items.Add("add line " + line);
            }
        }

        private void btn2DArray_Click(object sender, EventArgs e)
        {
            // Initialize a 2D array with specific values
            int[,] data = {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9,10,11,12 }
                            };

            //use a nested for loop to get each element out

            for (int i = 0; i < data.GetLength(0); i++) // Iterate through rows
            {
                for (int j = 0; j < data.GetLength(1); j++) // Iterate through columns
                {
                    //load the data at that point data[row,column]
                    lbxArrays.Items.Add(data[i, j]);
                }
            }
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            // Create and initialize a list
            List<int> data = new List<int> { 60, 76, 5, 10, 15, 20, 25 };

            // Add elements
            data.Add(30);
            data.AddRange(new int[] { 35, 40 });

            // Access and modify elements
            lbxArrays.Items.Add("First element: " + data[0]);
            data[1] = 12;

            // Remove elements
            data.Remove(15);
            data.RemoveAt(2);

            // Check for elements
            bool containsTwenty = data.Contains(20);
            lbxArrays.Items.Add("Contains 20: " + containsTwenty);

            // Iterate through the list
            lbxArrays.Items.Add("List elements:");
            foreach (int number in data)
            {
                lbxArrays.Items.Add(number);
            }

            // Sort and reverse the list
            data.Sort();
            data.Reverse();

            // Display the sorted and reversed list
            lbxArrays.Items.Add("Sorted and reversed list:");
            foreach (int number in data)
            {
                lbxArrays.Items.Add(number);
            }
        }
    }



}

