using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyVisionKl
{
    class Data
    {
        /*
        DT= Fecha consulta
        TI= hora
        BT= ?
        GE = genero
        AG = age
        Hm = altura
        Al = ?
        Wk = peso
        MI = IMC
        FW = % grasa
        Fr = ?
        Fi = ?
        FR = ?
        FL = ?
        FT = ?
        Mw = Masa muscular
        mr = ?
        mi = ?
        mR = ?
        mL = ?
        mT = ?
        bW = masa osea estimada
        IF = grasa visceral
        rD = energia total
        rA = edad metabolica
        ww = % agua corporal
        CS = ? 
        */
        private string date;
        private string time;
        private string genre;
        private string age;
        private string high;
        private string weigth;
        private string imc;
        private string fat;
        private string muscle;
        private string bone;
        private string vis_fat;
        private string energy;
        private string met_age;
        private string water;
        
        public String Date
        {
            get { return date; }   
            set { date = value; }  
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string High
        {
            get { return high; }
            set { high = value; }
        }
        public string Weigth
        {
            get { return weigth; }
            set { weigth = value; }
        }

        public string Imc
        {
            get { return imc; }
            set { imc = value; }
        }
        public string Fat
        {
            get { return fat; }
            set { fat = value; }
        }

        public string Muscle
        {
            get { return muscle; }
            set { muscle = value; }
        }

        public string Bone
        {
            get { return bone; }
            set { bone = value; }
        }

        public string Vis_fat
        {
            get { return vis_fat; }
            set { vis_fat = value; }
        }

        public string Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        public string Met_age
        {
            get { return met_age; }
            set { met_age = value; }
        }

        public string Water
        {
            get { return water; }
            set { water = value; }
        }
    }
}
