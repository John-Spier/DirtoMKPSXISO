using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DirtoMKPSXISO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            btnBrowseBin.Visible = !btnBrowseBin.Visible;
            btnStart.Visible = !btnStart.Visible;
            txtXmlOut.Visible = !txtXmlOut.Visible;
            txtBinFile.Visible = !txtBinFile.Visible;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.BackgroundImageLayout==ImageLayout.Stretch)
            {
                this.BackgroundImageLayout = ImageLayout.Center;
            } 
            else
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            if (sfdXml.ShowDialog() == DialogResult.OK)
            {
                txtXml.Text = sfdXml.FileName;
                chkXml.Checked = true;
            }
        }

        private void btnLicDat_Click(object sender, EventArgs e)
        {
            if (ofdLicDat.ShowDialog() == DialogResult.OK)
            {
                txtLicDat.Text = ofdLicDat.FileName;
                chkLicDat.Checked = true;
            }
        }

        private void btnRootDir_Click(object sender, EventArgs e)
        {
            if (fbdRootDir.ShowDialog() == DialogResult.OK)
            {
                txtRootDir.Text = fbdRootDir.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtRootDir.Text))
            {
                DirectoryInfo dir = new DirectoryInfo(txtRootDir.Text);
                XElement project = new XElement("iso_project", new XAttribute("image_name", txtBinFile.Text), new XAttribute("cue_sheet", Path.ChangeExtension(txtBinFile.Text, ".cue")));
                if (chkNoXa.Checked) { project.Add(new XAttribute("no_xa", "1")); }

                XElement track = new XElement("track", new XAttribute("type", "data"));
                if (chkLicDat.Checked)
                {
                    track.Add(new XElement("license", new XAttribute("file", txtLicDat.Text)));
                }
                if (chkIden.Checked)
                {
                    XElement iden = new XElement("identifiers");
                    if (chkIdenSys.Checked) { iden.Add(new XAttribute("system", txtIdenSys.Text)); }
                    if (chkIdenApp.Checked) { iden.Add(new XAttribute("application", txtIdenApp.Text)); }
                    if (chkIdenVol.Checked) { iden.Add(new XAttribute("volume", txtIdenVol.Text)); }
                    if (chkIdenSet.Checked) { iden.Add(new XAttribute("volume_set", txtIdenSet.Text)); }
                    if (chkIdenPub.Checked) { iden.Add(new XAttribute("publisher", txtIdenPub.Text)); }
                    if (chkIdenPrep.Checked) { iden.Add(new XAttribute("data_preparer", txtIdenPrep.Text)); }
                    if (chkIdenCopy.Checked) { iden.Add(new XAttribute("copyright", txtIdenCopy.Text)); }
                    track.Add(iden);
                }
                bool dachecked = false;
                if (chkCdda.Checked && chkCddaFs.Checked && Directory.Exists(txtCddaDir.Text)) { dachecked = true; }
                track.Add(new XElement(GetDirectoryXml(dir, true, chkStrXa.Checked, dachecked, txtCddaDir.Text)));
                project.Add(track);
                if (chkCdda.Checked && Directory.Exists(txtCddaDir.Text))
                {
                    DirectoryInfo datrk = new DirectoryInfo(txtCddaDir.Text);
                    //int tid = 2;
                    if (chkCddaFs.Checked)
                    {
                        foreach (FileInfo t in datrk.GetFiles())
                        {

                            if ((t.Extension.ToLowerInvariant() == ".mp3" || t.Extension.ToLowerInvariant() == ".wav" || t.Extension.ToLowerInvariant() == ".flac" || t.Extension.ToLowerInvariant() == ".pcm"))
                            {
                                project.Add(new XElement("track", new XAttribute("type", "audio"), new XAttribute("trackid", t.Name), new XAttribute("source", t.FullName)));
                            }
                        }
                    } 
                    else
                    {
                        foreach (FileInfo t in datrk.GetFiles())
                        {

                            if ((t.Extension.ToLowerInvariant() == ".mp3" || t.Extension.ToLowerInvariant() == ".wav" || t.Extension.ToLowerInvariant() == ".flac" || t.Extension.ToLowerInvariant() == ".pcm"))
                            {
                                project.Add(new XElement("track", new XAttribute("type", "audio"), new XAttribute("source", t.FullName)));
                            }
                        }
                    }
                }
                XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "no"), project);
                if (chkXml.Checked && Directory.Exists(Path.GetDirectoryName(txtXml.Text)))
                {
                    //MessageBox.Show("XML OK");
                    doc.Save(Path.GetFullPath(txtXml.Text));
                }

                txtXmlOut.Text = doc.ToString();
            }
            else
            {
                if (fbdRootDir.ShowDialog() == DialogResult.OK)
                {
                    txtRootDir.Text = fbdRootDir.SelectedPath;
                }
            }
        }

        public static XElement GetDirectoryXml(DirectoryInfo dir, bool isroot, bool xa, bool da, string dadir)
        {
            XElement info;
            if (isroot)
            {
                info = new XElement("directory_tree");
            }
            else
            {
                info = new XElement("dir", new XAttribute("name", dir.Name), new XAttribute("srcdir", dir.FullName));
            }


            foreach (FileInfo file in dir.GetFiles())
            {
                if (xa && (file.Extension.ToLowerInvariant() == ".str" || file.Extension.ToLowerInvariant() == ".xa"))
                {
                    info.Add(new XElement("file", new XAttribute("name",file.Name), new XAttribute("type", "mixed"), new XAttribute("source", file.FullName)));
                }
                else
                {
                    info.Add(new XElement("file", new XAttribute("name", file.Name), new XAttribute("type", "data"), new XAttribute("source", file.FullName)));
                }
            }
                

            foreach (var subDir in dir.GetDirectories())
                info.Add(GetDirectoryXml(subDir, false, xa, da, dadir));


            if (isroot && da)
            {
                DirectoryInfo cdda = new DirectoryInfo(dadir);
                int tid = 2;
                foreach (FileInfo s in cdda.GetFiles())
                {

                    if ((s.Extension.ToLowerInvariant() == ".mp3" || s.Extension.ToLowerInvariant() == ".wav" || s.Extension.ToLowerInvariant() == ".flac" || s.Extension.ToLowerInvariant() == ".pcm"))
                    {
                        //MessageBox.Show(s.ToString());
                        info.Add(new XElement("file", new XAttribute("name", tid.ToString() + ".da"), new XAttribute("trackid", s.Name), new XAttribute("type", "da")));
                        tid++;
                    }
                }
            }


            return info;
        }

        private void btnBrowseBin_Click(object sender, EventArgs e)
        {
            if (sfdBinCue.ShowDialog() == DialogResult.OK)
            {
                txtBinFile.Text = sfdBinCue.FileName;
            }
        }

        private void btnCddaDir_Click(object sender, EventArgs e)
        {
            if (fbdCddaDir.ShowDialog() == DialogResult.OK)
            {
                txtCddaDir.Text = fbdCddaDir.SelectedPath;
                chkCdda.Checked = true;
            }
        }
    }
}
