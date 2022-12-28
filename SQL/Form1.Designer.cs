namespace SQL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rb_Input = new System.Windows.Forms.RichTextBox();
            this.rb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_Input
            // 
            this.rb_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Input.Location = new System.Drawing.Point(12, 12);
            this.rb_Input.Name = "rb_Input";
            this.rb_Input.Size = new System.Drawing.Size(504, 422);
            this.rb_Input.TabIndex = 0;
            this.rb_Input.Text = resources.GetString("rb_Input.Text");
            // 
            // rb_Output
            // 
            this.rb_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Output.Location = new System.Drawing.Point(522, 12);
            this.rb_Output.Name = "rb_Output";
            this.rb_Output.Size = new System.Drawing.Size(504, 422);
            this.rb_Output.TabIndex = 0;
            this.rb_Output.Text = "";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(12, 440);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(94, 41);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "Tạo";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 696);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.rb_Output);
            this.Controls.Add(this.rb_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rb_Input;
        private RichTextBox rb_Output;
        private Button btn_Create;
        private Button button2;
    }
}