namespace Snake
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Inicar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPoints = new System.Windows.Forms.Label();
            this.titleIniciar = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicar
            // 
            this.Inicar.Location = new System.Drawing.Point(243, 337);
            this.Inicar.Name = "Inicar";
            this.Inicar.Size = new System.Drawing.Size(89, 32);
            this.Inicar.TabIndex = 1;
            this.Inicar.Text = "Iniciar";
            this.Inicar.UseVisualStyleBackColor = true;
            this.Inicar.Click += new System.EventHandler(this.Inicar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(39, 344);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(13, 13);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "0";
            // 
            // titleIniciar
            // 
            this.titleIniciar.AutoSize = true;
            this.titleIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleIniciar.Location = new System.Drawing.Point(397, 77);
            this.titleIniciar.Name = "titleIniciar";
            this.titleIniciar.Size = new System.Drawing.Size(233, 13);
            this.titleIniciar.TabIndex = 3;
            this.titleIniciar.Text = "CLICK EN INICIAR PARA EMPEZAR A JUGAR";
            this.titleIniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(397, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(130, 13);
            this.title.TabIndex = 5;
            this.title.Text = "JUEGO DE LA VIBORITA\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(701, 465);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleIniciar);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.Inicar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Inicar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label titleIniciar;
        private System.Windows.Forms.Label title;
    }
}

