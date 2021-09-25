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

        readonly CodingConceptsClass cCC = new("Common Coding Concepts", cCCText, "cCC.png", "https://www.bbc.co.uk/bitesize/guides/zh66pbk/");
        readonly CodingConceptsClass oOP = new("Object Oriented Programing", oOPText, "OOPg.png", "https://www.w3schools.com/cs/cs_oop.php");

        readonly CodingConceptsClass iterations = new("Iterations", iterationsText, "iterations.png", "https://www.bbc.co.uk/bitesize/guides/z3khpv4/");
        readonly CodingConceptsClass sequences = new("Sequences", sequencesText, "sequences.png", "https://www.bbc.co.uk/bitesize/clips/zxy9d2p");
        readonly CodingConceptsClass selection = new("Selection", selectionText, "selection.png", "https://www.bbc.co.uk/bitesize/guides/z2p9kqt/");
        readonly CodingConceptsClass data = new("Data Types", dataText, "data.jfif", "https://www.bbc.co.uk/bitesize/guides/zc6s4wx/");
        readonly CodingConceptsClass methods = new("Methods", methodText, "method.jpg", "https://www.w3schools.com/cs/cs_methods.php");

        readonly CodingConceptsClass objects = new("Objects in OOP", objectText, "OOP.png", 
            "https://study.com/academy/lesson/oop-object-oriented-programming-objects-classes-interfaces.html");
        readonly CodingConceptsClass fields = new("Fields", fieldsText, "OOP.png", "https://www.techopedia.com/definition/1203/field-c");
        readonly CodingConceptsClass interfaces = new("Interface", interfaceText, "abstract-class-vs-interface.png", "https://www.geeksforgeeks.org/c-sharp-interface/");
        readonly CodingConceptsClass classes = new("Classes", classesText, "OOP.png", "https://www.geeksforgeeks.org/c-sharp-class-and-object/");
        readonly CodingConceptsClass properties = new("Properties", propertiesText, "OOP.png", "https://www.tutorialspoint.com/csharp/csharp_properties.htm");
        readonly CodingConceptsClass inheritance = new("Inheritance", inheritanceText, "inheritance.gif", "https://www.javatpoint.com/c-sharp-inheritance");
        readonly CodingConceptsClass abstraction = new("Abstraction", abstractionText, "abstraction.png", "https://www.guru99.com/java-data-abstraction.html");
        readonly CodingConceptsClass encapsulation = new("Encapsulation", encapsulationText, "encapsulation.png", "https://stackify.com/oop-concept-for-beginners-what-is-encapsulation/");
        readonly CodingConceptsClass polimorphysm = new("Polimorphysm", polimorphysmText, "polymorphism.png", "https://www.tutlane.com/tutorial/csharp/csharp-polymorphism");

        public void startScreen()
        {
            SetBtnVisibility(1);
            resetBtnColor();
            CCC_Button.BackColor = Color.Coral;
            titleLabel.Text = cCC.Title;
            infoLabel.Text = cCC.Info;
            pictureBox.Image = Image.FromFile(cCC.Image);
            infoLinkLabel.Text = cCC.LinkInfo;
            linkLink = cCC.LinkInfo;
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
            for (int i = 0; i < btnArray.Length; i++)
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
                    if (i > 1 && i < 7)
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
            resetBtnColor();
            iterationBtn.BackColor = Color.Coral;
            titleLabel.Text = iterations.Title;
            infoLabel.Text = iterations.Info;
            pictureBox.Image = Image.FromFile(iterations.Image);
            infoLinkLabel.Text = iterations.LinkInfo;
            linkLink = iterations.LinkInfo;
        }
        private void SequencesBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            sequencesBtn.BackColor = Color.Coral;
            titleLabel.Text = sequences.Title;
            infoLabel.Text = sequences.Info;
            pictureBox.Image = Image.FromFile(sequences.Image);
            infoLinkLabel.Text = sequences.LinkInfo;
            linkLink = sequences.LinkInfo;
        }
        private void selectionBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            selectionBtn.BackColor = Color.Coral;
            titleLabel.Text = selection.Title;
            infoLabel.Text = selection.Info;
            pictureBox.Image = Image.FromFile(selection.Image);
            infoLinkLabel.Text = selection.LinkInfo;
            linkLink = selection.LinkInfo;
        }
        private void dataBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            dataBtn.BackColor = Color.Coral;
            titleLabel.Text = data.Title;
            infoLabel.Text = data.Info;
            pictureBox.Image = Image.FromFile(data.Image);
            infoLinkLabel.Text = data.LinkInfo;
            linkLink = data.LinkInfo;
        }
        private void methodsBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            methodsBtn.BackColor = Color.Coral;
            titleLabel.Text = methods.Title;
            infoLabel.Text = methods.Info;
            pictureBox.Image = Image.FromFile(methods.Image);
            infoLinkLabel.Text = methods.LinkInfo;
            linkLink = methods.LinkInfo;
        }
        private void CCC_Button_Click(object sender, EventArgs e)
        {
            startScreen();
        }

        private void OOP_Button_Click(object sender, EventArgs e)
        {
            SetBtnVisibility();
            resetBtnColor();
            OOP_Button.BackColor = Color.Coral;
            titleLabel.Text = oOP.Title;
            infoLabel.Text = oOP.Info;
            pictureBox.Image = Image.FromFile(oOP.Image);
            infoLinkLabel.Text = oOP.LinkInfo;
            linkLink = oOP.LinkInfo;
        }

        private void objectsBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            objectsBtn.BackColor = Color.Coral;
            titleLabel.Text = objects.Title;
            infoLabel.Text = objects.Info;
            pictureBox.Image = Image.FromFile(objects.Image);
            infoLinkLabel.Text = objects.LinkInfo;
            linkLink = objects.LinkInfo;
        }

        private void fieldsBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            fieldsBtn.BackColor = Color.Coral;
            titleLabel.Text = fields.Title;
            infoLabel.Text = fields.Info;
            pictureBox.Image = Image.FromFile(fields.Image);
            infoLinkLabel.Text = fields.LinkInfo;
            linkLink = fields.LinkInfo;
        }

        private void interfacesBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            interfacesBtn.BackColor = Color.Coral;
            titleLabel.Text = interfaces.Title;
            infoLabel.Text = interfaces.Info;
            pictureBox.Image = Image.FromFile(interfaces.Image);
            infoLinkLabel.Text = interfaces.LinkInfo;
            linkLink = interfaces.LinkInfo;
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            classesBtn.BackColor = Color.Coral;
            titleLabel.Text = classes.Title;
            infoLabel.Text = classes.Info;
            pictureBox.Image = Image.FromFile(classes.Image);
            infoLinkLabel.Text = classes.LinkInfo;
            linkLink = classes.LinkInfo;
        }

        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            propertiesBtn.BackColor = Color.Coral;
            titleLabel.Text = properties.Title;
            infoLabel.Text = properties.Info;
            pictureBox.Image = Image.FromFile(properties.Image);
            infoLinkLabel.Text = properties.LinkInfo;
            linkLink = properties.LinkInfo;
        }

        private void inheritanceBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            inheritanceBtn.BackColor = Color.Coral;
            titleLabel.Text = inheritance.Title;
            infoLabel.Text = inheritance.Info;
            pictureBox.Image = Image.FromFile(inheritance.Image);
            infoLinkLabel.Text = inheritance.LinkInfo;
            linkLink = inheritance.LinkInfo;
        }

        private void abstractionBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            abstractionBtn.BackColor = Color.Coral;
            titleLabel.Text = abstraction.Title;
            infoLabel.Text = abstraction.Info;
            pictureBox.Image = Image.FromFile(abstraction.Image);
            infoLinkLabel.Text = abstraction.LinkInfo;
            linkLink = abstraction.LinkInfo;
        }

        private void encapsulationBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            encapsulationBtn.BackColor = Color.Coral;
            titleLabel.Text = encapsulation.Title;
            infoLabel.Text = encapsulation.Info;
            pictureBox.Image = Image.FromFile(encapsulation.Image);
            infoLinkLabel.Text = encapsulation.LinkInfo;
            linkLink = encapsulation.LinkInfo;
        }

        private void polimorphysmBtn_Click(object sender, EventArgs e)
        {
            resetBtnColor();
            polimorphysmBtn.BackColor = Color.Coral;
            titleLabel.Text = polimorphysm.Title;
            infoLabel.Text = polimorphysm.Info;
            pictureBox.Image = Image.FromFile(polimorphysm.Image);
            infoLinkLabel.Text = polimorphysm.LinkInfo;
            linkLink = polimorphysm.LinkInfo;
        }
    }
}