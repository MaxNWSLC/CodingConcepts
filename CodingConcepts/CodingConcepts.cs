using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodingConcepts
{
    public partial class CodingConcepts : Form
    {
        static string linkLink;
        static readonly string iterationsText = File.ReadAllText("Iterations.txt");
        static readonly string sequencesText = File.ReadAllText("sequences.txt");

        public CodingConcepts()
        {
            InitializeComponent();

        }

        readonly CodingConceptsClass iterations = new("Iterations", iterationsText, "iterations.png", "https://www.bbc.co.uk/bitesize/guides/z3khpv4/");
        readonly CodingConceptsClass sequences = new("Sequences", sequencesText, "iterations.png", "https://www.bbc.co.uk/bitesize/clips/zxy9d2p");

        private void iterationBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = iterations.Title;
            infoLabel.Text = iterations.Info;
            pictureBox.Image = Image.FromFile(iterations.Image);
            infoLinkLabel.Text = iterations.LinkInfo;
            linkLink = iterations.LinkInfo;
        }

        private void infoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(linkLink);
        }

        private void sequencesBtn_Click(object sender, EventArgs e)
        {
            titleLabel.Text = sequences.Title;
            infoLabel.Text = sequences.Info;
            pictureBox.Image = Image.FromFile(sequences.Image);
            infoLinkLabel.Text = sequences.LinkInfo;
            linkLink = sequences.LinkInfo;
        }
    }
}