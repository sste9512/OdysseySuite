using System.ComponentModel;

namespace Kotortool_Legacy.Infrastructure.View.ProjectSelection;

partial class ProjectSelectionScreen
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.projectListingBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameFilePathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectListingBox
            // 
            this.projectListingBox.FormattingEnabled = true;
            this.projectListingBox.ItemHeight = 16;
            this.projectListingBox.Location = new System.Drawing.Point(12, 47);
            this.projectListingBox.Name = "projectListingBox";
            this.projectListingBox.Size = new System.Drawing.Size(246, 372);
            this.projectListingBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Project";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(282, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Name";
            // 
            // gameFilePathTextBox
            // 
            this.gameFilePathTextBox.Location = new System.Drawing.Point(282, 247);
            this.gameFilePathTextBox.Name = "gameFilePathTextBox";
            this.gameFilePathTextBox.Size = new System.Drawing.Size(434, 22);
            this.gameFilePathTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(282, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Game File Path";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(434, 22);
            this.textBox2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(297, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(469, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProjectSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameFilePathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectListingBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ProjectSelectionScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox gameFilePathTextBox;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ListBox projectListingBox;
    private System.Windows.Forms.Label label1;

    #endregion

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
}