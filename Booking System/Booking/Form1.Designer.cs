namespace Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ticketComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfPeopleLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "票款";
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infoRichTextBox.Location = new System.Drawing.Point(13, 123);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(532, 176);
            this.infoRichTextBox.TabIndex = 1;
            this.infoRichTextBox.Text = "";
            // 
            // ticketComboBox
            // 
            this.ticketComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketComboBox.FormattingEnabled = true;
            this.ticketComboBox.Items.AddRange(new object[] {
            "全票",
            "學生票(需憑學生證8折優惠)",
            "兒童票(11~12歲7折優惠)",
            "兒童票(4~10歲3折優惠)",
            "持花旗卡購票(5折優惠)"});
            this.ticketComboBox.Location = new System.Drawing.Point(77, 15);
            this.ticketComboBox.Name = "ticketComboBox";
            this.ticketComboBox.Size = new System.Drawing.Size(328, 35);
            this.ticketComboBox.TabIndex = 2;
            this.ticketComboBox.SelectedIndexChanged += new System.EventHandler(this.ticketComboBox_SelectedIndexChanged);
            // 
            // numberOfPeopleLabel
            // 
            this.numberOfPeopleLabel.AutoSize = true;
            this.numberOfPeopleLabel.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberOfPeopleLabel.Location = new System.Drawing.Point(17, 70);
            this.numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            this.numberOfPeopleLabel.Size = new System.Drawing.Size(54, 27);
            this.numberOfPeopleLabel.TabIndex = 0;
            this.numberOfPeopleLabel.Text = "張數";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.qtyTextBox.Location = new System.Drawing.Point(77, 62);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 35);
            this.qtyTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(425, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "加入清單";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(305, 62);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 35);
            this.priceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(245, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "單價";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalButton.Location = new System.Drawing.Point(425, 62);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(111, 35);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "結帳";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 318);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.ticketComboBox);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.numberOfPeopleLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.ComboBox ticketComboBox;
        private System.Windows.Forms.Label numberOfPeopleLabel;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button totalButton;
    }
}