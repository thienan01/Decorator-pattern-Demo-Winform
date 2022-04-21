
namespace Decorator_pattern_Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbBubble = new System.Windows.Forms.CheckBox();
            this.cbBlackSugar = new System.Windows.Forms.CheckBox();
            this.cbJelly = new System.Windows.Forms.CheckBox();
            this.cbFruitPudding = new System.Windows.Forms.CheckBox();
            this.cbFlanCake = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buffet milk tea";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbBubble
            // 
            this.cbBubble.AutoSize = true;
            this.cbBubble.Location = new System.Drawing.Point(123, 56);
            this.cbBubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBubble.Name = "cbBubble";
            this.cbBubble.Size = new System.Drawing.Size(74, 21);
            this.cbBubble.TabIndex = 2;
            this.cbBubble.Text = "Bubble";
            this.cbBubble.UseVisualStyleBackColor = true;
            // 
            // cbBlackSugar
            // 
            this.cbBlackSugar.AutoSize = true;
            this.cbBlackSugar.Location = new System.Drawing.Point(93, 200);
            this.cbBlackSugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBlackSugar.Name = "cbBlackSugar";
            this.cbBlackSugar.Size = new System.Drawing.Size(104, 21);
            this.cbBlackSugar.TabIndex = 3;
            this.cbBlackSugar.Text = "Black sugar";
            this.cbBlackSugar.UseVisualStyleBackColor = true;
            // 
            // cbJelly
            // 
            this.cbJelly.AutoSize = true;
            this.cbJelly.Location = new System.Drawing.Point(357, 280);
            this.cbJelly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbJelly.Name = "cbJelly";
            this.cbJelly.Size = new System.Drawing.Size(58, 21);
            this.cbJelly.TabIndex = 4;
            this.cbJelly.Text = "Jelly";
            this.cbJelly.UseVisualStyleBackColor = true;
            // 
            // cbFruitPudding
            // 
            this.cbFruitPudding.AutoSize = true;
            this.cbFruitPudding.Location = new System.Drawing.Point(558, 200);
            this.cbFruitPudding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFruitPudding.Name = "cbFruitPudding";
            this.cbFruitPudding.Size = new System.Drawing.Size(114, 21);
            this.cbFruitPudding.TabIndex = 5;
            this.cbFruitPudding.Text = "Fruit Pudding";
            this.cbFruitPudding.UseVisualStyleBackColor = true;
            // 
            // cbFlanCake
            // 
            this.cbFlanCake.AutoSize = true;
            this.cbFlanCake.Location = new System.Drawing.Point(558, 56);
            this.cbFlanCake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFlanCake.Name = "cbFlanCake";
            this.cbFlanCake.Size = new System.Drawing.Size(91, 21);
            this.cbFlanCake.TabIndex = 6;
            this.cbFlanCake.Text = "Flan cake";
            this.cbFlanCake.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cost:";
            // 
            // lbtotalCost
            // 
            this.lbtotalCost.AutoSize = true;
            this.lbtotalCost.Location = new System.Drawing.Point(387, 382);
            this.lbtotalCost.Name = "lbtotalCost";
            this.lbtotalCost.Size = new System.Drawing.Size(49, 17);
            this.lbtotalCost.TabIndex = 9;
            this.lbtotalCost.Text = "0 VND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 422);
            this.Controls.Add(this.lbtotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFlanCake);
            this.Controls.Add(this.cbFruitPudding);
            this.Controls.Add(this.cbJelly);
            this.Controls.Add(this.cbBlackSugar);
            this.Controls.Add(this.cbBubble);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milk Tea";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbBubble;
        private System.Windows.Forms.CheckBox cbBlackSugar;
        private System.Windows.Forms.CheckBox cbJelly;
        private System.Windows.Forms.CheckBox cbFruitPudding;
        private System.Windows.Forms.CheckBox cbFlanCake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtotalCost;
    }
}

