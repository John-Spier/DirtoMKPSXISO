
namespace DirtoMKPSXISO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRootDir = new System.Windows.Forms.TextBox();
            this.btnRootDir = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.btnLicDat = new System.Windows.Forms.Button();
            this.txtLicDat = new System.Windows.Forms.TextBox();
            this.txtIdenVol = new System.Windows.Forms.TextBox();
            this.txtIdenApp = new System.Windows.Forms.TextBox();
            this.txtIdenSys = new System.Windows.Forms.TextBox();
            this.chkIdenSys = new System.Windows.Forms.CheckBox();
            this.chkIdenApp = new System.Windows.Forms.CheckBox();
            this.chkIdenVol = new System.Windows.Forms.CheckBox();
            this.chkIdenSet = new System.Windows.Forms.CheckBox();
            this.txtIdenSet = new System.Windows.Forms.TextBox();
            this.chkIdenCopy = new System.Windows.Forms.CheckBox();
            this.txtIdenCopy = new System.Windows.Forms.TextBox();
            this.chkIdenPrep = new System.Windows.Forms.CheckBox();
            this.chkIdenPub = new System.Windows.Forms.CheckBox();
            this.txtIdenPrep = new System.Windows.Forms.TextBox();
            this.txtIdenPub = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCddaFs = new System.Windows.Forms.CheckBox();
            this.chkCdda = new System.Windows.Forms.CheckBox();
            this.btnCddaDir = new System.Windows.Forms.Button();
            this.txtCddaDir = new System.Windows.Forms.TextBox();
            this.chkStrXa = new System.Windows.Forms.CheckBox();
            this.chkIden = new System.Windows.Forms.CheckBox();
            this.chkNoXa = new System.Windows.Forms.CheckBox();
            this.chkXml = new System.Windows.Forms.CheckBox();
            this.chkLicDat = new System.Windows.Forms.CheckBox();
            this.fbdRootDir = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdXml = new System.Windows.Forms.SaveFileDialog();
            this.ofdLicDat = new System.Windows.Forms.OpenFileDialog();
            this.txtXmlOut = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBinFile = new System.Windows.Forms.TextBox();
            this.btnBrowseBin = new System.Windows.Forms.Button();
            this.sfdBinCue = new System.Windows.Forms.SaveFileDialog();
            this.fbdCddaDir = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRootDir
            // 
            this.txtRootDir.Location = new System.Drawing.Point(6, 13);
            this.txtRootDir.Name = "txtRootDir";
            this.txtRootDir.Size = new System.Drawing.Size(291, 19);
            this.txtRootDir.TabIndex = 0;
            // 
            // btnRootDir
            // 
            this.btnRootDir.Location = new System.Drawing.Point(303, 12);
            this.btnRootDir.Name = "btnRootDir";
            this.btnRootDir.Size = new System.Drawing.Size(159, 21);
            this.btnRootDir.TabIndex = 1;
            this.btnRootDir.Text = "Browse Root Directory";
            this.btnRootDir.UseVisualStyleBackColor = true;
            this.btnRootDir.Click += new System.EventHandler(this.btnRootDir_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(303, 37);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(159, 21);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "Browse XML File";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(6, 38);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(291, 19);
            this.txtXml.TabIndex = 2;
            // 
            // btnLicDat
            // 
            this.btnLicDat.Location = new System.Drawing.Point(303, 62);
            this.btnLicDat.Name = "btnLicDat";
            this.btnLicDat.Size = new System.Drawing.Size(159, 21);
            this.btnLicDat.TabIndex = 5;
            this.btnLicDat.Text = "Browse License File";
            this.btnLicDat.UseVisualStyleBackColor = true;
            this.btnLicDat.Click += new System.EventHandler(this.btnLicDat_Click);
            // 
            // txtLicDat
            // 
            this.txtLicDat.Location = new System.Drawing.Point(6, 63);
            this.txtLicDat.Name = "txtLicDat";
            this.txtLicDat.Size = new System.Drawing.Size(291, 19);
            this.txtLicDat.TabIndex = 4;
            // 
            // txtIdenVol
            // 
            this.txtIdenVol.Location = new System.Drawing.Point(466, 139);
            this.txtIdenVol.Name = "txtIdenVol";
            this.txtIdenVol.Size = new System.Drawing.Size(144, 19);
            this.txtIdenVol.TabIndex = 8;
            this.txtIdenVol.Text = "MKPSXGUI";
            // 
            // txtIdenApp
            // 
            this.txtIdenApp.Location = new System.Drawing.Point(458, 114);
            this.txtIdenApp.Name = "txtIdenApp";
            this.txtIdenApp.Size = new System.Drawing.Size(152, 19);
            this.txtIdenApp.TabIndex = 7;
            this.txtIdenApp.Text = "PLAYSTATION";
            // 
            // txtIdenSys
            // 
            this.txtIdenSys.Location = new System.Drawing.Point(437, 89);
            this.txtIdenSys.Name = "txtIdenSys";
            this.txtIdenSys.Size = new System.Drawing.Size(173, 19);
            this.txtIdenSys.TabIndex = 6;
            this.txtIdenSys.Text = "PLAYSTATION";
            // 
            // chkIdenSys
            // 
            this.chkIdenSys.AutoSize = true;
            this.chkIdenSys.Checked = true;
            this.chkIdenSys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenSys.Location = new System.Drawing.Point(293, 91);
            this.chkIdenSys.Name = "chkIdenSys";
            this.chkIdenSys.Size = new System.Drawing.Size(138, 16);
            this.chkIdenSys.TabIndex = 9;
            this.chkIdenSys.Text = "System (Don\'t change!)";
            this.chkIdenSys.UseVisualStyleBackColor = true;
            // 
            // chkIdenApp
            // 
            this.chkIdenApp.AutoSize = true;
            this.chkIdenApp.Checked = true;
            this.chkIdenApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenApp.Location = new System.Drawing.Point(293, 116);
            this.chkIdenApp.Name = "chkIdenApp";
            this.chkIdenApp.Size = new System.Drawing.Size(159, 16);
            this.chkIdenApp.TabIndex = 10;
            this.chkIdenApp.Text = "Application (Don\'t change!)";
            this.chkIdenApp.UseVisualStyleBackColor = true;
            // 
            // chkIdenVol
            // 
            this.chkIdenVol.AutoSize = true;
            this.chkIdenVol.Checked = true;
            this.chkIdenVol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenVol.Location = new System.Drawing.Point(405, 141);
            this.chkIdenVol.Name = "chkIdenVol";
            this.chkIdenVol.Size = new System.Drawing.Size(57, 16);
            this.chkIdenVol.TabIndex = 11;
            this.chkIdenVol.Text = "Volume";
            this.chkIdenVol.UseVisualStyleBackColor = true;
            // 
            // chkIdenSet
            // 
            this.chkIdenSet.AutoSize = true;
            this.chkIdenSet.Checked = true;
            this.chkIdenSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenSet.Location = new System.Drawing.Point(184, 141);
            this.chkIdenSet.Name = "chkIdenSet";
            this.chkIdenSet.Size = new System.Drawing.Size(78, 16);
            this.chkIdenSet.TabIndex = 13;
            this.chkIdenSet.Text = "Volume Set";
            this.chkIdenSet.UseVisualStyleBackColor = true;
            // 
            // txtIdenSet
            // 
            this.txtIdenSet.Location = new System.Drawing.Point(268, 139);
            this.txtIdenSet.Name = "txtIdenSet";
            this.txtIdenSet.Size = new System.Drawing.Size(131, 19);
            this.txtIdenSet.TabIndex = 12;
            this.txtIdenSet.Text = "MKPSXDIR";
            // 
            // chkIdenCopy
            // 
            this.chkIdenCopy.AutoSize = true;
            this.chkIdenCopy.Checked = true;
            this.chkIdenCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenCopy.Location = new System.Drawing.Point(3, 141);
            this.chkIdenCopy.Name = "chkIdenCopy";
            this.chkIdenCopy.Size = new System.Drawing.Size(75, 16);
            this.chkIdenCopy.TabIndex = 15;
            this.chkIdenCopy.Text = "Copyright";
            this.chkIdenCopy.UseVisualStyleBackColor = true;
            // 
            // txtIdenCopy
            // 
            this.txtIdenCopy.Location = new System.Drawing.Point(84, 139);
            this.txtIdenCopy.Name = "txtIdenCopy";
            this.txtIdenCopy.Size = new System.Drawing.Size(94, 19);
            this.txtIdenCopy.TabIndex = 14;
            this.txtIdenCopy.Text = "NONE";
            // 
            // chkIdenPrep
            // 
            this.chkIdenPrep.AutoSize = true;
            this.chkIdenPrep.Checked = true;
            this.chkIdenPrep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenPrep.Location = new System.Drawing.Point(3, 116);
            this.chkIdenPrep.Name = "chkIdenPrep";
            this.chkIdenPrep.Size = new System.Drawing.Size(99, 16);
            this.chkIdenPrep.TabIndex = 19;
            this.chkIdenPrep.Text = "Data Preparer";
            this.chkIdenPrep.UseVisualStyleBackColor = true;
            // 
            // chkIdenPub
            // 
            this.chkIdenPub.AutoSize = true;
            this.chkIdenPub.Checked = true;
            this.chkIdenPub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdenPub.Location = new System.Drawing.Point(3, 91);
            this.chkIdenPub.Name = "chkIdenPub";
            this.chkIdenPub.Size = new System.Drawing.Size(72, 16);
            this.chkIdenPub.TabIndex = 18;
            this.chkIdenPub.Text = "Publisher";
            this.chkIdenPub.UseVisualStyleBackColor = true;
            // 
            // txtIdenPrep
            // 
            this.txtIdenPrep.Location = new System.Drawing.Point(108, 114);
            this.txtIdenPrep.Name = "txtIdenPrep";
            this.txtIdenPrep.Size = new System.Drawing.Size(179, 19);
            this.txtIdenPrep.TabIndex = 17;
            this.txtIdenPrep.Text = "PLAYSTATION";
            // 
            // txtIdenPub
            // 
            this.txtIdenPub.Location = new System.Drawing.Point(78, 89);
            this.txtIdenPub.Name = "txtIdenPub";
            this.txtIdenPub.Size = new System.Drawing.Size(209, 19);
            this.txtIdenPub.TabIndex = 16;
            this.txtIdenPub.Text = "PLAYSTATION";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCddaFs);
            this.panel1.Controls.Add(this.chkCdda);
            this.panel1.Controls.Add(this.btnCddaDir);
            this.panel1.Controls.Add(this.txtCddaDir);
            this.panel1.Controls.Add(this.chkStrXa);
            this.panel1.Controls.Add(this.chkIden);
            this.panel1.Controls.Add(this.chkNoXa);
            this.panel1.Controls.Add(this.chkXml);
            this.panel1.Controls.Add(this.chkLicDat);
            this.panel1.Controls.Add(this.chkIdenPrep);
            this.panel1.Controls.Add(this.chkIdenPub);
            this.panel1.Controls.Add(this.txtIdenPrep);
            this.panel1.Controls.Add(this.txtIdenPub);
            this.panel1.Controls.Add(this.chkIdenCopy);
            this.panel1.Controls.Add(this.txtIdenCopy);
            this.panel1.Controls.Add(this.chkIdenSet);
            this.panel1.Controls.Add(this.txtIdenSet);
            this.panel1.Controls.Add(this.chkIdenVol);
            this.panel1.Controls.Add(this.chkIdenApp);
            this.panel1.Controls.Add(this.chkIdenSys);
            this.panel1.Controls.Add(this.txtIdenVol);
            this.panel1.Controls.Add(this.txtIdenApp);
            this.panel1.Controls.Add(this.txtIdenSys);
            this.panel1.Controls.Add(this.btnLicDat);
            this.panel1.Controls.Add(this.txtLicDat);
            this.panel1.Controls.Add(this.btnXml);
            this.panel1.Controls.Add(this.txtXml);
            this.panel1.Controls.Add(this.btnRootDir);
            this.panel1.Controls.Add(this.txtRootDir);
            this.panel1.Location = new System.Drawing.Point(6, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 195);
            this.panel1.TabIndex = 20;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // chkCddaFs
            // 
            this.chkCddaFs.AutoSize = true;
            this.chkCddaFs.Location = new System.Drawing.Point(550, 166);
            this.chkCddaFs.Name = "chkCddaFs";
            this.chkCddaFs.Size = new System.Drawing.Size(66, 16);
            this.chkCddaFs.TabIndex = 28;
            this.chkCddaFs.Text = "Add .DAs";
            this.chkCddaFs.UseVisualStyleBackColor = true;
            // 
            // chkCdda
            // 
            this.chkCdda.AutoSize = true;
            this.chkCdda.Location = new System.Drawing.Point(466, 166);
            this.chkCdda.Name = "chkCdda";
            this.chkCdda.Size = new System.Drawing.Size(87, 16);
            this.chkCdda.TabIndex = 27;
            this.chkCdda.Text = "Add CD Audio";
            this.chkCdda.UseVisualStyleBackColor = true;
            // 
            // btnCddaDir
            // 
            this.btnCddaDir.Location = new System.Drawing.Point(303, 163);
            this.btnCddaDir.Name = "btnCddaDir";
            this.btnCddaDir.Size = new System.Drawing.Size(159, 21);
            this.btnCddaDir.TabIndex = 26;
            this.btnCddaDir.Text = "Browse CD Audio Directory";
            this.btnCddaDir.UseVisualStyleBackColor = true;
            this.btnCddaDir.Click += new System.EventHandler(this.btnCddaDir_Click);
            // 
            // txtCddaDir
            // 
            this.txtCddaDir.Location = new System.Drawing.Point(6, 164);
            this.txtCddaDir.Name = "txtCddaDir";
            this.txtCddaDir.Size = new System.Drawing.Size(291, 19);
            this.txtCddaDir.TabIndex = 25;
            // 
            // chkStrXa
            // 
            this.chkStrXa.AutoSize = true;
            this.chkStrXa.Location = new System.Drawing.Point(559, 65);
            this.chkStrXa.Name = "chkStrXa";
            this.chkStrXa.Size = new System.Drawing.Size(63, 16);
            this.chkStrXa.TabIndex = 24;
            this.chkStrXa.Text = "Auto XA";
            this.chkStrXa.UseVisualStyleBackColor = true;
            // 
            // chkIden
            // 
            this.chkIden.AutoSize = true;
            this.chkIden.Checked = true;
            this.chkIden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIden.Location = new System.Drawing.Point(466, 15);
            this.chkIden.Name = "chkIden";
            this.chkIden.Size = new System.Drawing.Size(105, 16);
            this.chkIden.TabIndex = 23;
            this.chkIden.Text = "Add Identifiers";
            this.chkIden.UseVisualStyleBackColor = true;
            // 
            // chkNoXa
            // 
            this.chkNoXa.AutoSize = true;
            this.chkNoXa.Location = new System.Drawing.Point(571, 40);
            this.chkNoXa.Name = "chkNoXa";
            this.chkNoXa.Size = new System.Drawing.Size(51, 16);
            this.chkNoXa.TabIndex = 22;
            this.chkNoXa.Text = "No XA";
            this.chkNoXa.UseVisualStyleBackColor = true;
            // 
            // chkXml
            // 
            this.chkXml.AutoSize = true;
            this.chkXml.Location = new System.Drawing.Point(466, 40);
            this.chkXml.Name = "chkXml";
            this.chkXml.Size = new System.Drawing.Size(102, 16);
            this.chkXml.TabIndex = 21;
            this.chkXml.Text = "Create XML File";
            this.chkXml.UseVisualStyleBackColor = true;
            // 
            // chkLicDat
            // 
            this.chkLicDat.AutoSize = true;
            this.chkLicDat.Location = new System.Drawing.Point(466, 67);
            this.chkLicDat.Name = "chkLicDat";
            this.chkLicDat.Size = new System.Drawing.Size(87, 16);
            this.chkLicDat.TabIndex = 20;
            this.chkLicDat.Text = "License Disc";
            this.chkLicDat.UseVisualStyleBackColor = true;
            // 
            // sfdXml
            // 
            this.sfdXml.Filter = "MKPSXISO XML Files|*.xml|All files|*.*";
            // 
            // ofdLicDat
            // 
            this.ofdLicDat.FileName = "LICENSEA.DAT";
            this.ofdLicDat.Filter = "License Files|*.dat|All FIles|*.*";
            // 
            // txtXmlOut
            // 
            this.txtXmlOut.Font = new System.Drawing.Font("Chaparral Pro Light", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtXmlOut.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtXmlOut.Location = new System.Drawing.Point(5, 9);
            this.txtXmlOut.MaxLength = 1000000;
            this.txtXmlOut.Multiline = true;
            this.txtXmlOut.Name = "txtXmlOut";
            this.txtXmlOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXmlOut.Size = new System.Drawing.Size(623, 337);
            this.txtXmlOut.TabIndex = 21;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Font = new System.Drawing.Font("mikachan-puchiB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(190, 352);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(438, 101);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Create XML";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBinFile
            // 
            this.txtBinFile.Font = new System.Drawing.Font("Tekton Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBinFile.Location = new System.Drawing.Point(5, 352);
            this.txtBinFile.Name = "txtBinFile";
            this.txtBinFile.Size = new System.Drawing.Size(179, 23);
            this.txtBinFile.TabIndex = 23;
            this.txtBinFile.Text = "psxgui.bin";
            // 
            // btnBrowseBin
            // 
            this.btnBrowseBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseBin.Font = new System.Drawing.Font("Thames", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseBin.ForeColor = System.Drawing.Color.Aqua;
            this.btnBrowseBin.Location = new System.Drawing.Point(5, 377);
            this.btnBrowseBin.Name = "btnBrowseBin";
            this.btnBrowseBin.Size = new System.Drawing.Size(179, 76);
            this.btnBrowseBin.TabIndex = 24;
            this.btnBrowseBin.Text = "Browse Output File";
            this.btnBrowseBin.UseVisualStyleBackColor = true;
            this.btnBrowseBin.Click += new System.EventHandler(this.btnBrowseBin_Click);
            // 
            // sfdBinCue
            // 
            this.sfdBinCue.Filter = "Binary Images|*.bin|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(634, 660);
            this.Controls.Add(this.btnBrowseBin);
            this.Controls.Add(this.txtBinFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtXmlOut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("mikachan-puchi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dir to MKPSXISO";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRootDir;
        private System.Windows.Forms.Button btnRootDir;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Button btnLicDat;
        private System.Windows.Forms.TextBox txtLicDat;
        private System.Windows.Forms.TextBox txtIdenVol;
        private System.Windows.Forms.TextBox txtIdenApp;
        private System.Windows.Forms.TextBox txtIdenSys;
        private System.Windows.Forms.CheckBox chkIdenSys;
        private System.Windows.Forms.CheckBox chkIdenApp;
        private System.Windows.Forms.CheckBox chkIdenVol;
        private System.Windows.Forms.CheckBox chkIdenSet;
        private System.Windows.Forms.TextBox txtIdenSet;
        private System.Windows.Forms.CheckBox chkIdenCopy;
        private System.Windows.Forms.TextBox txtIdenCopy;
        private System.Windows.Forms.CheckBox chkIdenPrep;
        private System.Windows.Forms.CheckBox chkIdenPub;
        private System.Windows.Forms.TextBox txtIdenPrep;
        private System.Windows.Forms.TextBox txtIdenPub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkIden;
        private System.Windows.Forms.CheckBox chkNoXa;
        private System.Windows.Forms.CheckBox chkXml;
        private System.Windows.Forms.CheckBox chkLicDat;
        private System.Windows.Forms.CheckBox chkStrXa;
        private System.Windows.Forms.FolderBrowserDialog fbdRootDir;
        private System.Windows.Forms.SaveFileDialog sfdXml;
        private System.Windows.Forms.OpenFileDialog ofdLicDat;
        private System.Windows.Forms.TextBox txtXmlOut;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBinFile;
        private System.Windows.Forms.Button btnBrowseBin;
        private System.Windows.Forms.SaveFileDialog sfdBinCue;
        private System.Windows.Forms.CheckBox chkCdda;
        private System.Windows.Forms.Button btnCddaDir;
        private System.Windows.Forms.TextBox txtCddaDir;
        private System.Windows.Forms.CheckBox chkCddaFs;
        private System.Windows.Forms.FolderBrowserDialog fbdCddaDir;
    }
}

