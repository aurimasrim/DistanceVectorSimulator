namespace Distance_vector_simulator
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
            this.buttonAddLink = new System.Windows.Forms.Button();
            this.buttonRemoveLink = new System.Windows.Forms.Button();
            this.buttonAddRouter = new System.Windows.Forms.Button();
            this.buttonRemoveRouter = new System.Windows.Forms.Button();
            this.buttonChangeWeight = new System.Windows.Forms.Button();
            this.textBoxRouterId = new System.Windows.Forms.TextBox();
            this.textBoxRouterId1 = new System.Windows.Forms.TextBox();
            this.textBoxRouterId2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIteration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.Location = new System.Drawing.Point(350, 203);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLink.TabIndex = 0;
            this.buttonAddLink.Text = "Add link";
            this.buttonAddLink.UseVisualStyleBackColor = true;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // buttonRemoveLink
            // 
            this.buttonRemoveLink.Location = new System.Drawing.Point(460, 203);
            this.buttonRemoveLink.Name = "buttonRemoveLink";
            this.buttonRemoveLink.Size = new System.Drawing.Size(104, 23);
            this.buttonRemoveLink.TabIndex = 1;
            this.buttonRemoveLink.Text = "Remove link";
            this.buttonRemoveLink.UseVisualStyleBackColor = true;
            this.buttonRemoveLink.Click += new System.EventHandler(this.buttonRemoveLink_Click);
            // 
            // buttonAddRouter
            // 
            this.buttonAddRouter.Location = new System.Drawing.Point(24, 203);
            this.buttonAddRouter.Name = "buttonAddRouter";
            this.buttonAddRouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRouter.TabIndex = 2;
            this.buttonAddRouter.Text = "Add router";
            this.buttonAddRouter.UseVisualStyleBackColor = true;
            this.buttonAddRouter.Click += new System.EventHandler(this.buttonAddRouter_Click);
            // 
            // buttonRemoveRouter
            // 
            this.buttonRemoveRouter.Location = new System.Drawing.Point(117, 203);
            this.buttonRemoveRouter.Name = "buttonRemoveRouter";
            this.buttonRemoveRouter.Size = new System.Drawing.Size(95, 23);
            this.buttonRemoveRouter.TabIndex = 3;
            this.buttonRemoveRouter.Text = "Remove router";
            this.buttonRemoveRouter.UseVisualStyleBackColor = true;
            this.buttonRemoveRouter.Click += new System.EventHandler(this.buttonRemoveRouter_Click);
            // 
            // buttonChangeWeight
            // 
            this.buttonChangeWeight.Location = new System.Drawing.Point(595, 203);
            this.buttonChangeWeight.Name = "buttonChangeWeight";
            this.buttonChangeWeight.Size = new System.Drawing.Size(95, 23);
            this.buttonChangeWeight.TabIndex = 4;
            this.buttonChangeWeight.Text = "Change weight";
            this.buttonChangeWeight.UseVisualStyleBackColor = true;
            this.buttonChangeWeight.Click += new System.EventHandler(this.buttonChangeWeight_Click);
            // 
            // textBoxRouterId
            // 
            this.textBoxRouterId.Location = new System.Drawing.Point(80, 92);
            this.textBoxRouterId.Name = "textBoxRouterId";
            this.textBoxRouterId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRouterId.TabIndex = 5;
            // 
            // textBoxRouterId1
            // 
            this.textBoxRouterId1.Location = new System.Drawing.Point(464, 37);
            this.textBoxRouterId1.Name = "textBoxRouterId1";
            this.textBoxRouterId1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRouterId1.TabIndex = 6;
            // 
            // textBoxRouterId2
            // 
            this.textBoxRouterId2.Location = new System.Drawing.Point(464, 76);
            this.textBoxRouterId2.Name = "textBoxRouterId2";
            this.textBoxRouterId2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRouterId2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Router id:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(464, 120);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Router id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Router id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Weight:";
            // 
            // buttonIteration
            // 
            this.buttonIteration.Location = new System.Drawing.Point(632, 12);
            this.buttonIteration.Name = "buttonIteration";
            this.buttonIteration.Size = new System.Drawing.Size(75, 23);
            this.buttonIteration.TabIndex = 14;
            this.buttonIteration.Text = "Do iteration";
            this.buttonIteration.UseVisualStyleBackColor = true;
            this.buttonIteration.Click += new System.EventHandler(this.buttonIteration_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.buttonIteration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRouterId2);
            this.Controls.Add(this.textBoxRouterId1);
            this.Controls.Add(this.textBoxRouterId);
            this.Controls.Add(this.buttonChangeWeight);
            this.Controls.Add(this.buttonRemoveRouter);
            this.Controls.Add(this.buttonAddRouter);
            this.Controls.Add(this.buttonRemoveLink);
            this.Controls.Add(this.buttonAddLink);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddLink;
        private System.Windows.Forms.Button buttonRemoveLink;
        private System.Windows.Forms.Button buttonAddRouter;
        private System.Windows.Forms.Button buttonRemoveRouter;
        private System.Windows.Forms.Button buttonChangeWeight;
        private System.Windows.Forms.TextBox textBoxRouterId;
        private System.Windows.Forms.TextBox textBoxRouterId1;
        private System.Windows.Forms.TextBox textBoxRouterId2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIteration;
    }
}

