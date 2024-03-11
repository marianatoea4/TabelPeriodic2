using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelPeriodic2
{
    public partial class Form2 : Form
    {
        string adresa = "https://ro.wikipedia.org/wiki/";

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(string txt)
        {           
            switch(txt)
            {
                case "H":
                    adresa += "Hidrogen";
                    break;
                case "Li":
                    adresa += "Litiu";
                    break;
                case "Na":
                    adresa += "Sodiu";
                    break;
                case "K":
                    adresa += "Potasiu";
                    break;
                case "Rb":
                    adresa += "Rubidiu";
                    break;
                case "Cs":
                    adresa += "Cesiu";
                    break;
                case "Fr":
                    adresa += "Franciu";
                    break;
                case "Be":
                    adresa += "Beriliu";
                    break;
                case "Mg":
                    adresa += "Magneziu";
                    break;
                case "Ca":
                    adresa += "Calciu";
                    break;
                case "Sr":
                    adresa += "Strontiu";
                    break;
                case "Ba":
                    adresa += "Bariu";
                    break;
                case "Ra":
                    adresa += "Radiu";
                    break;
                case "Sc":
                    adresa += "Scandiu";
                    break;
                case "Y":
                    adresa += "Ytriu";
                    break;
                case "Lantanide":
                    adresa += "Lantanide";
                    break;
                case "Actinide":
                    adresa += "Actinide";
                    break;
                case "Ti":
                    adresa += "Titan";
                    break;
                case "Zr":
                    adresa += "Zirconiu";
                    break;
                case "Hf":
                    adresa += "Hafniu";
                    break;
                case "Rf":
                    adresa += "Rutherfordiu";
                    break;
                case "V":
                    adresa += "Vanadiu";
                    break;
                case "Nb":
                    adresa += "Niobiu";
                    break;
                case "Ta":
                    adresa += "Tantal";
                    break;
                case "Db":
                    adresa += "Dubniu";
                    break;
                case "Cr":
                    adresa += "Crom";
                    break;
                case "Mo":
                    adresa += "Molibden";
                    break;
                case "w":
                    adresa += "Wolfram";
                    break;
                case "Sg":
                    adresa += "Seaborgiu";
                    break;
                case "Mn":
                    adresa += "Mangan";
                    break;
                case "Tc":
                    adresa += "Technetiu";
                    break;
                case "Re":
                    adresa += "Reniu";
                    break;
                case "Bh":
                    adresa += "Bohriu";
                    break;
                case "Fe":
                    adresa += "Fier";
                    break;
                case "Ru":
                    adresa += "Ruteniu";
                    break;
                case "Os":
                    adresa += "Osmiu";
                    break;
                case "Hs":
                    adresa += "Hassiu";
                    break;
                case "Co":
                    adresa += "Cobalt";
                    break;
                case "Rh":
                    adresa += "Rodiu";
                    break;
                case "Ir":
                    adresa += "Iridiu";
                    break;
                case "Mt":
                    adresa += "Meitneriu";
                    break;
                case "Ni":
                    adresa += "Nichel";
                    break;
                case "Pd":
                    adresa += "Paladiu";
                    break;
                case "Pt":
                    adresa += "Platina";
                    break;
                case "Ds":
                    adresa += "Darmstadtiu";
                    break;
                case "Cu":
                    adresa += "Cupru";
                    break;
                case "Ag":
                    adresa += "Argint";
                    break;
                case "Au":
                    adresa += "Aur";
                    break;
                case "Rg":
                    adresa += "Roentgeniu";
                    break;
                case "Zn":
                    adresa += "Zinc";
                    break;
                case "Cd":
                    adresa += "Cadmiu";
                    break;
                case "Hg":
                    adresa += "Mercur";
                    break;
                case "Cn":
                    adresa += "Coperniciu";
                    break;
                case "B":
                    adresa += "Bor";
                    break;
                case "Al":
                    adresa += "Aluminiu";
                    break;
                case "Ga":
                    adresa += "Galiu";
                    break;
                case "In":
                    adresa += "Indiu";
                    break;
                case "Tl":
                    adresa += "Taliu";
                    break;
                case "Nh":
                    adresa += "Nihoniu";
                    break;
                case "C":
                    adresa += "Carbon";
                    break;
                case "Si":
                    adresa += "Siliciu";
                    break;
                case "Ge":
                    adresa += "Germaniu";
                    break;
                case "Sn":
                    adresa += "Staniu";
                    break;
                case "Pb":
                    adresa += "Plumb";
                    break;
                case "Fl":
                    adresa += "Fleroviu";
                    break;
                case "N":
                    adresa += "Azot";
                    break;
                case "P":
                    adresa += "Fosfor";
                    break;
                case "As":
                    adresa += "Arsen";
                    break;
                case "Sb":
                    adresa += "Stibiu";
                    break;
                case "Bi":
                    adresa += "Bismut";
                    break;
                case "Mc":
                    adresa += "Moscoviu";
                    break;
                case "O":
                    adresa += "Oxigen";
                    break;
                case "S":
                    adresa += "Sulf";
                    break;
                case "Se":
                    adresa += "Seleniu";
                    break;
                case "Te":
                    adresa += "Telur";
                    break;
                case "Po":
                    adresa += "Poloniu";
                    break;
                case "Lv":
                    adresa += "Livermoriu";
                    break;
                case "F":
                    adresa += "Fluor";
                    break;
                case "Cl":
                    adresa += "Clor";
                    break;
                case "Br":
                    adresa += "Brom";
                    break;
                case "I":
                    adresa += "Iod";
                    break;
                case "At":
                    adresa += "Astatin";
                    break;
                case "Ts":
                    adresa += "Tennessine";
                    break;
                case "He":
                    adresa += "Heliu";
                    break;
                case "Ne":
                    adresa += "Neon";
                    break;
                case "Ar":
                    adresa += "Argon";
                    break;
                case "Kr":
                    adresa += "Kripton";
                    break;
                case "Xe":
                    adresa += "Xenon";
                    break;
                case "Rn":
                    adresa += "radon";
                    break;
                case "Og":
                    adresa += "Ogannesson";
                    break;
                case "La":
                    adresa += "Lantan";
                    break;
                case "Ce":
                    adresa += "Ceriu";
                    break;
                case "Pr":
                    adresa += "Praseodim";
                    break;
                case "Nd":
                    adresa += "Neodim";
                    break;
                case "Pm":
                    adresa += "Prometiu";
                    break;
                case "Sm":
                    adresa += "Samariu";
                    break;
                case "Eu":
                    adresa += "Europiu";
                    break;
                case "Gd":
                    adresa += "Gadoliniu";
                    break;
                case "Tb":
                    adresa += "Terbiu";
                    break;
                case "Dy":
                    adresa += "Disprosiu";
                    break;
                case "Ho":
                    adresa += "Holmiu";
                    break;
                case "Er":
                    adresa += "Erbiu";
                    break;
                case "Tm":
                    adresa += "Tuliu";
                    break;
                case "Yb":
                    adresa += "Yterbiu";
                    break;
                case "Lu":
                    adresa += "Lutetiu";
                    break;
                case "Ac":
                    adresa += "Actiniu";
                    break;
                case "Th":
                    adresa += "Thoriu";
                    break;
                case "Pa":
                    adresa += "Protactiniu";
                    break;
                case "U":
                    adresa += "Uraniu";
                    break;
                case "Np":
                    adresa += "Neptuniu";
                    break;
                case "Pu":
                    adresa += "Plutoniu";
                    break;
                case "Am":
                    adresa += "Americiu";
                    break;
                case "Cm":
                    adresa += "Curiu";
                    break;
                case "Bk":
                    adresa += "Berkeliu";
                    break;
                case "Cf":
                    adresa += "Californiu";
                    break;
                case "Es":
                    adresa += "Einsteiniu";
                    break;
                case "Fm":
                    adresa += "Fermiu";
                    break;
                case "Md":
                    adresa += "Mendeleviu";
                    break;
                case "No":
                    adresa += "Nobeliu";
                    break;
                case "Lr":
                    adresa += "Lawrenciu";
                    break;
            }
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(adresa);
        }
    }
}
