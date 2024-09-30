using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        databaseHandler db;
        public Form1()
        {
            InitializeComponent();
            db = new databaseHandler();
            db.readaAll();
            car onecar = new car();
            onecar.color = "piros";
            onecar.make = "vw";
            onecar.hp = 500;
            onecar.model = "Bogar";
            onecar.year = 1973;
            db.Addone(onecar);
        }
    }
}
