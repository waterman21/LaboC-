using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplicationLabo1
{
    public class Pupil : Person 
    {
        //grade (int) + tabeEval : char[10]

        private List<Activity> lstActivities;

        public delegate string DelegatePrintActivityCompulsory(Activity activity);

        public int Grade { get; set; }

        public char [] pupilEvaluations { get; set; }

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        public Pupil (String name, int age, int grade) : base (name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            pupilEvaluations = new char[Parameter.MAX];
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity (Activity activity)
        {
            LstActivities.Add(activity);
        }

        public override string ToString()
        {
            string ch = Header();
            ch = PrintActivitiesPupil(ch);
             return ch;
        }

        private string PrintActivitiesPupil(string ch)
        {
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " a choisi comme activité : ";
                foreach (Activity activity in LstActivities)
                    ch += "- " + activity.ToString() + "\n";
            }

            ch += "\n";
            return ch;
        }

        private string Header()
        {
            return base.ToString();
        }

        public void AddEvalutation(String title = null, char evaluation = (char)Parameter.enumeEval.Satisfaisant)
        {
            for (int i = 0; i < pupilEvaluations.Length && i < LstActivities.Count(); i++)
            {
                if (LstActivities.ElementAt(i).Equals(title) && i < Parameter.MAX)
                {
                    pupilEvaluations[i] = evaluation;
                }
            }
        }

        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numAct = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach (Activity activity in LstActivities)
                if (activity.Compulsory)
                    ch += (++numAct) + " " + MyPrintActivity(activity);
            return ch;
        }
    }
}
