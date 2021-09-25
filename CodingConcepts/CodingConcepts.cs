using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CodingConcepts
{
    public partial class CodingConcepts : Form
    {
        static string linkLink;

        static readonly string cCCText = File.ReadAllText("CCC.txt");
        static readonly string oOPText = File.ReadAllText("oOP.txt");

        static readonly string iterationsText = File.ReadAllText("Iterations.txt");
        static readonly string sequencesText = File.ReadAllText("sequences.txt");
        static readonly string selectionText = File.ReadAllText("selection.txt");
        static readonly string dataText = File.ReadAllText("data.txt");
        static readonly string methodText = File.ReadAllText("method.txt");

        static readonly string objectText = File.ReadAllText("object.txt");
        static readonly string fieldsText = File.ReadAllText("field.txt");
        static readonly string interfaceText = File.ReadAllText("interface.txt");
        static readonly string classesText = File.ReadAllText("classes.txt");
        static readonly string propertiesText = File.ReadAllText("properties.txt");
        static readonly string inheritanceText = File.ReadAllText("inheritance.txt");
        static readonly string abstractionText = File.ReadAllText("abstraction.txt");
        static readonly string encapsulationText = File.ReadAllText("encapsulation.txt");
        static readonly string polimorphysmText = File.ReadAllText("polimorphysm.txt");

        Button[] btnArray;

        public CodingConcepts()
        {
            InitializeComponent();
            btnArray = new Button[] { CCC_Button, OOP_Button, 
                iterationBtn, sequencesBtn, selectionBtn, dataBtn, methodsBtn, 
                objectsBtn, fieldsBtn, interfacesBtn, classesBtn, propertiesBtn, 
                inheritanceBtn, abstractionBtn, encapsulationBtn, polimorphysmBtn };
            startScreen();
        }

        readonly CodingConceptsClass cCC = new("Common Coding Concepts", cCCText, "cCC.png", "https://www.bbc.co.uk/bitesize/guides/zh66pbk/",0);
        readonly CodingConceptsClass oOP = new("Object Oriented Programing", oOPText, "OOPg.png", "https://www.w3schools.com/cs/cs_oop.php",1);

        readonly CodingConceptsClass iterations = new("Iterations", iterationsText, "iterations.png", "https://www.bbc.co.uk/bitesize/guides/z3khpv4/",2);
        readonly CodingConceptsClass sequences = new("Sequences", sequencesText, "sequences.png", "https://www.bbc.co.uk/bitesize/clips/zxy9d2p",3);
        readonly CodingConceptsClass selection = new("Selection", selectionText, "selection.png", "https://www.bbc.co.uk/bitesize/guides/z2p9kqt/",4);
        readonly CodingConceptsClass data = new("Data Types", dataText, "data.jfif", "https://www.bbc.co.uk/bitesize/guides/zc6s4wx/",5);
        readonly CodingConceptsClass methods = new("Methods", methodText, "method.jpg", "https://www.w3schools.com/cs/cs_methods.php",6);

        readonly CodingConceptsClass objects = new("Objects in OOP", objectText, "OOP.png", 
            "https://study.com/academy/lesson/oop-object-oriented-programming-objects-classes-interfaces.html",7);
        readonly CodingConceptsClass fields = new("Fields", fieldsText, "OOP.png", "https://www.techopedia.com/definition/1203/field-c",8);
        readonly CodingConceptsClass interfaces = new("Interface", interfaceText, "abstract-class-vs-interface.png", "https://www.geeksforgeeks.org/c-sharp-interface/",9);
        readonly CodingConceptsClass classes = new("Classes", classesText, "OOP.png", "https://www.geeksforgeeks.org/c-sharp-class-and-object/",10);
        readonly CodingConceptsClass properties = new("Properties", propertiesText, "OOP.png", "https://www.tutorialspoint.com/csharp/csharp_properties.htm",11);
        readonly CodingConceptsClass inheritance = new("Inheritance", inheritanceText, "inheritance.gif", "https://www.javatpoint.com/c-sharp-inheritance",12);
        readonly CodingConceptsClass abstraction = new("Abstraction", abstractionText, "abstraction.png", "https://www.guru99.com/java-data-abstraction.html",13);
        readonly CodingConceptsClass encapsulation = new("Encapsulation", encapsulationText, "encapsulation.png", "https://stackify.com/oop-concept-for-beginners-what-is-encapsulation/",14);
        readonly CodingConceptsClass polimorphysm = new("Polimorphysm", polimorphysmText, "polymorphism.png", "https://www.tutlane.com/tutorial/csharp/csharp-polymorphism",15);

        public Button[] BtnArray { get => btnArray; set => btnArray = value; }

        public void startScreen()
        {
            SetBtnVisibility(1);
            setBtnSettings(cCC);
        }
        private void resetBtnColor()
        {
            for (int i = 0; i < btnArray.Length; i++)
            {
                if (btnArray[i].Visible)
                {
                    if (btnArray[i].BackColor == Color.Coral)
                    {
                        btnArray[i].BackColor = Color.Gold;
                    }
                }
            }
        }
        private void SetBtnVisibility(int one=0)
        {
            for (int i = 2; i < btnArray.Length; i++)
            {
                if (one == 1)
                {
                    if (i < 7)
                    {
                        btnArray[i].Visible = true;
                    }
                    else
                    {
                        btnArray[i].Visible = false;
                    }
                }
                else
                {
                    if (i < 7)
                    {
                        btnArray[i].Visible = false;
                    }
                    else
                    {
                        btnArray[i].Visible = true;
                    }
                }
            }
        }
        private void InfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoLinkLabel.LinkVisited = true;

            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, linkLink);
        }
        private void iterationBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(iterations);
        }
        private void SequencesBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(sequences);
        }
        private void selectionBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(selection);
        }
        private void dataBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(data);
        }
        private void methodsBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(methods);
        }


        private void CCC_Button_Click(object sender, EventArgs e)
        {
            startScreen();
        }

        private void setBtnSettings(CodingConceptsClass name)
        {
            resetBtnColor();
            BtnArray[name.ButtonNum].BackColor = Color.Coral;
            titleLabel.Text = name.Title;
            infoLabel.Text = name.Info;
            pictureBox.Image = Image.FromFile(name.Image);
            infoLinkLabel.Text = name.LinkInfo;
            linkLink = name.LinkInfo;
        }

        private void OOP_Button_Click(object sender, EventArgs e)
        {
            SetBtnVisibility();
            setBtnSettings(oOP);
        }



        private void objectsBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(objects);
        }

        private void fieldsBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(fields);
        }

        private void interfacesBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(interfaces);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(classes);
        }

        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(properties);
        }

        private void inheritanceBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(inheritance);
        }

        private void abstractionBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(abstraction);
        }

        private void encapsulationBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(encapsulation);
        }

        private void polimorphysmBtn_Click(object sender, EventArgs e)
        {
            setBtnSettings(polimorphysm);
        }
    }
}