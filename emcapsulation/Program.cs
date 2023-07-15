using System;
using System.Collections.Generic;

namespace mahasiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();//this is for storing data from mahasiswa class

            Console.WriteLine("Enter the number of students");// to enter the number of student and the value
            int jumlah = Convert.ToInt32(Console.ReadLine());// to declare variabel and set the variable to 0 , for summing the nilai
            int totalScore = 0;

            for (int i = 0; i < jumlah; i++)// loops for storing the value of student, like name ,nim,course, and score
            {
                Console.WriteLine("===============================");
                Mahasiswa mahasiswa = new Mahasiswa();

                Console.WriteLine("ENTER NAME: ");
                string name = Console.ReadLine();//can allow user to input the instance
                mahasiswa.SetName(name);// for stored name to the prvate field name

                Console.WriteLine("Enter student number: ");
                string npm = Console.ReadLine();
                mahasiswa.SetNim(npm);

                Console.WriteLine("ENTER COURSE: ");
                string pelajaran = Console.ReadLine();
                mahasiswa.SetMatkul(pelajaran);

                Console.WriteLine("Enter score: ");
                int score = Convert.ToInt32(Console.ReadLine());
                mahasiswa.SetNilai(score);

                totalScore += score;
                mahasiswaList.Add(mahasiswa);
            }

            Console.WriteLine("=========== Student Data ===========");

            foreach (Mahasiswa mahasiswa in mahasiswaList)// to displayng every input on the loop above
            {
                Console.WriteLine("Name: " + mahasiswa.GetName());
                Console.WriteLine("Score: " + mahasiswa.GetNilai());
                Console.WriteLine("NIM : " + mahasiswa.GetNim());
                Console.WriteLine("===============================");
            }

            double averageScore = (double)totalScore / mahasiswaList.Count;// the total score is called and divided by the number of students using mahasiswaList.count
            Console.WriteLine("Average Score: " + averageScore);
        }
    }
}
