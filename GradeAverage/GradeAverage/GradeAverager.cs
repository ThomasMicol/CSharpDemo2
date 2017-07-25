using System;

namespace GradeAverage
{
    class GradeAverager
    {
        protected Int16 studentNumber;
        protected int[] studGrades;
        protected double totalGrade;
        protected double gradeAverage;

        public void setStudentNumber(Int16 studNum)
        {
            studentNumber = studNum;
            studGrades = new int[studentNumber];
        }

        public Int16 getStudentNumber()
        {
            return studentNumber;
        }

        public void setStudentGrade(int studentNumber, int studentGrade)
        {
            studGrades[studentNumber] = studentGrade;
            totalGrade += studentGrade;
        }

        protected void calculateGradeAverage()
        {
            gradeAverage = totalGrade / studentNumber;
        }

        public double getGradeAverage()
        {
            calculateGradeAverage();
            return gradeAverage;
        }


    }
}