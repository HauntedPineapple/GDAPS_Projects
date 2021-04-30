namespace Homework_6
{
    partial class Join
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Join));
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.AgeDropDown = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.pangolinButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.joinButton = new System.Windows.Forms.Button();
            this.logBackIn = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.confirmInput = new System.Windows.Forms.TextBox();
            this.pangolinPic = new System.Windows.Forms.PictureBox();
            this.permissionBox = new System.Windows.Forms.CheckBox();
            this.passwordmatchLabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.PressMe = new System.Windows.Forms.Button();
            this.genderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pangolinPic)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(113, 15);
            this.userLabel.TabIndex = 49;
            this.userLabel.Text = "New Username: ";
            this.userLabel.MouseEnter += new System.EventHandler(this.UserLabel_MouseEnter);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(12, 95);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(109, 15);
            this.passLabel.TabIndex = 50;
            this.passLabel.Text = "New Password: ";
            this.passLabel.MouseEnter += new System.EventHandler(this.PassLabel_MouseEnter);
            // 
            // inputUser
            // 
            this.inputUser.Location = new System.Drawing.Point(131, 94);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(130, 20);
            this.inputUser.TabIndex = 52;
            this.inputUser.TextChanged += new System.EventHandler(this.InputUser_TextChanged);
            // 
            // inputPass
            // 
            this.inputPass.Location = new System.Drawing.Point(131, 20);
            this.inputPass.Name = "inputPass";
            this.inputPass.Size = new System.Drawing.Size(130, 20);
            this.inputPass.TabIndex = 51;
            this.inputPass.UseSystemPasswordChar = true;
            this.inputPass.TextChanged += new System.EventHandler(this.InputPass_TextChanged);
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(60, 306);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(26, 13);
            this.agelabel.TabIndex = 53;
            this.agelabel.Text = "Age";
            this.agelabel.MouseEnter += new System.EventHandler(this.Agelabel_MouseEnter);
            // 
            // AgeDropDown
            // 
            this.AgeDropDown.FormattingEnabled = true;
            this.AgeDropDown.Items.AddRange(new object[] {
            "1800",
            "1801",
            "1802",
            "1803",
            "1803",
            "1804",
            "1805",
            "1806",
            "1807",
            "1808",
            "1809",
            "1810",
            "1811",
            "1812",
            "1813",
            "1814",
            "1815",
            "1816",
            "1817",
            "1818",
            "1819",
            "1810",
            "1811",
            "1812",
            "1813",
            "1814",
            "1815",
            "1816",
            "1817",
            "1818",
            "1819",
            "1820",
            "1821",
            "1822",
            "1823",
            "1824",
            "1825",
            "1826",
            "1827",
            "1828",
            "1829",
            "1830",
            "1831",
            "1832",
            "1833",
            "1834",
            "1835",
            "1836",
            "1837",
            "1838",
            "1839",
            "1840",
            "1841",
            "1842",
            "1843",
            "1844",
            "1845",
            "1846",
            "1847",
            "1848",
            "1849",
            "1850",
            "1851",
            "1852",
            "1853",
            "1854",
            "1855",
            "1856",
            "1857",
            "1858",
            "1859",
            "1860",
            "1861",
            "1862",
            "1863",
            "1864",
            "1865",
            "1866",
            "1867",
            "1868",
            "1869",
            "1870",
            "1871",
            "1872",
            "1873",
            "1874",
            "1875",
            "1876",
            "1877",
            "1878",
            "1879",
            "1880",
            "1881",
            "1882",
            "1883",
            "1884",
            "1885",
            "1886",
            "1887",
            "1888",
            "1889",
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.AgeDropDown.Location = new System.Drawing.Point(43, 323);
            this.AgeDropDown.Name = "AgeDropDown";
            this.AgeDropDown.Size = new System.Drawing.Size(58, 21);
            this.AgeDropDown.TabIndex = 54;
            this.AgeDropDown.SelectedIndexChanged += new System.EventHandler(this.AgeDropDown_SelectedIndexChanged);
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.pangolinButton);
            this.genderBox.Controls.Add(this.femaleButton);
            this.genderBox.Controls.Add(this.maleButton);
            this.genderBox.Location = new System.Drawing.Point(14, 349);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(118, 86);
            this.genderBox.TabIndex = 55;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Gender";
            // 
            // pangolinButton
            // 
            this.pangolinButton.AutoSize = true;
            this.pangolinButton.Location = new System.Drawing.Point(14, 62);
            this.pangolinButton.Margin = new System.Windows.Forms.Padding(2);
            this.pangolinButton.Name = "pangolinButton";
            this.pangolinButton.Size = new System.Drawing.Size(66, 17);
            this.pangolinButton.TabIndex = 2;
            this.pangolinButton.TabStop = true;
            this.pangolinButton.Text = "Pangolin";
            this.pangolinButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(14, 40);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 1;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(14, 18);
            this.maleButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 0;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // joinButton
            // 
            this.joinButton.Enabled = false;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(691, 392);
            this.joinButton.Margin = new System.Windows.Forms.Padding(2);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(100, 49);
            this.joinButton.TabIndex = 56;
            this.joinButton.Text = "Join!";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // logBackIn
            // 
            this.logBackIn.Location = new System.Drawing.Point(502, 402);
            this.logBackIn.Margin = new System.Windows.Forms.Padding(2);
            this.logBackIn.Name = "logBackIn";
            this.logBackIn.Size = new System.Drawing.Size(177, 33);
            this.logBackIn.TabIndex = 57;
            this.logBackIn.Text = "Already have an account? Log in!";
            this.logBackIn.UseVisualStyleBackColor = true;
            this.logBackIn.Click += new System.EventHandler(this.LogBackIn_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(12, 126);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(111, 13);
            this.confirmLabel.TabIndex = 58;
            this.confirmLabel.Text = "Confirm Password:";
            this.confirmLabel.MouseEnter += new System.EventHandler(this.ConfirmLabel_MouseEnter);
            // 
            // confirmInput
            // 
            this.confirmInput.Location = new System.Drawing.Point(131, 126);
            this.confirmInput.Margin = new System.Windows.Forms.Padding(2);
            this.confirmInput.Name = "confirmInput";
            this.confirmInput.Size = new System.Drawing.Size(130, 20);
            this.confirmInput.TabIndex = 59;
            this.confirmInput.UseSystemPasswordChar = true;
            this.confirmInput.TextChanged += new System.EventHandler(this.ConfirmInput_TextChanged);
            // 
            // pangolinPic
            // 
            this.pangolinPic.Enabled = false;
            this.pangolinPic.Image = ((System.Drawing.Image)(resources.GetObject("pangolinPic.Image")));
            this.pangolinPic.Location = new System.Drawing.Point(338, -23);
            this.pangolinPic.Name = "pangolinPic";
            this.pangolinPic.Size = new System.Drawing.Size(463, 376);
            this.pangolinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pangolinPic.TabIndex = 60;
            this.pangolinPic.TabStop = false;
            // 
            // permissionBox
            // 
            this.permissionBox.AutoSize = true;
            this.permissionBox.Enabled = false;
            this.permissionBox.Location = new System.Drawing.Point(531, 368);
            this.permissionBox.Name = "permissionBox";
            this.permissionBox.Size = new System.Drawing.Size(117, 17);
            this.permissionBox.TabIndex = 61;
            this.permissionBox.Text = "Parent\'s Permission";
            this.permissionBox.UseVisualStyleBackColor = true;
            this.permissionBox.CheckedChanged += new System.EventHandler(this.PermissionBox_CheckedChanged);
            // 
            // passwordmatchLabel
            // 
            this.passwordmatchLabel.AutoSize = true;
            this.passwordmatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordmatchLabel.ForeColor = System.Drawing.Color.Crimson;
            this.passwordmatchLabel.Location = new System.Drawing.Point(25, 148);
            this.passwordmatchLabel.Name = "passwordmatchLabel";
            this.passwordmatchLabel.Size = new System.Drawing.Size(201, 16);
            this.passwordmatchLabel.TabIndex = 62;
            this.passwordmatchLabel.Text = "The passwords don\'t match!";
            this.passwordmatchLabel.Visible = false;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(12, 275);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(38, 13);
            this.namelabel.TabIndex = 63;
            this.namelabel.Text = "Name:";
            this.namelabel.MouseEnter += new System.EventHandler(this.Namelabel_MouseEnter);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(56, 272);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(139, 20);
            this.inputName.TabIndex = 64;
            // 
            // PressMe
            // 
            this.PressMe.Location = new System.Drawing.Point(294, 418);
            this.PressMe.Name = "PressMe";
            this.PressMe.Size = new System.Drawing.Size(75, 23);
            this.PressMe.TabIndex = 65;
            this.PressMe.Text = "Press Me!";
            this.PressMe.UseVisualStyleBackColor = true;
            this.PressMe.Click += new System.EventHandler(this.PressMe_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PressMe);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.passwordmatchLabel);
            this.Controls.Add(this.permissionBox);
            this.Controls.Add(this.pangolinPic);
            this.Controls.Add(this.confirmInput);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.logBackIn);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.AgeDropDown);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "Join";
            this.ShowIcon = false;
            this.Text = "Welcome to Club Pangolin!";
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pangolinPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.ComboBox AgeDropDown;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton pangolinButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button logBackIn;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirmInput;
        private System.Windows.Forms.PictureBox pangolinPic;
        private System.Windows.Forms.CheckBox permissionBox;
        private System.Windows.Forms.Label passwordmatchLabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button PressMe;
    }
}

