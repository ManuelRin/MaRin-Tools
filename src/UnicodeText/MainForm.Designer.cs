namespace MaRin.Tools.UnicodeText
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btInsert = new System.Windows.Forms.Button();
            this.tbCharNum = new System.Windows.Forms.TextBox();
            this.rbOct = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selInfo = new System.Windows.Forms.Label();
            this.ch = new System.Windows.Forms.Label();
            this.htmlHex = new System.Windows.Forms.Button();
            this.html = new System.Windows.Forms.Button();
            this.hex = new System.Windows.Forms.Button();
            this.uni = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.fontProps = new System.Windows.Forms.PropertyGrid();
            this.splitter = new System.Windows.Forms.Splitter();
            this.tbIn = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(119, 18);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(48, 23);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "&Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // tbCharNum
            // 
            this.tbCharNum.Location = new System.Drawing.Point(6, 20);
            this.tbCharNum.Name = "tbCharNum";
            this.tbCharNum.Size = new System.Drawing.Size(56, 20);
            this.tbCharNum.TabIndex = 0;
            // 
            // rbOct
            // 
            this.rbOct.AutoSize = true;
            this.rbOct.Location = new System.Drawing.Point(68, 7);
            this.rbOct.Name = "rbOct";
            this.rbOct.Size = new System.Drawing.Size(42, 17);
            this.rbOct.TabIndex = 1;
            this.rbOct.Text = "&Oct";
            this.rbOct.UseVisualStyleBackColor = true;
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Checked = true;
            this.rbDec.Location = new System.Drawing.Point(68, 24);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(45, 17);
            this.rbDec.TabIndex = 2;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "&Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(68, 41);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 3;
            this.rbHex.Text = "&Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCharNum);
            this.groupBox1.Controls.Add(this.rbHex);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Controls.Add(this.rbDec);
            this.groupBox1.Controls.Add(this.rbOct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selInfo);
            this.groupBox2.Controls.Add(this.ch);
            this.groupBox2.Controls.Add(this.htmlHex);
            this.groupBox2.Controls.Add(this.html);
            this.groupBox2.Controls.Add(this.hex);
            this.groupBox2.Controls.Add(this.uni);
            this.groupBox2.Controls.Add(this.dec);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection Info";
            // 
            // selInfo
            // 
            this.selInfo.AutoSize = true;
            this.selInfo.Location = new System.Drawing.Point(13, 42);
            this.selInfo.Name = "selInfo";
            this.selInfo.Size = new System.Drawing.Size(16, 13);
            this.selInfo.TabIndex = 6;
            this.selInfo.Text = "...";
            // 
            // ch
            // 
            this.ch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ch.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch.Location = new System.Drawing.Point(8, 15);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(54, 27);
            this.ch.TabIndex = 0;
            this.ch.Text = "葉";
            this.ch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ch.UseMnemonic = false;
            // 
            // htmlHex
            // 
            this.htmlHex.Location = new System.Drawing.Point(468, 16);
            this.htmlHex.Name = "htmlHex";
            this.htmlHex.Size = new System.Drawing.Size(100, 23);
            this.htmlHex.TabIndex = 5;
            this.htmlHex.Text = "...";
            this.htmlHex.UseMnemonic = false;
            this.htmlHex.Click += new System.EventHandler(this.copy_Click);
            // 
            // html
            // 
            this.html.Location = new System.Drawing.Point(368, 16);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(100, 23);
            this.html.TabIndex = 4;
            this.html.Text = "...";
            this.html.UseMnemonic = false;
            this.html.Click += new System.EventHandler(this.copy_Click);
            // 
            // hex
            // 
            this.hex.Location = new System.Drawing.Point(168, 16);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(100, 23);
            this.hex.TabIndex = 2;
            this.hex.Text = "...";
            this.hex.UseMnemonic = false;
            this.hex.Click += new System.EventHandler(this.copy_Click);
            // 
            // uni
            // 
            this.uni.Location = new System.Drawing.Point(268, 16);
            this.uni.Name = "uni";
            this.uni.Size = new System.Drawing.Size(100, 23);
            this.uni.TabIndex = 3;
            this.uni.Text = "...";
            this.uni.UseMnemonic = false;
            this.uni.Click += new System.EventHandler(this.copy_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(68, 16);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(100, 23);
            this.dec.TabIndex = 1;
            this.dec.Text = "...";
            this.dec.UseMnemonic = false;
            this.dec.Click += new System.EventHandler(this.copy_Click);
            // 
            // fontProps
            // 
            this.fontProps.Dock = System.Windows.Forms.DockStyle.Right;
            this.fontProps.Location = new System.Drawing.Point(556, 120);
            this.fontProps.Name = "fontProps";
            this.fontProps.Size = new System.Drawing.Size(188, 329);
            this.fontProps.TabIndex = 3;
            this.fontProps.Visible = false;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(553, 120);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 329);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            this.splitter.Visible = false;
            // 
            // tbIn
            // 
            this.tbIn.AcceptsTab = true;
            this.tbIn.DetectUrls = false;
            this.tbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIn.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn.HideSelection = false;
            this.tbIn.Location = new System.Drawing.Point(0, 120);
            this.tbIn.MaxLength = 0;
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(553, 329);
            this.tbIn.TabIndex = 0;
            this.tbIn.Text = resources.GetString("tbIn.Text");
            this.tbIn.SelectionChanged += new System.EventHandler(this.tbIn_Update);
            this.tbIn.TextChanged += new System.EventHandler(this.tbIn_Update);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 449);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.fontProps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(585, 175);
            this.Name = "MainForm";
            this.Text = "Unicode Text";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btInsert;
		private System.Windows.Forms.TextBox tbCharNum;
		private System.Windows.Forms.RadioButton rbOct;
		private System.Windows.Forms.RadioButton rbDec;
		private System.Windows.Forms.RadioButton rbHex;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button htmlHex;
		private System.Windows.Forms.Button html;
		private System.Windows.Forms.Button hex;
		private System.Windows.Forms.Button uni;
		private System.Windows.Forms.Button dec;
		private System.Windows.Forms.Label ch;
		private System.Windows.Forms.PropertyGrid fontProps;
		private System.Windows.Forms.Splitter splitter;
		private System.Windows.Forms.RichTextBox tbIn;
		private System.Windows.Forms.Label selInfo;
	}
}

