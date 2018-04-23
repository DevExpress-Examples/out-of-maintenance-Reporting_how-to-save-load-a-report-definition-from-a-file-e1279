namespace SaveLoadDefinition {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SaveRepx = new System.Windows.Forms.Button();
            this.LoadRepx = new System.Windows.Forms.Button();
            this.SaveXml = new System.Windows.Forms.Button();
            this.LoadXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveRepx
            // 
            this.SaveRepx.Location = new System.Drawing.Point(12, 12);
            this.SaveRepx.Name = "SaveRepx";
            this.SaveRepx.Size = new System.Drawing.Size(135, 53);
            this.SaveRepx.TabIndex = 0;
            this.SaveRepx.Text = "Save Report to REPX";
            this.SaveRepx.UseVisualStyleBackColor = true;
            this.SaveRepx.Click += new System.EventHandler(this.SaveRepx_Click);
            // 
            // LoadRepx
            // 
            this.LoadRepx.Location = new System.Drawing.Point(12, 86);
            this.LoadRepx.Name = "LoadRepx";
            this.LoadRepx.Size = new System.Drawing.Size(135, 53);
            this.LoadRepx.TabIndex = 1;
            this.LoadRepx.Text = "Load Report from REPX";
            this.LoadRepx.UseVisualStyleBackColor = true;
            this.LoadRepx.Click += new System.EventHandler(this.LoadRepx_Click);
            // 
            // SaveXml
            // 
            this.SaveXml.Location = new System.Drawing.Point(250, 13);
            this.SaveXml.Name = "SaveXml";
            this.SaveXml.Size = new System.Drawing.Size(135, 52);
            this.SaveXml.TabIndex = 2;
            this.SaveXml.Text = "Save Report to XML";
            this.SaveXml.UseVisualStyleBackColor = true;
            this.SaveXml.Click += new System.EventHandler(this.SaveXml_Click);
            // 
            // LoadXml
            // 
            this.LoadXml.Location = new System.Drawing.Point(250, 86);
            this.LoadXml.Name = "LoadXml";
            this.LoadXml.Size = new System.Drawing.Size(135, 53);
            this.LoadXml.TabIndex = 3;
            this.LoadXml.Text = "Load Report from XML";
            this.LoadXml.UseVisualStyleBackColor = true;
            this.LoadXml.Click += new System.EventHandler(this.LoadXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 348);
            this.Controls.Add(this.LoadXml);
            this.Controls.Add(this.SaveXml);
            this.Controls.Add(this.LoadRepx);
            this.Controls.Add(this.SaveRepx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveRepx;
        private System.Windows.Forms.Button LoadRepx;
        private System.Windows.Forms.Button SaveXml;
        private System.Windows.Forms.Button LoadXml;
    }
}

