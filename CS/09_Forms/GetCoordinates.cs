﻿using Spire.Pdf;
using Spire.Pdf.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetCoordinates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a pdf document
            PdfDocument doc = new PdfDocument();

            //Load from file
            doc.LoadFromFile(@"..\..\..\..\..\..\Data\TextBoxSampleB.pdf");

            //Get form fields
            PdfFormWidget formWidget = doc.Form as PdfFormWidget;

            //Get textbox
            PdfTextBoxFieldWidget textbox = formWidget.FieldsWidget["Text1"] as PdfTextBoxFieldWidget;
            
            //Get the location of the textbox
            PointF location = textbox.Location;

            MessageBox.Show("The location of the field named " + textbox.Name + " is\n X:" + location.X + "  Y:" + location.Y);

        }
    }
}
