namespace Dijkstra_Demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeDijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraHeapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraFibonnaciHeapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.gboxLogs = new System.Windows.Forms.GroupBox();
            this.txbLogs = new System.Windows.Forms.RichTextBox();
            this.gboxChooseMethod = new System.Windows.Forms.GroupBox();
            this.pnlDemo = new System.Windows.Forms.Panel();
            this.cbDemo = new System.Windows.Forms.ComboBox();
            this.rbtnDraw = new System.Windows.Forms.RadioButton();
            this.rbtnDemo = new System.Windows.Forms.RadioButton();
            this.gboxType = new System.Windows.Forms.GroupBox();
            this.rbtnUnDirected = new System.Windows.Forms.RadioButton();
            this.rbtnDirected = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDijkstra = new System.Windows.Forms.Panel();
            this.gboxCode = new System.Windows.Forms.GroupBox();
            this.txbCode = new System.Windows.Forms.RichTextBox();
            this.gboxRun = new System.Windows.Forms.GroupBox();
            this.pnlTimeSleep = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTimeSleep = new System.Windows.Forms.TextBox();
            this.cbxTimeSleep = new System.Windows.Forms.CheckBox();
            this.btnRunDijkstra = new System.Windows.Forms.Button();
            this.btnRunStepDijkstra = new System.Windows.Forms.Button();
            this.gboxChoosePoint = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEndPoint = new System.Windows.Forms.ComboBox();
            this.cbStartPoint = new System.Windows.Forms.ComboBox();
            this.gboxPath = new System.Windows.Forms.GroupBox();
            this.txbLogDijkstra = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlTested = new System.Windows.Forms.Panel();
            this.btnClearTested = new System.Windows.Forms.Button();
            this.lbRecommed = new System.Windows.Forms.Label();
            this.fpnlTested = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.txbStarting = new System.Windows.Forms.TextBox();
            this.txbListLocation = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLogPrim = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTimeSleep2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSleepTime = new System.Windows.Forms.TextBox();
            this.cbxTimeSleep2 = new System.Windows.Forms.CheckBox();
            this.btnRunPrim = new System.Windows.Forms.Button();
            this.btnRunStepPrim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStartVertex = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnColor = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDrawPoint = new System.Windows.Forms.Button();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnOpenGraph = new System.Windows.Forms.Button();
            this.lvTableView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMatrixView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctMenuStripMatrix = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyMatrixToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGridLine = new System.Windows.Forms.CheckBox();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picGraphView = new System.Windows.Forms.PictureBox();
            this.ctMenustripGrapView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGraphImageInClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.MyColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlChoose.SuspendLayout();
            this.gboxLogs.SuspendLayout();
            this.gboxChooseMethod.SuspendLayout();
            this.pnlDemo.SuspendLayout();
            this.gboxType.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlDijkstra.SuspendLayout();
            this.gboxCode.SuspendLayout();
            this.gboxRun.SuspendLayout();
            this.pnlTimeSleep.SuspendLayout();
            this.gboxChoosePoint.SuspendLayout();
            this.gboxPath.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlTested.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTimeSleep2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctMenuStripMatrix.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphView)).BeginInit();
            this.ctMenustripGrapView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = global::Dijkstra_Demo.Properties.Resources.New;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Dijkstra_Demo.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Dijkstra_Demo.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.saveAsImageToolStripMenuItem.Text = "Save as Image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeDijkstraToolStripMenuItem,
            this.guideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // codeDijkstraToolStripMenuItem
            // 
            this.codeDijkstraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijkstraToolStripMenuItem,
            this.dijkstraHeapToolStripMenuItem,
            this.dijkstraFibonnaciHeapsToolStripMenuItem});
            this.codeDijkstraToolStripMenuItem.Name = "codeDijkstraToolStripMenuItem";
            this.codeDijkstraToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.codeDijkstraToolStripMenuItem.Text = "Code Dijkstra C++";
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra ";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.dijkstraToolStripMenuItem_Click);
            // 
            // dijkstraHeapToolStripMenuItem
            // 
            this.dijkstraHeapToolStripMenuItem.Name = "dijkstraHeapToolStripMenuItem";
            this.dijkstraHeapToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dijkstraHeapToolStripMenuItem.Text = "Dijkstra Heap";
            this.dijkstraHeapToolStripMenuItem.Click += new System.EventHandler(this.dijkstraHeapToolStripMenuItem_Click);
            // 
            // dijkstraFibonnaciHeapsToolStripMenuItem
            // 
            this.dijkstraFibonnaciHeapsToolStripMenuItem.Name = "dijkstraFibonnaciHeapsToolStripMenuItem";
            this.dijkstraFibonnaciHeapsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dijkstraFibonnaciHeapsToolStripMenuItem.Text = "Dijkstra Fibonnaci Heaps";
            this.dijkstraFibonnaciHeapsToolStripMenuItem.Click += new System.EventHandler(this.dijkstraFibonnaciHeapsToolStripMenuItem_Click);
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(740, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlChoose);
            this.tabPage1.Controls.Add(this.gboxType);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(547, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlChoose
            // 
            this.pnlChoose.Controls.Add(this.gboxLogs);
            this.pnlChoose.Controls.Add(this.gboxChooseMethod);
            this.pnlChoose.Enabled = false;
            this.pnlChoose.Location = new System.Drawing.Point(0, 103);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(541, 403);
            this.pnlChoose.TabIndex = 3;
            // 
            // gboxLogs
            // 
            this.gboxLogs.Controls.Add(this.txbLogs);
            this.gboxLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxLogs.Location = new System.Drawing.Point(6, 90);
            this.gboxLogs.Name = "gboxLogs";
            this.gboxLogs.Size = new System.Drawing.Size(532, 313);
            this.gboxLogs.TabIndex = 3;
            this.gboxLogs.TabStop = false;
            this.gboxLogs.Text = "Logs";
            // 
            // txbLogs
            // 
            this.txbLogs.BackColor = System.Drawing.Color.White;
            this.txbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogs.Location = new System.Drawing.Point(6, 22);
            this.txbLogs.Name = "txbLogs";
            this.txbLogs.ReadOnly = true;
            this.txbLogs.Size = new System.Drawing.Size(526, 284);
            this.txbLogs.TabIndex = 0;
            this.txbLogs.Text = "Welcome! \n";
            // 
            // gboxChooseMethod
            // 
            this.gboxChooseMethod.Controls.Add(this.pnlDemo);
            this.gboxChooseMethod.Controls.Add(this.rbtnDraw);
            this.gboxChooseMethod.Controls.Add(this.rbtnDemo);
            this.gboxChooseMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxChooseMethod.Location = new System.Drawing.Point(6, 12);
            this.gboxChooseMethod.Name = "gboxChooseMethod";
            this.gboxChooseMethod.Size = new System.Drawing.Size(532, 72);
            this.gboxChooseMethod.TabIndex = 3;
            this.gboxChooseMethod.TabStop = false;
            this.gboxChooseMethod.Text = "Choose Method";
            // 
            // pnlDemo
            // 
            this.pnlDemo.Controls.Add(this.cbDemo);
            this.pnlDemo.Enabled = false;
            this.pnlDemo.Location = new System.Drawing.Point(224, 14);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.Size = new System.Drawing.Size(176, 52);
            this.pnlDemo.TabIndex = 4;
            // 
            // cbDemo
            // 
            this.cbDemo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDemo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDemo.FormattingEnabled = true;
            this.cbDemo.Items.AddRange(new object[] {
            "Demo 1",
            "Demo 2",
            "Demo 3",
            "Demo 4",
            "Demo 5"});
            this.cbDemo.Location = new System.Drawing.Point(17, 11);
            this.cbDemo.Name = "cbDemo";
            this.cbDemo.Size = new System.Drawing.Size(143, 23);
            this.cbDemo.TabIndex = 0;
            this.cbDemo.SelectedIndexChanged += new System.EventHandler(this.cbDemo_SelectedIndexChanged);
            // 
            // rbtnDraw
            // 
            this.rbtnDraw.AutoSize = true;
            this.rbtnDraw.Checked = true;
            this.rbtnDraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDraw.ForeColor = System.Drawing.Color.Black;
            this.rbtnDraw.Location = new System.Drawing.Point(22, 27);
            this.rbtnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDraw.Name = "rbtnDraw";
            this.rbtnDraw.Size = new System.Drawing.Size(52, 19);
            this.rbtnDraw.TabIndex = 1;
            this.rbtnDraw.TabStop = true;
            this.rbtnDraw.Text = "Draw";
            this.toolTip1.SetToolTip(this.rbtnDraw, "Draw Yourself");
            this.rbtnDraw.UseVisualStyleBackColor = true;
            this.rbtnDraw.CheckedChanged += new System.EventHandler(this.rbtnDraw_CheckedChanged);
            // 
            // rbtnDemo
            // 
            this.rbtnDemo.AutoSize = true;
            this.rbtnDemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDemo.ForeColor = System.Drawing.Color.Black;
            this.rbtnDemo.Location = new System.Drawing.Point(141, 27);
            this.rbtnDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDemo.Name = "rbtnDemo";
            this.rbtnDemo.Size = new System.Drawing.Size(57, 19);
            this.rbtnDemo.TabIndex = 1;
            this.rbtnDemo.TabStop = true;
            this.rbtnDemo.Text = "Demo";
            this.toolTip1.SetToolTip(this.rbtnDemo, "Use Demo Graph");
            this.rbtnDemo.UseVisualStyleBackColor = true;
            this.rbtnDemo.CheckedChanged += new System.EventHandler(this.rbtnDemo_CheckedChanged);
            // 
            // gboxType
            // 
            this.gboxType.Controls.Add(this.rbtnUnDirected);
            this.gboxType.Controls.Add(this.rbtnDirected);
            this.gboxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxType.Location = new System.Drawing.Point(6, 8);
            this.gboxType.Name = "gboxType";
            this.gboxType.Size = new System.Drawing.Size(535, 92);
            this.gboxType.TabIndex = 2;
            this.gboxType.TabStop = false;
            this.gboxType.Text = "Graph Type";
            // 
            // rbtnUnDirected
            // 
            this.rbtnUnDirected.AutoSize = true;
            this.rbtnUnDirected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUnDirected.ForeColor = System.Drawing.Color.Black;
            this.rbtnUnDirected.Location = new System.Drawing.Point(22, 27);
            this.rbtnUnDirected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnUnDirected.Name = "rbtnUnDirected";
            this.rbtnUnDirected.Size = new System.Drawing.Size(84, 19);
            this.rbtnUnDirected.TabIndex = 1;
            this.rbtnUnDirected.TabStop = true;
            this.rbtnUnDirected.Text = "UnDirected";
            this.toolTip1.SetToolTip(this.rbtnUnDirected, "Using UnDirected Graph");
            this.rbtnUnDirected.UseVisualStyleBackColor = true;
            this.rbtnUnDirected.CheckedChanged += new System.EventHandler(this.rbtnUnDirected_CheckedChanged);
            // 
            // rbtnDirected
            // 
            this.rbtnDirected.AutoSize = true;
            this.rbtnDirected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDirected.ForeColor = System.Drawing.Color.Black;
            this.rbtnDirected.Location = new System.Drawing.Point(22, 56);
            this.rbtnDirected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDirected.Name = "rbtnDirected";
            this.rbtnDirected.Size = new System.Drawing.Size(69, 19);
            this.rbtnDirected.TabIndex = 1;
            this.rbtnDirected.TabStop = true;
            this.rbtnDirected.Text = "Directed";
            this.toolTip1.SetToolTip(this.rbtnDirected, "Using Directed Graph");
            this.rbtnDirected.UseVisualStyleBackColor = true;
            this.rbtnDirected.CheckedChanged += new System.EventHandler(this.rbtnDirected_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlDijkstra);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(547, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dijkstra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlDijkstra
            // 
            this.pnlDijkstra.Controls.Add(this.gboxCode);
            this.pnlDijkstra.Controls.Add(this.gboxRun);
            this.pnlDijkstra.Controls.Add(this.gboxChoosePoint);
            this.pnlDijkstra.Controls.Add(this.gboxPath);
            this.pnlDijkstra.Enabled = false;
            this.pnlDijkstra.Location = new System.Drawing.Point(3, 3);
            this.pnlDijkstra.Name = "pnlDijkstra";
            this.pnlDijkstra.Size = new System.Drawing.Size(538, 500);
            this.pnlDijkstra.TabIndex = 23;
            // 
            // gboxCode
            // 
            this.gboxCode.Controls.Add(this.txbCode);
            this.gboxCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxCode.Location = new System.Drawing.Point(3, 338);
            this.gboxCode.Name = "gboxCode";
            this.gboxCode.Size = new System.Drawing.Size(532, 162);
            this.gboxCode.TabIndex = 6;
            this.gboxCode.TabStop = false;
            this.gboxCode.Text = "PseudoCode";
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.Color.White;
            this.txbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCode.Location = new System.Drawing.Point(6, 22);
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.Size = new System.Drawing.Size(520, 130);
            this.txbCode.TabIndex = 1;
            this.txbCode.Text = "";
            // 
            // gboxRun
            // 
            this.gboxRun.Controls.Add(this.pnlTimeSleep);
            this.gboxRun.Controls.Add(this.cbxTimeSleep);
            this.gboxRun.Controls.Add(this.btnRunDijkstra);
            this.gboxRun.Controls.Add(this.btnRunStepDijkstra);
            this.gboxRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxRun.Location = new System.Drawing.Point(3, 109);
            this.gboxRun.Name = "gboxRun";
            this.gboxRun.Size = new System.Drawing.Size(532, 103);
            this.gboxRun.TabIndex = 7;
            this.gboxRun.TabStop = false;
            this.gboxRun.Text = "Run Method";
            // 
            // pnlTimeSleep
            // 
            this.pnlTimeSleep.Controls.Add(this.label7);
            this.pnlTimeSleep.Controls.Add(this.txbTimeSleep);
            this.pnlTimeSleep.Enabled = false;
            this.pnlTimeSleep.Location = new System.Drawing.Point(131, 60);
            this.pnlTimeSleep.Name = "pnlTimeSleep";
            this.pnlTimeSleep.Size = new System.Drawing.Size(210, 33);
            this.pnlTimeSleep.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(112, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "millisecond ";
            // 
            // txbTimeSleep
            // 
            this.txbTimeSleep.Location = new System.Drawing.Point(4, 3);
            this.txbTimeSleep.Name = "txbTimeSleep";
            this.txbTimeSleep.Size = new System.Drawing.Size(100, 23);
            this.txbTimeSleep.TabIndex = 23;
            // 
            // cbxTimeSleep
            // 
            this.cbxTimeSleep.AutoSize = true;
            this.cbxTimeSleep.ForeColor = System.Drawing.Color.Black;
            this.cbxTimeSleep.Location = new System.Drawing.Point(22, 68);
            this.cbxTimeSleep.Name = "cbxTimeSleep";
            this.cbxTimeSleep.Size = new System.Drawing.Size(83, 19);
            this.cbxTimeSleep.TabIndex = 22;
            this.cbxTimeSleep.Text = "Time Sleep";
            this.toolTip1.SetToolTip(this.cbxTimeSleep, "Run with timesleep");
            this.cbxTimeSleep.UseVisualStyleBackColor = true;
            this.cbxTimeSleep.CheckedChanged += new System.EventHandler(this.cbxTimeSleep_CheckedChanged);
            // 
            // btnRunDijkstra
            // 
            this.btnRunDijkstra.ForeColor = System.Drawing.Color.Black;
            this.btnRunDijkstra.Image = global::Dijkstra_Demo.Properties.Resources.Play;
            this.btnRunDijkstra.Location = new System.Drawing.Point(19, 26);
            this.btnRunDijkstra.Name = "btnRunDijkstra";
            this.btnRunDijkstra.Size = new System.Drawing.Size(148, 30);
            this.btnRunDijkstra.TabIndex = 4;
            this.btnRunDijkstra.Text = "Run";
            this.btnRunDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunDijkstra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunDijkstra.UseVisualStyleBackColor = true;
            this.btnRunDijkstra.Click += new System.EventHandler(this.btnRunDijkstra_Click);
            // 
            // btnRunStepDijkstra
            // 
            this.btnRunStepDijkstra.ForeColor = System.Drawing.Color.Black;
            this.btnRunStepDijkstra.Image = global::Dijkstra_Demo.Properties.Resources.Skip;
            this.btnRunStepDijkstra.Location = new System.Drawing.Point(178, 26);
            this.btnRunStepDijkstra.Name = "btnRunStepDijkstra";
            this.btnRunStepDijkstra.Size = new System.Drawing.Size(148, 30);
            this.btnRunStepDijkstra.TabIndex = 6;
            this.btnRunStepDijkstra.Text = "Run Step";
            this.btnRunStepDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunStepDijkstra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRunStepDijkstra, "Only for single Point to single Point");
            this.btnRunStepDijkstra.UseVisualStyleBackColor = true;
            this.btnRunStepDijkstra.Click += new System.EventHandler(this.btnRunStepDijkstra_Click);
            // 
            // gboxChoosePoint
            // 
            this.gboxChoosePoint.Controls.Add(this.label4);
            this.gboxChoosePoint.Controls.Add(this.label6);
            this.gboxChoosePoint.Controls.Add(this.label5);
            this.gboxChoosePoint.Controls.Add(this.cbEndPoint);
            this.gboxChoosePoint.Controls.Add(this.cbStartPoint);
            this.gboxChoosePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxChoosePoint.Location = new System.Drawing.Point(3, 3);
            this.gboxChoosePoint.Name = "gboxChoosePoint";
            this.gboxChoosePoint.Size = new System.Drawing.Size(532, 100);
            this.gboxChoosePoint.TabIndex = 3;
            this.gboxChoosePoint.TabStop = false;
            this.gboxChoosePoint.Text = "Choose Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(152, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Point";
            // 
            // cbEndPoint
            // 
            this.cbEndPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEndPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEndPoint.FormattingEnabled = true;
            this.cbEndPoint.Items.AddRange(new object[] {
            "All"});
            this.cbEndPoint.Location = new System.Drawing.Point(178, 54);
            this.cbEndPoint.Name = "cbEndPoint";
            this.cbEndPoint.Size = new System.Drawing.Size(121, 23);
            this.cbEndPoint.TabIndex = 1;
            // 
            // cbStartPoint
            // 
            this.cbStartPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStartPoint.FormattingEnabled = true;
            this.cbStartPoint.Location = new System.Drawing.Point(19, 54);
            this.cbStartPoint.Name = "cbStartPoint";
            this.cbStartPoint.Size = new System.Drawing.Size(121, 23);
            this.cbStartPoint.TabIndex = 0;
            // 
            // gboxPath
            // 
            this.gboxPath.Controls.Add(this.txbLogDijkstra);
            this.gboxPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxPath.Location = new System.Drawing.Point(3, 218);
            this.gboxPath.Name = "gboxPath";
            this.gboxPath.Size = new System.Drawing.Size(532, 114);
            this.gboxPath.TabIndex = 5;
            this.gboxPath.TabStop = false;
            this.gboxPath.Text = "Path";
            // 
            // txbLogDijkstra
            // 
            this.txbLogDijkstra.BackColor = System.Drawing.Color.White;
            this.txbLogDijkstra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogDijkstra.Location = new System.Drawing.Point(6, 22);
            this.txbLogDijkstra.Name = "txbLogDijkstra";
            this.txbLogDijkstra.ReadOnly = true;
            this.txbLogDijkstra.Size = new System.Drawing.Size(520, 84);
            this.txbLogDijkstra.TabIndex = 1;
            this.txbLogDijkstra.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlTested);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tested";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlTested
            // 
            this.pnlTested.Controls.Add(this.btnClearTested);
            this.pnlTested.Controls.Add(this.lbRecommed);
            this.pnlTested.Controls.Add(this.fpnlTested);
            this.pnlTested.Controls.Add(this.label10);
            this.pnlTested.Controls.Add(this.label9);
            this.pnlTested.Controls.Add(this.btnProcessing);
            this.pnlTested.Controls.Add(this.txbStarting);
            this.pnlTested.Controls.Add(this.txbListLocation);
            this.pnlTested.Enabled = false;
            this.pnlTested.Location = new System.Drawing.Point(3, 3);
            this.pnlTested.Name = "pnlTested";
            this.pnlTested.Size = new System.Drawing.Size(541, 500);
            this.pnlTested.TabIndex = 0;
            // 
            // btnClearTested
            // 
            this.btnClearTested.ForeColor = System.Drawing.Color.Black;
            this.btnClearTested.Location = new System.Drawing.Point(131, 62);
            this.btnClearTested.Name = "btnClearTested";
            this.btnClearTested.Size = new System.Drawing.Size(118, 28);
            this.btnClearTested.TabIndex = 9;
            this.btnClearTested.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClearTested, "Clear Recommend Road");
            this.btnClearTested.UseVisualStyleBackColor = true;
            this.btnClearTested.Click += new System.EventHandler(this.btnClearTested_Click);
            // 
            // lbRecommed
            // 
            this.lbRecommed.AutoSize = true;
            this.lbRecommed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecommed.ForeColor = System.Drawing.Color.Black;
            this.lbRecommed.Location = new System.Drawing.Point(14, 95);
            this.lbRecommed.Name = "lbRecommed";
            this.lbRecommed.Size = new System.Drawing.Size(88, 15);
            this.lbRecommed.TabIndex = 8;
            this.lbRecommed.Text = "Recommended";
            // 
            // fpnlTested
            // 
            this.fpnlTested.AutoScroll = true;
            this.fpnlTested.BackColor = System.Drawing.Color.Transparent;
            this.fpnlTested.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlTested.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlTested.Location = new System.Drawing.Point(7, 118);
            this.fpnlTested.Name = "fpnlTested";
            this.fpnlTested.Size = new System.Drawing.Size(531, 379);
            this.fpnlTested.TabIndex = 7;
            this.fpnlTested.WrapContents = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(81, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "-->";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Starting";
            // 
            // btnProcessing
            // 
            this.btnProcessing.ForeColor = System.Drawing.Color.Black;
            this.btnProcessing.Location = new System.Drawing.Point(7, 62);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(118, 28);
            this.btnProcessing.TabIndex = 3;
            this.btnProcessing.Text = "Processing";
            this.toolTip1.SetToolTip(this.btnProcessing, "Load Recommend Road");
            this.btnProcessing.UseVisualStyleBackColor = true;
            this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
            // 
            // txbStarting
            // 
            this.txbStarting.Location = new System.Drawing.Point(7, 29);
            this.txbStarting.Name = "txbStarting";
            this.txbStarting.Size = new System.Drawing.Size(68, 27);
            this.txbStarting.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbStarting, "One Point Starting");
            // 
            // txbListLocation
            // 
            this.txbListLocation.Location = new System.Drawing.Point(118, 29);
            this.txbListLocation.Name = "txbListLocation";
            this.txbListLocation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbListLocation.Size = new System.Drawing.Size(282, 23);
            this.txbListLocation.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbListLocation, "List Point");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(582, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Prim";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLogPrim);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(6, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 278);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PseudoCode";
            // 
            // tbLogPrim
            // 
            this.tbLogPrim.BackColor = System.Drawing.Color.White;
            this.tbLogPrim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogPrim.Location = new System.Drawing.Point(6, 20);
            this.tbLogPrim.Name = "tbLogPrim";
            this.tbLogPrim.ReadOnly = true;
            this.tbLogPrim.Size = new System.Drawing.Size(558, 254);
            this.tbLogPrim.TabIndex = 1;
            this.tbLogPrim.Text = "";
            this.tbLogPrim.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTimeSleep2);
            this.groupBox1.Controls.Add(this.cbxTimeSleep2);
            this.groupBox1.Controls.Add(this.btnRunPrim);
            this.groupBox1.Controls.Add(this.btnRunStepPrim);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Method";
            // 
            // pnlTimeSleep2
            // 
            this.pnlTimeSleep2.Controls.Add(this.label11);
            this.pnlTimeSleep2.Controls.Add(this.txtSleepTime);
            this.pnlTimeSleep2.Enabled = false;
            this.pnlTimeSleep2.Location = new System.Drawing.Point(131, 60);
            this.pnlTimeSleep2.Name = "pnlTimeSleep2";
            this.pnlTimeSleep2.Size = new System.Drawing.Size(210, 33);
            this.pnlTimeSleep2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(112, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "millisecond ";
            // 
            // txtSleepTime
            // 
            this.txtSleepTime.Location = new System.Drawing.Point(4, 3);
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.Size = new System.Drawing.Size(100, 23);
            this.txtSleepTime.TabIndex = 23;
            // 
            // cbxTimeSleep2
            // 
            this.cbxTimeSleep2.AutoSize = true;
            this.cbxTimeSleep2.ForeColor = System.Drawing.Color.Black;
            this.cbxTimeSleep2.Location = new System.Drawing.Point(22, 68);
            this.cbxTimeSleep2.Name = "cbxTimeSleep2";
            this.cbxTimeSleep2.Size = new System.Drawing.Size(83, 19);
            this.cbxTimeSleep2.TabIndex = 22;
            this.cbxTimeSleep2.Text = "Time Sleep";
            this.toolTip1.SetToolTip(this.cbxTimeSleep2, "Run with timesleep");
            this.cbxTimeSleep2.UseVisualStyleBackColor = true;
            this.cbxTimeSleep2.CheckedChanged += new System.EventHandler(this.cbxTimeSleep2_CheckedChanged);
            // 
            // btnRunPrim
            // 
            this.btnRunPrim.ForeColor = System.Drawing.Color.Black;
            this.btnRunPrim.Image = global::Dijkstra_Demo.Properties.Resources.Play;
            this.btnRunPrim.Location = new System.Drawing.Point(19, 26);
            this.btnRunPrim.Name = "btnRunPrim";
            this.btnRunPrim.Size = new System.Drawing.Size(148, 30);
            this.btnRunPrim.TabIndex = 4;
            this.btnRunPrim.Text = "Run";
            this.btnRunPrim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunPrim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunPrim.UseVisualStyleBackColor = true;
            this.btnRunPrim.Click += new System.EventHandler(this.btnRunPrim_Click);
            // 
            // btnRunStepPrim
            // 
            this.btnRunStepPrim.ForeColor = System.Drawing.Color.Black;
            this.btnRunStepPrim.Image = global::Dijkstra_Demo.Properties.Resources.Skip;
            this.btnRunStepPrim.Location = new System.Drawing.Point(178, 26);
            this.btnRunStepPrim.Name = "btnRunStepPrim";
            this.btnRunStepPrim.Size = new System.Drawing.Size(148, 30);
            this.btnRunStepPrim.TabIndex = 6;
            this.btnRunStepPrim.Text = "Run Step";
            this.btnRunStepPrim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunStepPrim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRunStepPrim, "Only for single Point to single Point");
            this.btnRunStepPrim.UseVisualStyleBackColor = true;
            this.btnRunStepPrim.Click += new System.EventHandler(this.btnRunStepPrim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbStartVertex);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Point";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Start Point";
            // 
            // cbStartVertex
            // 
            this.cbStartVertex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartVertex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStartVertex.FormattingEnabled = true;
            this.cbStartVertex.Location = new System.Drawing.Point(19, 54);
            this.cbStartVertex.Name = "cbStartVertex";
            this.cbStartVertex.Size = new System.Drawing.Size(121, 23);
            this.cbStartVertex.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.Paint;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnColor.Location = new System.Drawing.Point(438, 6);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(35, 35);
            this.btnColor.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnColor, "Click to Draw Color Point");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.Update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Location = new System.Drawing.Point(602, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(35, 35);
            this.btnUpdate.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnUpdate, "Click to Update Change");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.New;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNew.Location = new System.Drawing.Point(315, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(35, 35);
            this.btnNew.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNew, "Click to Create New Graph");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDrawPoint
            // 
            this.btnDrawPoint.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawPoint.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.DrawPoint;
            this.btnDrawPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawPoint.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDrawPoint.FlatAppearance.BorderSize = 0;
            this.btnDrawPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDrawPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDrawPoint.Location = new System.Drawing.Point(479, 6);
            this.btnDrawPoint.Name = "btnDrawPoint";
            this.btnDrawPoint.Size = new System.Drawing.Size(35, 35);
            this.btnDrawPoint.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDrawPoint, "Click to Draw Point");
            this.btnDrawPoint.UseVisualStyleBackColor = true;
            this.btnDrawPoint.Click += new System.EventHandler(this.btnDrawPoint_Click);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveGraph.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.Save;
            this.btnSaveGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveGraph.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSaveGraph.FlatAppearance.BorderSize = 0;
            this.btnSaveGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSaveGraph.Location = new System.Drawing.Point(397, 6);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(35, 35);
            this.btnSaveGraph.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSaveGraph, "Click to Save Graph");
            this.btnSaveGraph.UseVisualStyleBackColor = true;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.DrawLine;
            this.btnDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawLine.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDrawLine.FlatAppearance.BorderSize = 0;
            this.btnDrawLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDrawLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDrawLine.Location = new System.Drawing.Point(520, 6);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(35, 35);
            this.btnDrawLine.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnDrawLine, "Click to Draw Line");
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.Move;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMove.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMove.Location = new System.Drawing.Point(561, 6);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(35, 35);
            this.btnMove.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnMove, "Click to Move Point");
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnOpenGraph
            // 
            this.btnOpenGraph.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenGraph.BackgroundImage = global::Dijkstra_Demo.Properties.Resources.Open;
            this.btnOpenGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenGraph.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnOpenGraph.FlatAppearance.BorderSize = 0;
            this.btnOpenGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOpenGraph.Location = new System.Drawing.Point(356, 6);
            this.btnOpenGraph.Name = "btnOpenGraph";
            this.btnOpenGraph.Size = new System.Drawing.Size(35, 35);
            this.btnOpenGraph.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnOpenGraph, "Click to Open File Graph");
            this.btnOpenGraph.UseVisualStyleBackColor = true;
            this.btnOpenGraph.Click += new System.EventHandler(this.btnOpenGraph_Click);
            // 
            // lvTableView
            // 
            this.lvTableView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTableView.FullRowSelect = true;
            this.lvTableView.HideSelection = false;
            this.lvTableView.Location = new System.Drawing.Point(498, 572);
            this.lvTableView.Name = "lvTableView";
            this.lvTableView.Size = new System.Drawing.Size(797, 204);
            this.lvTableView.TabIndex = 4;
            this.lvTableView.UseCompatibleStateImageBehavior = false;
            this.lvTableView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "- Graph View -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(494, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "- Table -";
            // 
            // lvMatrixView
            // 
            this.lvMatrixView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvMatrixView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvMatrixView.ContextMenuStrip = this.ctMenuStripMatrix;
            this.lvMatrixView.FullRowSelect = true;
            this.lvMatrixView.HideSelection = false;
            this.lvMatrixView.Location = new System.Drawing.Point(12, 572);
            this.lvMatrixView.Name = "lvMatrixView";
            this.lvMatrixView.Size = new System.Drawing.Size(480, 204);
            this.lvMatrixView.TabIndex = 14;
            this.lvMatrixView.UseCompatibleStateImageBehavior = false;
            this.lvMatrixView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 35;
            // 
            // ctMenuStripMatrix
            // 
            this.ctMenuStripMatrix.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMenuStripMatrix.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMatrixToClipboardToolStripMenuItem});
            this.ctMenuStripMatrix.Name = "ctMenuStripMatrix";
            this.ctMenuStripMatrix.Size = new System.Drawing.Size(209, 26);
            // 
            // copyMatrixToClipboardToolStripMenuItem
            // 
            this.copyMatrixToClipboardToolStripMenuItem.Name = "copyMatrixToClipboardToolStripMenuItem";
            this.copyMatrixToClipboardToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.copyMatrixToClipboardToolStripMenuItem.Text = "Copy Matrix to Clipboard";
            this.copyMatrixToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyMatrixToClipboardToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "- Matrix -";
            // 
            // cbxGridLine
            // 
            this.cbxGridLine.AutoSize = true;
            this.cbxGridLine.ForeColor = System.Drawing.Color.Black;
            this.cbxGridLine.Location = new System.Drawing.Point(643, 17);
            this.cbxGridLine.Name = "cbxGridLine";
            this.cbxGridLine.Size = new System.Drawing.Size(75, 19);
            this.cbxGridLine.TabIndex = 21;
            this.cbxGridLine.Text = "GridLines";
            this.cbxGridLine.UseVisualStyleBackColor = true;
            this.cbxGridLine.CheckedChanged += new System.EventHandler(this.cbxSnapGrid_CheckedChanged);
            // 
            // pnlGraph
            // 
            this.pnlGraph.Controls.Add(this.btnColor);
            this.pnlGraph.Controls.Add(this.lbStatus);
            this.pnlGraph.Controls.Add(this.label8);
            this.pnlGraph.Controls.Add(this.btnUpdate);
            this.pnlGraph.Controls.Add(this.picGraphView);
            this.pnlGraph.Controls.Add(this.cbxGridLine);
            this.pnlGraph.Controls.Add(this.label1);
            this.pnlGraph.Controls.Add(this.btnNew);
            this.pnlGraph.Controls.Add(this.btnDrawPoint);
            this.pnlGraph.Controls.Add(this.btnSaveGraph);
            this.pnlGraph.Controls.Add(this.btnDrawLine);
            this.pnlGraph.Controls.Add(this.btnMove);
            this.pnlGraph.Controls.Add(this.btnOpenGraph);
            this.pnlGraph.Enabled = false;
            this.pnlGraph.Location = new System.Drawing.Point(0, 28);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(740, 516);
            this.pnlGraph.TabIndex = 22;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(63, 22);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(88, 15);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "View and move";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Status: ";
            // 
            // picGraphView
            // 
            this.picGraphView.BackColor = System.Drawing.Color.White;
            this.picGraphView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGraphView.ContextMenuStrip = this.ctMenustripGrapView;
            this.picGraphView.Location = new System.Drawing.Point(12, 43);
            this.picGraphView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picGraphView.Name = "picGraphView";
            this.picGraphView.Size = new System.Drawing.Size(722, 469);
            this.picGraphView.TabIndex = 3;
            this.picGraphView.TabStop = false;
            this.picGraphView.Paint += new System.Windows.Forms.PaintEventHandler(this.picGraphView_Paint);
            this.picGraphView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGraphView_MouseDown);
            this.picGraphView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGraphView_MouseMove);
            this.picGraphView.Resize += new System.EventHandler(this.picGraphView_Resize);
            // 
            // ctMenustripGrapView
            // 
            this.ctMenustripGrapView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMenustripGrapView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.copyGraphImageInClipboardToolStripMenuItem});
            this.ctMenustripGrapView.Name = "ctMenustripGrapView";
            this.ctMenustripGrapView.Size = new System.Drawing.Size(261, 70);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // copyGraphImageInClipboardToolStripMenuItem
            // 
            this.copyGraphImageInClipboardToolStripMenuItem.Name = "copyGraphImageInClipboardToolStripMenuItem";
            this.copyGraphImageInClipboardToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.copyGraphImageInClipboardToolStripMenuItem.Text = "Copy Graph image to the clipboard";
            this.copyGraphImageInClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyGraphImageInClipboardToolStripMenuItem_Click);
            // 
            // MyOpenFileDialog
            // 
            this.MyOpenFileDialog.FileName = "Graph";
            this.MyOpenFileDialog.Filter = ".txt|*.txt";
            this.MyOpenFileDialog.Title = "Open Graph";
            // 
            // MySaveFileDialog
            // 
            this.MySaveFileDialog.FileName = "Graph";
            this.MySaveFileDialog.Filter = ".txt|*.txt";
            this.MySaveFileDialog.Title = "Save Graph";
            // 
            // SaveFileDialogImage
            // 
            this.SaveFileDialogImage.FileName = "Graph";
            this.SaveFileDialogImage.Filter = ".png|*.png";
            this.SaveFileDialogImage.Title = "Save Graph Image";
            // 
            // MyColorDialog
            // 
            this.MyColorDialog.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1308, 788);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvMatrixView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvTableView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijkstra Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlChoose.ResumeLayout(false);
            this.gboxLogs.ResumeLayout(false);
            this.gboxChooseMethod.ResumeLayout(false);
            this.gboxChooseMethod.PerformLayout();
            this.pnlDemo.ResumeLayout(false);
            this.gboxType.ResumeLayout(false);
            this.gboxType.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlDijkstra.ResumeLayout(false);
            this.gboxCode.ResumeLayout(false);
            this.gboxRun.ResumeLayout(false);
            this.gboxRun.PerformLayout();
            this.pnlTimeSleep.ResumeLayout(false);
            this.pnlTimeSleep.PerformLayout();
            this.gboxChoosePoint.ResumeLayout(false);
            this.gboxChoosePoint.PerformLayout();
            this.gboxPath.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlTested.ResumeLayout(false);
            this.pnlTested.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTimeSleep2.ResumeLayout(false);
            this.pnlTimeSleep2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctMenuStripMatrix.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphView)).EndInit();
            this.ctMenustripGrapView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtnDirected;
        private System.Windows.Forms.RadioButton rbtnUnDirected;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picGraphView;
        private System.Windows.Forms.ListView lvTableView;
        private System.Windows.Forms.Button btnDrawPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMatrixView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnOpenGraph;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.GroupBox gboxType;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.GroupBox gboxChooseMethod;
        private System.Windows.Forms.RadioButton rbtnDraw;
        private System.Windows.Forms.RadioButton rbtnDemo;
        private System.Windows.Forms.GroupBox gboxLogs;
        private System.Windows.Forms.GroupBox gboxChoosePoint;
        private System.Windows.Forms.ComboBox cbStartPoint;
        private System.Windows.Forms.ComboBox cbEndPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRunDijkstra;
        private System.Windows.Forms.GroupBox gboxPath;
        private System.Windows.Forms.GroupBox gboxRun;
        private System.Windows.Forms.Button btnRunStepDijkstra;
        private System.Windows.Forms.CheckBox cbxGridLine;
        private System.Windows.Forms.CheckBox cbxTimeSleep;
        private System.Windows.Forms.TextBox txbTimeSleep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTimeSleep;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.RichTextBox txbLogs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.OpenFileDialog MyOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog MySaveFileDialog;
        private System.Windows.Forms.RichTextBox txbLogDijkstra;
        private System.Windows.Forms.Panel pnlDijkstra;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogImage;
        private System.Windows.Forms.ToolStripMenuItem codeDijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraHeapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraFibonnaciHeapsToolStripMenuItem;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog MyColorDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlTested;
        private System.Windows.Forms.TextBox txbListLocation;
        private System.Windows.Forms.TextBox txbStarting;
        private System.Windows.Forms.Button btnProcessing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel fpnlTested;
        private System.Windows.Forms.Label lbRecommed;
        private System.Windows.Forms.ContextMenuStrip ctMenustripGrapView;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGraphImageInClipboardToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctMenuStripMatrix;
        private System.Windows.Forms.ToolStripMenuItem copyMatrixToClipboardToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDemo;
        private System.Windows.Forms.ComboBox cbDemo;
        private System.Windows.Forms.Button btnClearTested;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.GroupBox gboxCode;
        private System.Windows.Forms.RichTextBox txbCode;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox tbLogPrim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlTimeSleep2;
        private System.Windows.Forms.TextBox txtSleepTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxTimeSleep2;
        private System.Windows.Forms.Button btnRunPrim;
        private System.Windows.Forms.Button btnRunStepPrim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStartVertex;
    }
}

