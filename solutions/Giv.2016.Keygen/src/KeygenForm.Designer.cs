namespace Giv.Keygen
{
	partial class KeygenForm
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
			this.TopPanel = new System.Windows.Forms.Panel();
			this.NamePanel = new System.Windows.Forms.Panel();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.KeygenButton = new System.Windows.Forms.Button();
			this.SecretPanel = new System.Windows.Forms.Panel();
			this.SecretTextBox = new System.Windows.Forms.TextBox();
			this.TopPanel.SuspendLayout();
			this.NamePanel.SuspendLayout();
			this.SecretPanel.SuspendLayout();
			this.SuspendLayout();
			//
			// TopPanel
			//
			this.TopPanel.Controls.Add(this.NamePanel);
			this.TopPanel.Controls.Add(this.KeygenButton);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(5, 5);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Padding = new System.Windows.Forms.Padding(7);
			this.TopPanel.Size = new System.Drawing.Size(346, 35);
			this.TopPanel.TabIndex = 0;
			//
			// NamePanel
			//
			this.NamePanel.Controls.Add(this.NameTextBox);
			this.NamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NamePanel.Location = new System.Drawing.Point(7, 7);
			this.NamePanel.Name = "NamePanel";
			this.NamePanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this.NamePanel.Size = new System.Drawing.Size(257, 21);
			this.NamePanel.TabIndex = 1;
			//
			// NameTextBox
			//
			this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NameTextBox.Location = new System.Drawing.Point(0, 0);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(249, 20);
			this.NameTextBox.TabIndex = 1;
			//
			// KeygenButton
			//
			this.KeygenButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.KeygenButton.Location = new System.Drawing.Point(264, 7);
			this.KeygenButton.Name = "KeygenButton";
			this.KeygenButton.Size = new System.Drawing.Size(75, 21);
			this.KeygenButton.TabIndex = 0;
			this.KeygenButton.Text = "Generate";
			this.KeygenButton.UseVisualStyleBackColor = true;
			this.KeygenButton.Click += new System.EventHandler(this.KeygenButton_Click);
			//
			// SecretPanel
			//
			this.SecretPanel.Controls.Add(this.SecretTextBox);
			this.SecretPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.SecretPanel.Location = new System.Drawing.Point(5, 40);
			this.SecretPanel.Name = "SecretPanel";
			this.SecretPanel.Padding = new System.Windows.Forms.Padding(7);
			this.SecretPanel.Size = new System.Drawing.Size(346, 29);
			this.SecretPanel.TabIndex = 1;
			//
			// SecretTextBox
			//
			this.SecretTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SecretTextBox.Location = new System.Drawing.Point(7, 7);
			this.SecretTextBox.Name = "SecretTextBox";
			this.SecretTextBox.Size = new System.Drawing.Size(332, 20);
			this.SecretTextBox.TabIndex = 0;
			//
			// KeygenForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 77);
			this.Controls.Add(this.SecretPanel);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "KeygenForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "Giv 2016 Keygen by saneki";
			this.TopPanel.ResumeLayout(false);
			this.NamePanel.ResumeLayout(false);
			this.NamePanel.PerformLayout();
			this.SecretPanel.ResumeLayout(false);
			this.SecretPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Panel NamePanel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Button KeygenButton;
		private System.Windows.Forms.Panel SecretPanel;
		private System.Windows.Forms.TextBox SecretTextBox;
	}
}

