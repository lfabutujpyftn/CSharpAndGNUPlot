namespace Test
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestGroup = new System.Windows.Forms.GroupBox();
            this.startlabel = new System.Windows.Forms.Label();
            this.startnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PlotGroup = new System.Windows.Forms.GroupBox();
            this.tonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.finishnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.finishlabel = new System.Windows.Forms.Label();
            this.steplabel = new System.Windows.Forms.Label();
            this.fromlabel = new System.Windows.Forms.Label();
            this.tolabel = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.colorlabel = new System.Windows.Forms.Label();
            this.drawtypelabel = new System.Windows.Forms.Label();
            this.colorcomboBox = new System.Windows.Forms.ComboBox();
            this.drawtypecomboBox = new System.Windows.Forms.ComboBox();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.xlabeltextBox = new System.Windows.Forms.TextBox();
            this.ylabeltextBox = new System.Windows.Forms.TextBox();
            this.labeltextBox = new System.Windows.Forms.TextBox();
            this.plotbutton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.TestGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startnumericUpDown)).BeginInit();
            this.PlotGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TestGroup
            // 
            this.TestGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestGroup.AutoSize = true;
            this.TestGroup.Controls.Add(this.Generatebutton);
            this.TestGroup.Controls.Add(this.tolabel);
            this.TestGroup.Controls.Add(this.fromlabel);
            this.TestGroup.Controls.Add(this.steplabel);
            this.TestGroup.Controls.Add(this.finishlabel);
            this.TestGroup.Controls.Add(this.finishnumericUpDown);
            this.TestGroup.Controls.Add(this.stepnumericUpDown);
            this.TestGroup.Controls.Add(this.fromnumericUpDown);
            this.TestGroup.Controls.Add(this.tonumericUpDown);
            this.TestGroup.Controls.Add(this.startlabel);
            this.TestGroup.Controls.Add(this.startnumericUpDown);
            this.TestGroup.Location = new System.Drawing.Point(12, 171);
            this.TestGroup.Name = "TestGroup";
            this.TestGroup.Size = new System.Drawing.Size(541, 67);
            this.TestGroup.TabIndex = 0;
            this.TestGroup.TabStop = false;
            this.TestGroup.Text = "Generate test file";
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(6, 29);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(27, 13);
            this.startlabel.TabIndex = 1;
            this.startlabel.Text = "start";
            // 
            // startnumericUpDown
            // 
            this.startnumericUpDown.Location = new System.Drawing.Point(39, 27);
            this.startnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startnumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.startnumericUpDown.Name = "startnumericUpDown";
            this.startnumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.startnumericUpDown.TabIndex = 0;
            this.startnumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // PlotGroup
            // 
            this.PlotGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotGroup.AutoSize = true;
            this.PlotGroup.Controls.Add(this.plotbutton);
            this.PlotGroup.Controls.Add(this.labeltextBox);
            this.PlotGroup.Controls.Add(this.ylabeltextBox);
            this.PlotGroup.Controls.Add(this.xlabeltextBox);
            this.PlotGroup.Controls.Add(this.label);
            this.PlotGroup.Controls.Add(this.ylabel);
            this.PlotGroup.Controls.Add(this.xlabel);
            this.PlotGroup.Controls.Add(this.drawtypecomboBox);
            this.PlotGroup.Controls.Add(this.colorcomboBox);
            this.PlotGroup.Controls.Add(this.drawtypelabel);
            this.PlotGroup.Controls.Add(this.colorlabel);
            this.PlotGroup.Location = new System.Drawing.Point(12, 12);
            this.PlotGroup.Name = "PlotGroup";
            this.PlotGroup.Size = new System.Drawing.Size(541, 148);
            this.PlotGroup.TabIndex = 1;
            this.PlotGroup.TabStop = false;
            this.PlotGroup.Text = "Ploting";
            // 
            // tonumericUpDown
            // 
            this.tonumericUpDown.Location = new System.Drawing.Point(400, 27);
            this.tonumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tonumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.tonumericUpDown.Name = "tonumericUpDown";
            this.tonumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.tonumericUpDown.TabIndex = 2;
            this.tonumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // fromnumericUpDown
            // 
            this.fromnumericUpDown.Location = new System.Drawing.Point(317, 27);
            this.fromnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fromnumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.fromnumericUpDown.Name = "fromnumericUpDown";
            this.fromnumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.fromnumericUpDown.TabIndex = 3;
            // 
            // stepnumericUpDown
            // 
            this.stepnumericUpDown.DecimalPlaces = 1;
            this.stepnumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.stepnumericUpDown.Location = new System.Drawing.Point(230, 27);
            this.stepnumericUpDown.Name = "stepnumericUpDown";
            this.stepnumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.stepnumericUpDown.TabIndex = 4;
            this.stepnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finishnumericUpDown
            // 
            this.finishnumericUpDown.Location = new System.Drawing.Point(136, 27);
            this.finishnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.finishnumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.finishnumericUpDown.Name = "finishnumericUpDown";
            this.finishnumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.finishnumericUpDown.TabIndex = 5;
            this.finishnumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // finishlabel
            // 
            this.finishlabel.AutoSize = true;
            this.finishlabel.Location = new System.Drawing.Point(99, 29);
            this.finishlabel.Name = "finishlabel";
            this.finishlabel.Size = new System.Drawing.Size(31, 13);
            this.finishlabel.TabIndex = 6;
            this.finishlabel.Text = "finish";
            // 
            // steplabel
            // 
            this.steplabel.AutoSize = true;
            this.steplabel.Location = new System.Drawing.Point(197, 29);
            this.steplabel.Name = "steplabel";
            this.steplabel.Size = new System.Drawing.Size(27, 13);
            this.steplabel.TabIndex = 7;
            this.steplabel.Text = "step";
            // 
            // fromlabel
            // 
            this.fromlabel.AutoSize = true;
            this.fromlabel.Location = new System.Drawing.Point(284, 29);
            this.fromlabel.Name = "fromlabel";
            this.fromlabel.Size = new System.Drawing.Size(27, 13);
            this.fromlabel.TabIndex = 8;
            this.fromlabel.Text = "from";
            // 
            // tolabel
            // 
            this.tolabel.AutoSize = true;
            this.tolabel.Location = new System.Drawing.Point(378, 29);
            this.tolabel.Name = "tolabel";
            this.tolabel.Size = new System.Drawing.Size(16, 13);
            this.tolabel.TabIndex = 9;
            this.tolabel.Text = "to";
            // 
            // Generatebutton
            // 
            this.Generatebutton.Location = new System.Drawing.Point(460, 27);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(75, 21);
            this.Generatebutton.TabIndex = 10;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = true;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // colorlabel
            // 
            this.colorlabel.AutoSize = true;
            this.colorlabel.Location = new System.Drawing.Point(6, 26);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(31, 13);
            this.colorlabel.TabIndex = 0;
            this.colorlabel.Text = "Color";
            // 
            // drawtypelabel
            // 
            this.drawtypelabel.AutoSize = true;
            this.drawtypelabel.Location = new System.Drawing.Point(197, 26);
            this.drawtypelabel.Name = "drawtypelabel";
            this.drawtypelabel.Size = new System.Drawing.Size(55, 13);
            this.drawtypelabel.TabIndex = 1;
            this.drawtypelabel.Text = "Draw type";
            // 
            // colorcomboBox
            // 
            this.colorcomboBox.FormattingEnabled = true;
            this.colorcomboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black"});
            this.colorcomboBox.Location = new System.Drawing.Point(70, 23);
            this.colorcomboBox.Name = "colorcomboBox";
            this.colorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.colorcomboBox.TabIndex = 2;
            // 
            // drawtypecomboBox
            // 
            this.drawtypecomboBox.FormattingEnabled = true;
            this.drawtypecomboBox.Items.AddRange(new object[] {
            "Lines",
            "Points"});
            this.drawtypecomboBox.Location = new System.Drawing.Point(258, 23);
            this.drawtypecomboBox.Name = "drawtypecomboBox";
            this.drawtypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.drawtypecomboBox.TabIndex = 3;
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(6, 57);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(40, 13);
            this.xlabel.TabIndex = 4;
            this.xlabel.Text = "XLabel";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(6, 85);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(40, 13);
            this.ylabel.TabIndex = 5;
            this.ylabel.Text = "YLabel";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Label";
            // 
            // xlabeltextBox
            // 
            this.xlabeltextBox.Location = new System.Drawing.Point(70, 54);
            this.xlabeltextBox.Name = "xlabeltextBox";
            this.xlabeltextBox.Size = new System.Drawing.Size(309, 20);
            this.xlabeltextBox.TabIndex = 7;
            this.xlabeltextBox.Text = "X";
            this.xlabeltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ylabeltextBox
            // 
            this.ylabeltextBox.Location = new System.Drawing.Point(70, 82);
            this.ylabeltextBox.Name = "ylabeltextBox";
            this.ylabeltextBox.Size = new System.Drawing.Size(309, 20);
            this.ylabeltextBox.TabIndex = 8;
            this.ylabeltextBox.Text = "Y";
            this.ylabeltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeltextBox
            // 
            this.labeltextBox.Location = new System.Drawing.Point(70, 109);
            this.labeltextBox.Name = "labeltextBox";
            this.labeltextBox.Size = new System.Drawing.Size(309, 20);
            this.labeltextBox.TabIndex = 9;
            this.labeltextBox.Text = "graf";
            this.labeltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plotbutton
            // 
            this.plotbutton.Location = new System.Drawing.Point(400, 23);
            this.plotbutton.Name = "plotbutton";
            this.plotbutton.Size = new System.Drawing.Size(135, 106);
            this.plotbutton.TabIndex = 10;
            this.plotbutton.Text = "Plot!!!";
            this.plotbutton.UseVisualStyleBackColor = true;
            this.plotbutton.Click += new System.EventHandler(this.plotbutton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(566, 250);
            this.Controls.Add(this.PlotGroup);
            this.Controls.Add(this.TestGroup);
            this.Name = "MainForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TestGroup.ResumeLayout(false);
            this.TestGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startnumericUpDown)).EndInit();
            this.PlotGroup.ResumeLayout(false);
            this.PlotGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TestGroup;
        private System.Windows.Forms.GroupBox PlotGroup;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.NumericUpDown startnumericUpDown;
        private System.Windows.Forms.Label tolabel;
        private System.Windows.Forms.Label fromlabel;
        private System.Windows.Forms.Label steplabel;
        private System.Windows.Forms.Label finishlabel;
        private System.Windows.Forms.NumericUpDown finishnumericUpDown;
        private System.Windows.Forms.NumericUpDown stepnumericUpDown;
        private System.Windows.Forms.NumericUpDown fromnumericUpDown;
        private System.Windows.Forms.NumericUpDown tonumericUpDown;
        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ComboBox colorcomboBox;
        private System.Windows.Forms.Label drawtypelabel;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.ComboBox drawtypecomboBox;
        private System.Windows.Forms.TextBox labeltextBox;
        private System.Windows.Forms.TextBox ylabeltextBox;
        private System.Windows.Forms.TextBox xlabeltextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Button plotbutton;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

