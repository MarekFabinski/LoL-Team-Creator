namespace LoL_Team_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topLane = new System.Windows.Forms.Button();
            this.jungler = new System.Windows.Forms.Button();
            this.midLane = new System.Windows.Forms.Button();
            this.carry = new System.Windows.Forms.Button();
            this.support = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adc = new System.Windows.Forms.PictureBox();
            this.supp = new System.Windows.Forms.PictureBox();
            this.mid = new System.Windows.Forms.PictureBox();
            this.jungle = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // topLane
            // 
            this.topLane.Location = new System.Drawing.Point(482, 113);
            this.topLane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topLane.Name = "topLane";
            this.topLane.Size = new System.Drawing.Size(77, 19);
            this.topLane.TabIndex = 1;
            this.topLane.Text = "Top";
            this.topLane.UseVisualStyleBackColor = true;
            this.topLane.Click += new System.EventHandler(this.TopLane_Click);
            // 
            // jungler
            // 
            this.jungler.Location = new System.Drawing.Point(482, 136);
            this.jungler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jungler.Name = "jungler";
            this.jungler.Size = new System.Drawing.Size(77, 19);
            this.jungler.TabIndex = 2;
            this.jungler.Text = "Jungle";
            this.jungler.UseVisualStyleBackColor = true;
            this.jungler.Click += new System.EventHandler(this.Jungler_Click);
            // 
            // midLane
            // 
            this.midLane.Location = new System.Drawing.Point(482, 160);
            this.midLane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.midLane.Name = "midLane";
            this.midLane.Size = new System.Drawing.Size(77, 19);
            this.midLane.TabIndex = 3;
            this.midLane.Text = "Mid";
            this.midLane.UseVisualStyleBackColor = true;
            this.midLane.Click += new System.EventHandler(this.MidLane_Click);
            // 
            // carry
            // 
            this.carry.Location = new System.Drawing.Point(482, 183);
            this.carry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carry.Name = "carry";
            this.carry.Size = new System.Drawing.Size(77, 19);
            this.carry.TabIndex = 4;
            this.carry.Text = "AD Carry";
            this.carry.UseVisualStyleBackColor = true;
            this.carry.Click += new System.EventHandler(this.Carry_Click);
            // 
            // support
            // 
            this.support.Location = new System.Drawing.Point(482, 207);
            this.support.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.support.Name = "support";
            this.support.Size = new System.Drawing.Size(77, 19);
            this.support.TabIndex = 5;
            this.support.Text = "Support";
            this.support.UseVisualStyleBackColor = true;
            this.support.Click += new System.EventHandler(this.Support_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 19);
            this.button1.TabIndex = 11;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // adc
            // 
            this.adc.BackColor = System.Drawing.Color.Transparent;
            this.adc.Location = new System.Drawing.Point(383, 297);
            this.adc.Margin = new System.Windows.Forms.Padding(2);
            this.adc.Name = "adc";
            this.adc.Size = new System.Drawing.Size(38, 41);
            this.adc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adc.TabIndex = 10;
            this.adc.TabStop = false;
            // 
            // supp
            // 
            this.supp.BackColor = System.Drawing.Color.Transparent;
            this.supp.Location = new System.Drawing.Point(341, 320);
            this.supp.Margin = new System.Windows.Forms.Padding(2);
            this.supp.Name = "supp";
            this.supp.Size = new System.Drawing.Size(38, 41);
            this.supp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supp.TabIndex = 9;
            this.supp.TabStop = false;
            // 
            // mid
            // 
            this.mid.BackColor = System.Drawing.Color.Transparent;
            this.mid.Location = new System.Drawing.Point(237, 163);
            this.mid.Margin = new System.Windows.Forms.Padding(2);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(38, 41);
            this.mid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mid.TabIndex = 8;
            this.mid.TabStop = false;
            // 
            // jungle
            // 
            this.jungle.BackColor = System.Drawing.Color.Transparent;
            this.jungle.Location = new System.Drawing.Point(248, 243);
            this.jungle.Margin = new System.Windows.Forms.Padding(2);
            this.jungle.Name = "jungle";
            this.jungle.Size = new System.Drawing.Size(38, 41);
            this.jungle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jungle.TabIndex = 7;
            this.jungle.TabStop = false;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.Location = new System.Drawing.Point(117, 53);
            this.top.Margin = new System.Windows.Forms.Padding(2);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(38, 41);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 6;
            this.top.TabStop = false;
            // 
            // map
            // 
            this.map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("map.BackgroundImage")));
            this.map.Image = global::LoL_Team_Creator.Properties.Resources.SR;
            this.map.Location = new System.Drawing.Point(9, 10);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(450, 400);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adc);
            this.Controls.Add(this.supp);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.jungle);
            this.Controls.Add(this.top);
            this.Controls.Add(this.support);
            this.Controls.Add(this.carry);
            this.Controls.Add(this.midLane);
            this.Controls.Add(this.jungler);
            this.Controls.Add(this.topLane);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LoL Team Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Button topLane;
        private System.Windows.Forms.Button jungler;
        private System.Windows.Forms.Button midLane;
        private System.Windows.Forms.Button carry;
        private System.Windows.Forms.Button support;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox jungle;
        private System.Windows.Forms.PictureBox mid;
        private System.Windows.Forms.PictureBox supp;
        private System.Windows.Forms.PictureBox adc;
        private System.Windows.Forms.Button button1;
    }
}

