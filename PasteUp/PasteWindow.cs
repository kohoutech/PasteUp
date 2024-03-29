﻿/* ----------------------------------------------------------------------------
Paste Up - a desktop publisher
Copyright (C) 2005-2021 George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasteUp
{
    public partial class PasteWindow : Form
    {
        PasteCanvas canvas;

        public PasteWindow()
        {
            InitializeComponent();
            canvas = PastePanel.canvas;
        }

        //- menu handlers -----------------------------------------------------

        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertTextPageMenuItem_Click(object sender, EventArgs e)
        {
            canvas.InsertPasteText();
        }

        private void insertImagePageMenuItem_Click(object sender, EventArgs e)
        {
            canvas.InsertPasteImage();
        }

        private void aboutHelpMenuItem_Click(object sender, EventArgs e)
        {
            String msg = "Paste Up\nversion 0.1.0\n\xA9 Topographics Software 2005-2021\n" + "http://topographics.kohoutech.com";
            MessageBox.Show(msg, "About");

        }
    }
}
