using System;

namespace RotateTable
{
    class RotateTable
    {
        static void Main(string[] args) 
        {
            int[] table = new int[100];
            for (int i = 0; i < table.Length; i++) {
                table[i] = i+1;
            }

            WriteArray(table);
            Rotate_Table(table, 65);
            WriteArray(table);
        }

        static int[] Rotate_Table(int[] table, int turns) {
            for (int i = 0; i < turns; i++) {
                int first = table[0];
                for (int j = 0; j < table.Length -1; j++) {
                    table[j] = table[j+1];
                }
                table[table.Length - 1] = first;
            }
            return table;
        }

        static void WriteArray(int[] table) {
            for (int i = 0; i < table.Length; i++) {
                Console.Write(table[i] + " ");
            }
            Console.WriteLine();
        }
    }
}