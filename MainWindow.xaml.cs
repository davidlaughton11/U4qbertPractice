/*David laughton
 * arpirl 24 2019
 * practice for qBert program
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U4qbertPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variables avalable in all methods
        int[] myMarks = new int[4];

        int[,] cubes = new int[3, 5];
        // marks for four courses
        public MainWindow()
        {
            InitializeComponent();
            int num, space;

            while (true)
            {
                Console.Write("Enter a number between 1 to 9 : ");

                num = Convert.ToInt32(Console.ReadLine());

                space = num - 1;

                for (int i = 1; i <= num; i++)
                {
                    for (space = 1; space <= (num - i); space++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }

                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write(k);
                    }

                    Console.WriteLine();

                }
            }
            for (int x = 0; x < cubes.GetLength(0); x++)
            {
                for (int y = 0; y < cubes.GetLength(1); y++)
                {
                    cubes[x, y] = -1;
                }
            }
            
            for (int y = 0; y < cubes.GetLength(1); y++)
            {
                for (int x = 0; x < cubes.GetLength(0); x++)
                {
                    Console.Write(cubes[x, y]);
                }
                Console.WriteLine();
            }
            



            //do it here assigning values for marks 
            myMarks[0] = 81;
            myMarks[1] = 50;
            myMarks[2] = 95;
            myMarks[3] = 87;
            //last value is one less than the int 
            int total = 0;
            int average;
            for (int i = 0; i < myMarks.Length; i++)
            {
                total += myMarks[i];
            }
            //MessageBox.Show("total: " + total.ToString());
            average = total / myMarks.Length;
            //MessageBox.Show("average: " + average.ToString());
        }
    }
}
