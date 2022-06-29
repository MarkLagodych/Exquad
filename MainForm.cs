/*
Copyright 2022  Mark Lagodych

This file is part of Exquad.

Exquad is free software: you can redistribute it and/or modify it under the
terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.

Exquad is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR
A PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with
Exquad. If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;

namespace Exquad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitContainerLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainerRight.SplitterDistance = splitContainerLeft.SplitterDistance;
        }

        private void splitContainerRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainerLeft.SplitterDistance = splitContainerRight.SplitterDistance;
        }
    }
}
