
namespace Switchless
{
    partial class Switchless
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switchless));
            this.startOsu = new System.Windows.Forms.Button();
            this.selectOsu = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.switchlessLabel = new System.Windows.Forms.Label();
            this.cuttingEdgeNoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startOsu
            // 
            this.startOsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.startOsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startOsu.FlatAppearance.BorderSize = 0;
            this.startOsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startOsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOsu.ForeColor = System.Drawing.Color.Transparent;
            this.startOsu.Location = new System.Drawing.Point(305, 148);
            this.startOsu.Margin = new System.Windows.Forms.Padding(2);
            this.startOsu.Name = "startOsu";
            this.startOsu.Size = new System.Drawing.Size(130, 70);
            this.startOsu.TabIndex = 0;
            this.startOsu.TabStop = false;
            this.startOsu.Text = "Start osu!";
            this.startOsu.UseVisualStyleBackColor = false;
            this.startOsu.Click += new System.EventHandler(this.startOsuClick);
            // 
            // selectOsu
            // 
            this.selectOsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.selectOsu.FlatAppearance.BorderSize = 0;
            this.selectOsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOsu.ForeColor = System.Drawing.Color.Transparent;
            this.selectOsu.Location = new System.Drawing.Point(155, 148);
            this.selectOsu.Margin = new System.Windows.Forms.Padding(2);
            this.selectOsu.Name = "selectOsu";
            this.selectOsu.Size = new System.Drawing.Size(130, 70);
            this.selectOsu.TabIndex = 1;
            this.selectOsu.Text = "Select osu!.exe";
            this.selectOsu.UseVisualStyleBackColor = false;
            this.selectOsu.Click += new System.EventHandler(this.selectOsuClick);
            // 
            // exitApp
            // 
            this.exitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.exitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitApp.FlatAppearance.BorderSize = 0;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApp.ForeColor = System.Drawing.Color.White;
            this.exitApp.Location = new System.Drawing.Point(564, 0);
            this.exitApp.Margin = new System.Windows.Forms.Padding(2);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(37, 32);
            this.exitApp.TabIndex = 4;
            this.exitApp.TabStop = false;
            this.exitApp.Text = "X";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitAppClick);
            // 
            // switchlessLabel
            // 
            this.switchlessLabel.AutoSize = true;
            this.switchlessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchlessLabel.ForeColor = System.Drawing.Color.White;
            this.switchlessLabel.Location = new System.Drawing.Point(206, 88);
            this.switchlessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.switchlessLabel.Name = "switchlessLabel";
            this.switchlessLabel.Size = new System.Drawing.Size(189, 39);
            this.switchlessLabel.TabIndex = 5;
            this.switchlessLabel.Text = "Switchless";
            this.switchlessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchlessLabel.Click += new System.EventHandler(this.switchlessLabel_Click);
            // 
            // cuttingEdgeNoteLabel
            // 
            this.cuttingEdgeNoteLabel.AutoSize = true;
            this.cuttingEdgeNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuttingEdgeNoteLabel.ForeColor = System.Drawing.Color.White;
            this.cuttingEdgeNoteLabel.Location = new System.Drawing.Point(10, 345);
            this.cuttingEdgeNoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cuttingEdgeNoteLabel.Name = "cuttingEdgeNoteLabel";
            this.cuttingEdgeNoteLabel.Size = new System.Drawing.Size(269, 13);
            this.cuttingEdgeNoteLabel.TabIndex = 7;
            this.cuttingEdgeNoteLabel.Text = "CREDIT: We\'re using Switchless v0.3.0 made by Yo-ru.";
            this.cuttingEdgeNoteLabel.Click += new System.EventHandler(this.creditLabel);
            // 
            // Switchless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cuttingEdgeNoteLabel);
            this.Controls.Add(this.switchlessLabel);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.selectOsu);
            this.Controls.Add(this.startOsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Switchless";
            this.Text = "Switchless";
            this.Load += new System.EventHandler(this.Switchless_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.switchlessMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOsu;
        private System.Windows.Forms.Button selectOsu;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label switchlessLabel;
        private System.Windows.Forms.Label cuttingEdgeNoteLabel;
    }
}

