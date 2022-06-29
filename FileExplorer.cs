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
using System.IO;
using System.Windows.Forms;

namespace Exquad
{
    class FileExplorer : Control
    {
        private WebBrowser browser;
        private Button buttonBack, buttonForward, buttonUp, buttonOpen;
        private TextBox textboxPath;

        public FileExplorer()
        {
            var table1 = new TableLayoutPanel();
                this.Controls.Add(table1);
                table1.Dock = DockStyle.Fill;
                table1.RowCount = 2;
                table1.ColumnCount = 1;
                table1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
                table1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                var table2 = new TableLayoutPanel();
                    table1.Controls.Add(table2);
                    table2.RowCount = 1;
                    table2.ColumnCount = 5;
                    table2.Dock = DockStyle.Fill;
                    table2.Height = 35;
                    //table2.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
                    table2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    table2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    table2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    table2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 0));
                    table2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

                    buttonBack = new Button();
                        table2.Controls.Add(buttonBack);
                        buttonBack.BackgroundImage = Properties.Resources.IconLeft;
                        buttonBack.Click += (sender, e) => { GoBack(); };
                    
                    buttonForward = new Button();
                        table2.Controls.Add(buttonForward);
                        buttonForward.BackgroundImage = Properties.Resources.IconRight;
                        buttonForward.Click += (sender, e) => { GoForward(); };

                    buttonUp = new Button();
                        table2.Controls.Add(buttonUp);
                        buttonUp.BackgroundImage = Properties.Resources.IconUp;
                        buttonUp.Click += (sender, e) => { GoUp(); };

                    buttonOpen = new Button();
                        table2.Controls.Add(buttonOpen);
                        buttonOpen.BackgroundImage = Properties.Resources.IconOpen;
                        buttonOpen.Click += (sender, e) => { OpenFolder(); };

                    textboxPath = new TextBox();
                        table2.Controls.Add(textboxPath);
                        textboxPath.Dock = DockStyle.Fill;
                        textboxPath.Font = new System.Drawing.Font("Calibri", 11);
                        textboxPath.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) BrowsePath(); };


                browser = new WebBrowser();
                    table1.Controls.Add(browser);
                    browser.Navigated += (sender, e) => { UpdateControls(); };
                    browser.Dock = DockStyle.Fill;
                    browser.Navigate("C:\\");

            foreach (var btn in new Button[] {buttonBack, buttonForward, buttonUp, buttonOpen})
            {
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.Size = new System.Drawing.Size(24, 24);
                btn.BackColor = System.Drawing.Color.Transparent;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

        }

        private void GoBack()
        {
            if (browser.CanGoBack)
                browser.GoBack();
        }

        private void GoForward()
        {
            if (browser.CanGoForward)
                browser.GoForward();
        }

        private void GoUp()
        {
            var currentDir = browser.Url.LocalPath;
            var parentDir = Directory.GetParent(RemoveProtocolPrefix(currentDir));

            if (parentDir != null)
                browser.Navigate(parentDir.FullName);
        }

        private string RemoveProtocolPrefix(string path)
        {
            if (path.StartsWith("file:///"))
                return path.Remove(0, "file:///".Length);
            return path;
        }

        private bool CanGoUp()
        {
            return Directory.GetParent(browser.Url.AbsolutePath) != null;
        }

        private void UpdateControls()
        {
            buttonBack.Enabled = browser.CanGoBack;
            buttonForward.Enabled = browser.CanGoForward;
            buttonUp.Enabled = CanGoUp();
            textboxPath.Text = RemoveProtocolPrefix(browser.Url.ToString());
        }

        private void OpenFolder()
        {
            var fd = new FolderBrowserDialog();
            fd.Description = "Select a location to display";
            fd.ShowNewFolderButton = true;
            
            if (fd.ShowDialog() == DialogResult.OK)
                browser.Navigate(fd.SelectedPath);
        }

        private void BrowsePath()
        {
            browser.Navigate(textboxPath.Text);
        }
    }
}
