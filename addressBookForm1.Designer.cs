namespace AddressBook
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
 /// <param name="disposing">true if managed resources should be disposed; otherwise, 
false.</param>
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
 this.label2 = new System.Windows.Forms.Label();
 this.label3 = new System.Windows.Forms.Label();
 this.txtName = new System.Windows.Forms.TextBox();
 this.txtEmail = new System.Windows.Forms.TextBox();
 this.txtPhone = new System.Windows.Forms.TextBox();
 this.btnSave = new System.Windows.Forms.Button();
 this.SuspendLayout();
 // 
 // label1
 // 
 this.label1.AutoSize = true;
 this.label1.Location = new System.Drawing.Point(12, 15);
 this.label1.Name = "label1";
 this.label1.Size = new System.Drawing.Size(38, 13);
 this.label1.TabIndex = 0;
 this.label1.Text = "Name:";
 // 
 // label2
 // 
 this.label2.AutoSize = true;
 this.label2.Location = new System.Drawing.Point(12, 41);
 this.label2.Name = "label2";
 this.label2.Size = new System.Drawing.Size(35, 13);
 this.label2.TabIndex = 1;
 this.label2.Text = "Email:";
 // 
 // label3
 // 
 this.label3.AutoSize = true;
 this.label3.Location = new System.Drawing.Point(12, 67);
 this.label3.Name = "label3";
 this.label3.Size = new System.Drawing.Size(41, 13);
 this.label3.TabIndex = 2;
 this.label3.Text = "Phone:";
 // 
 // txtName
 // 
 this.txtName.Location = new System.Drawing.Point(73, 12);
 this.txtName.Name = "txtName";
 this.txtName.Size = new System.Drawing.Size(215, 20);
 this.txtName.TabIndex = 3;
 // 
 // txtEmail
 // 
 this.txtEmail.Location = new System.Drawing.Point(73, 38);
 this.txtEmail.Name = "txtEmail";
 this.txtEmail.Size = new System.Drawing.Size(215, 20);
 this.txtEmail.TabIndex = 4;
 // 
 // txtPhone
 // 
 this.txtPhone.Location = new System.Drawing.Point(73, 64);
 this.txtPhone.Name = "txtPhone";
 this.txtPhone.Size = new System.Drawing.Size(215, 20);
 this.txtPhone.TabIndex = 5;
 // 
 // btnSave
 // 
 this.btnSave.Location = new System.Drawing.Point(213, 90);
 this.btnSave.Name = "btnSave";
 this.btnSave.Size = new System.Drawing.Size(75, 23);
 this.btnSave.TabIndex = 6;
 this.btnSave.Text = "Save";
 this.btnSave.UseVisualStyleBackColor = true;
 this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
 // 
 // Form1
 // 
 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize = new System.Drawing.Size(300, 125);
 this.Controls.Add(this.btnSave);
 this.Controls.Add(this.txtPhone);
 this.Controls.Add(this.txtEmail);
 this.Controls.Add(this.txtName);
 this.Controls.Add(this.label3);
 this.Controls.Add(this.label2);
 this.Controls.Add(this.label1);
 this.Name = "Form1";
 this.Text = "Address Book";
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 #endregion
 private System.Windows.Forms.Label label1;
 private System.Windows.Forms.Label label2;
 private System.Windows.Forms.Label label3;
 private System.Windows.Forms.TextBox txtName;
 private System.Windows.Forms.TextBox txtEmail;
 private System.Windows.Forms.TextBox txtPhone;
 private System.Windows.Forms.Button btnSave;
 }
}