using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    class GradeAverageController
    {
        protected IView view;
        protected GradeAverager averager;

        public GradeAverageController(IView theView, GradeAverager theAverager)
        {
            view = theView;
            averager = theAverager;
        }

        public void go()
        {
            view.start();
            averager.setStudentNumber(view.getInt("Enter the number of students: "));
            for(int i = 0; i < averager.getStudentNumber(); i++)
            {
                int studNum = i + 1;
                int studGrade = view.getInt("Enter the grade for student " + studNum + ": ");
                while(studGrade > 100 || studGrade < 0)
                {
                    studGrade = view.getInt("That number was invalid. Please enter a number between 0 and 100: ");
                }
                averager.setStudentGrade(i, studGrade);
            }
            view.show("The Average is: " + averager.getGradeAverage().ToString(".0"));
            view.stop();

        }
    }

}
