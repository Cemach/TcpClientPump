
namespace TestFormMVC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTemp01 = new System.Windows.Forms.Label();
            this.lblTemp02 = new System.Windows.Forms.Label();
            this.lblTemp03 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRPM = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemp01
            // 
            this.lblTemp01.AutoSize = true;
            this.lblTemp01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemp01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp01.Location = new System.Drawing.Point(45, 251);
            this.lblTemp01.Name = "lblTemp01";
            this.lblTemp01.Size = new System.Drawing.Size(40, 19);
            this.lblTemp01.TabIndex = 0;
            this.lblTemp01.Text = "Intlet";
            this.lblTemp01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemp01.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTemp02
            // 
            this.lblTemp02.AutoSize = true;
            this.lblTemp02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemp02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp02.Location = new System.Drawing.Point(105, 130);
            this.lblTemp02.Name = "lblTemp02";
            this.lblTemp02.Size = new System.Drawing.Size(48, 19);
            this.lblTemp02.TabIndex = 1;
            this.lblTemp02.Text = "Outlet";
            this.lblTemp02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemp02.Click += new System.EventHandler(this.lblTemp02_Click);
            // 
            // lblTemp03
            // 
            this.lblTemp03.AutoSize = true;
            this.lblTemp03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemp03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp03.Location = new System.Drawing.Point(294, 230);
            this.lblTemp03.Name = "lblTemp03";
            this.lblTemp03.Size = new System.Drawing.Size(92, 19);
            this.lblTemp03.TabIndex = 2;
            this.lblTemp03.Text = "Temperature";
            this.lblTemp03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(428, 178);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(40, 19);
            this.lblRPM.TabIndex = 4;
            this.lblRPM.Text = "RPM";
            this.lblRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(330, 72);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 71);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestFormMVC.Properties.Resources.logoTechnipFmc;
            this.pictureBox2.Location = new System.Drawing.Point(45, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 57);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestFormMVC.Properties.Resources.pump01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 441);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 469);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblRPM);
            this.Controls.Add(this.lblTemp03);
            this.Controls.Add(this.lblTemp02);
            this.Controls.Add(this.lblTemp01);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp01;
        private System.Windows.Forms.Label lblTemp02;
        private System.Windows.Forms.Label lblTemp03;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

