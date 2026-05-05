namespace SISTEMA_DE_VOTACIONES
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label2 = new Label();
            btnRegistro = new Button();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(47, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 211);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Menu;
            txtUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(47, 233);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(273, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Matricula";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.Menu;
            txtClave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtClave.ForeColor = Color.Black;
            txtClave.Location = new Point(47, 295);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(273, 25);
            txtClave.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 271);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.DarkBlue;
            btnRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegistro.ForeColor = SystemColors.ButtonFace;
            btnRegistro.Location = new Point(68, 354);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(96, 37);
            btnRegistro.TabIndex = 5;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkBlue;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnIngresar.ForeColor = SystemColors.ButtonFace;
            btnIngresar.Location = new Point(195, 354);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 37);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(377, 432);
            Controls.Add(btnIngresar);
            Controls.Add(btnRegistro);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginFrm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label2;
        private Button btnRegistro;
        private Button btnIngresar;
    }
}
