using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StradaniaGroup stradaniaGroup = new StradaniaGroup(new Student("Влад"), new Student("Лада"));

            //IEnumerable myGroup = stradaniaGroup;

            foreach(Student student in stradaniaGroup)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public Student(string firstName)
        {
            this.FirstName = firstName;
        }
    }


    public class StradaniaGroup : IEnumerable
    {
        Student[] moiRodnue;

        public StradaniaGroup(params Student[] student)
        {
            moiRodnue = student;
        }

        public IEnumerator GetEnumerator()
        {
            return new StudentEnum(moiRodnue);

        }
    }



    public class StudentEnum : IEnumerator
    {
        Student[] studentInGrop;

        int position = -1;

        public StudentEnum(Student[] studentInGrop)
        {
            this.studentInGrop = studentInGrop;
        }

        public bool MoveNext()
        {
            position++;

            if(position < studentInGrop.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return studentInGrop[position];
            }
        }
    }
}

