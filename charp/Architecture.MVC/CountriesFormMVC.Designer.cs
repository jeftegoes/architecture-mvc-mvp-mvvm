namespace Architecture.MVC
{
    partial class CountriesFormMVC
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
            getCountriesButton = new Button();
            countriesListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // getCountriesButton
            // 
            getCountriesButton.Location = new Point(95, 337);
            getCountriesButton.Name = "getCountriesButton";
            getCountriesButton.Size = new Size(75, 23);
            getCountriesButton.TabIndex = 0;
            getCountriesButton.Text = "Get Countries";
            getCountriesButton.UseVisualStyleBackColor = true;
            getCountriesButton.Click += getCountriesButton_Click;
            // 
            // countriesListBox
            // 
            countriesListBox.FormattingEnabled = true;
            countriesListBox.ItemHeight = 15;
            countriesListBox.Location = new Point(12, 27);
            countriesListBox.Name = "countriesListBox";
            countriesListBox.Size = new Size(241, 304);
            countriesListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "List of countries";
            // 
            // CountriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 379);
            Controls.Add(label1);
            Controls.Add(countriesListBox);
            Controls.Add(getCountriesButton);
            Name = "CountriesForm";
            Text = "MVC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getCountriesButton;
        private ListBox countriesListBox;
        private Label label1;
    }
}