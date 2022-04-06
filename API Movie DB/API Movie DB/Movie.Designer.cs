
namespace API_Movie_DB
{
    partial class Movie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTextDescription = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNbSeason = new System.Windows.Forms.TextBox();
            this.txtNbEpisode = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.pnlGenre = new System.Windows.Forms.Panel();
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnUS = new System.Windows.Forms.Button();
            this.btnScience = new System.Windows.Forms.Button();
            this.btnThriller = new System.Windows.Forms.Button();
            this.btnChild = new System.Windows.Forms.Button();
            this.btnPoliceOfficer = new System.Windows.Forms.Button();
            this.btnRomance = new System.Windows.Forms.Button();
            this.bntHorror = new System.Windows.Forms.Button();
            this.btnDrama = new System.Windows.Forms.Button();
            this.btnComedy = new System.Windows.Forms.Button();
            this.btnFantastic = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.timerPnlGenre = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnChooseCategorie = new System.Windows.Forms.Button();
            this.pnlCategorie = new System.Windows.Forms.Panel();
            this.btnAnime = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.timerPnlCategorie = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.pnlGenre.SuspendLayout();
            this.pnlCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // pctImage
            // 
            this.pctImage.Image = ((System.Drawing.Image)(resources.GetObject("pctImage.Image")));
            this.pctImage.Location = new System.Drawing.Point(763, 12);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(239, 392);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImage.TabIndex = 7;
            this.pctImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(763, 421);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(239, 57);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Choose Image Movie";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 587);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(235, 40);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(359, 22);
            this.txtID.TabIndex = 11;
            // 
            // txtTextDescription
            // 
            this.txtTextDescription.Location = new System.Drawing.Point(206, 113);
            this.txtTextDescription.Name = "txtTextDescription";
            this.txtTextDescription.Size = new System.Drawing.Size(359, 22);
            this.txtTextDescription.TabIndex = 12;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(120, 81);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(359, 22);
            this.txtAverage.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(73, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(359, 22);
            this.txtTitle.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number  of seasons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of episodes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Link";
            // 
            // txtNbSeason
            // 
            this.txtNbSeason.Location = new System.Drawing.Point(258, 194);
            this.txtNbSeason.Name = "txtNbSeason";
            this.txtNbSeason.Size = new System.Drawing.Size(359, 22);
            this.txtNbSeason.TabIndex = 19;
            // 
            // txtNbEpisode
            // 
            this.txtNbEpisode.Location = new System.Drawing.Point(258, 235);
            this.txtNbEpisode.Name = "txtNbEpisode";
            this.txtNbEpisode.Size = new System.Drawing.Size(359, 22);
            this.txtNbEpisode.TabIndex = 20;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(80, 304);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(359, 22);
            this.txtLink.TabIndex = 22;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(102, 272);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(359, 22);
            this.txtGenre.TabIndex = 23;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // pnlGenre
            // 
            this.pnlGenre.Controls.Add(this.btnEurope);
            this.pnlGenre.Controls.Add(this.btnUS);
            this.pnlGenre.Controls.Add(this.btnScience);
            this.pnlGenre.Controls.Add(this.btnThriller);
            this.pnlGenre.Controls.Add(this.btnChild);
            this.pnlGenre.Controls.Add(this.btnPoliceOfficer);
            this.pnlGenre.Controls.Add(this.btnRomance);
            this.pnlGenre.Controls.Add(this.bntHorror);
            this.pnlGenre.Controls.Add(this.btnDrama);
            this.pnlGenre.Controls.Add(this.btnComedy);
            this.pnlGenre.Controls.Add(this.btnFantastic);
            this.pnlGenre.Controls.Add(this.btnAction);
            this.pnlGenre.Controls.Add(this.btnGenre);
            this.pnlGenre.Location = new System.Drawing.Point(467, 272);
            this.pnlGenre.MaximumSize = new System.Drawing.Size(200, 390);
            this.pnlGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.pnlGenre.Name = "pnlGenre";
            this.pnlGenre.Size = new System.Drawing.Size(200, 30);
            this.pnlGenre.TabIndex = 24;
            // 
            // btnEurope
            // 
            this.btnEurope.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEurope.Location = new System.Drawing.Point(0, 360);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(200, 30);
            this.btnEurope.TabIndex = 40;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // btnUS
            // 
            this.btnUS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUS.Location = new System.Drawing.Point(0, 330);
            this.btnUS.Name = "btnUS";
            this.btnUS.Size = new System.Drawing.Size(200, 30);
            this.btnUS.TabIndex = 39;
            this.btnUS.Text = "US";
            this.btnUS.UseVisualStyleBackColor = true;
            this.btnUS.Click += new System.EventHandler(this.btnUS_Click);
            // 
            // btnScience
            // 
            this.btnScience.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScience.Location = new System.Drawing.Point(0, 300);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(200, 30);
            this.btnScience.TabIndex = 38;
            this.btnScience.Text = "Science";
            this.btnScience.UseVisualStyleBackColor = true;
            this.btnScience.Click += new System.EventHandler(this.btnScience_Click);
            // 
            // btnThriller
            // 
            this.btnThriller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThriller.Location = new System.Drawing.Point(0, 270);
            this.btnThriller.Name = "btnThriller";
            this.btnThriller.Size = new System.Drawing.Size(200, 30);
            this.btnThriller.TabIndex = 37;
            this.btnThriller.Text = "Thriller";
            this.btnThriller.UseVisualStyleBackColor = true;
            this.btnThriller.Click += new System.EventHandler(this.btnThriller_Click);
            // 
            // btnChild
            // 
            this.btnChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChild.Location = new System.Drawing.Point(0, 240);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(200, 30);
            this.btnChild.TabIndex = 36;
            this.btnChild.Text = "Child";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // btnPoliceOfficer
            // 
            this.btnPoliceOfficer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoliceOfficer.Location = new System.Drawing.Point(0, 210);
            this.btnPoliceOfficer.Name = "btnPoliceOfficer";
            this.btnPoliceOfficer.Size = new System.Drawing.Size(200, 30);
            this.btnPoliceOfficer.TabIndex = 35;
            this.btnPoliceOfficer.Text = "Police Officer";
            this.btnPoliceOfficer.UseVisualStyleBackColor = true;
            this.btnPoliceOfficer.Click += new System.EventHandler(this.btnPoliceOfficer_Click);
            // 
            // btnRomance
            // 
            this.btnRomance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRomance.Location = new System.Drawing.Point(0, 180);
            this.btnRomance.Name = "btnRomance";
            this.btnRomance.Size = new System.Drawing.Size(200, 30);
            this.btnRomance.TabIndex = 34;
            this.btnRomance.Text = "Romance";
            this.btnRomance.UseVisualStyleBackColor = true;
            this.btnRomance.Click += new System.EventHandler(this.btnRomance_Click);
            // 
            // bntHorror
            // 
            this.bntHorror.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntHorror.Location = new System.Drawing.Point(0, 150);
            this.bntHorror.Name = "bntHorror";
            this.bntHorror.Size = new System.Drawing.Size(200, 30);
            this.bntHorror.TabIndex = 30;
            this.bntHorror.Text = "Horror";
            this.bntHorror.UseVisualStyleBackColor = true;
            this.bntHorror.Click += new System.EventHandler(this.bntHorror_Click);
            // 
            // btnDrama
            // 
            this.btnDrama.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrama.Location = new System.Drawing.Point(0, 120);
            this.btnDrama.Name = "btnDrama";
            this.btnDrama.Size = new System.Drawing.Size(200, 30);
            this.btnDrama.TabIndex = 29;
            this.btnDrama.Text = "Drama";
            this.btnDrama.UseVisualStyleBackColor = true;
            this.btnDrama.Click += new System.EventHandler(this.btnDrama_Click);
            // 
            // btnComedy
            // 
            this.btnComedy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComedy.Location = new System.Drawing.Point(0, 90);
            this.btnComedy.Name = "btnComedy";
            this.btnComedy.Size = new System.Drawing.Size(200, 30);
            this.btnComedy.TabIndex = 28;
            this.btnComedy.Text = "Comedy";
            this.btnComedy.UseVisualStyleBackColor = true;
            this.btnComedy.Click += new System.EventHandler(this.btnComedy_Click);
            // 
            // btnFantastic
            // 
            this.btnFantastic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFantastic.Location = new System.Drawing.Point(0, 60);
            this.btnFantastic.Name = "btnFantastic";
            this.btnFantastic.Size = new System.Drawing.Size(200, 30);
            this.btnFantastic.TabIndex = 27;
            this.btnFantastic.Text = "Fantastic";
            this.btnFantastic.UseVisualStyleBackColor = true;
            this.btnFantastic.Click += new System.EventHandler(this.btnFantastic_Click);
            // 
            // btnAction
            // 
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAction.Location = new System.Drawing.Point(0, 30);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(200, 30);
            this.btnAction.TabIndex = 26;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.Location = new System.Drawing.Point(0, 0);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(200, 30);
            this.btnGenre.TabIndex = 25;
            this.btnGenre.Text = "Choose  Genre Of Movie";
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // timerPnlGenre
            // 
            this.timerPnlGenre.Interval = 15;
            this.timerPnlGenre.Tick += new System.EventHandler(this.timerPnlGenre_Tick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 517);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(235, 40);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Violet;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(14, 459);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(235, 40);
            this.btnView.TabIndex = 26;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(411, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(571, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(485, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(433, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(714, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1008, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(813, 506);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(834, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Obligation to fulfill";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 633);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(386, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "Just enter ID in the textBox Id you want to delete !!";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 560);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(365, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "View with the View button and change your data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 494);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(378, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Just enter id in the textBox ID you want to display";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 436);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(273, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Save the form data in the Database";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(133, 153);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(359, 22);
            this.txtCategorie.TabIndex = 40;
            this.txtCategorie.TextChanged += new System.EventHandler(this.txtCategorie_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 29);
            this.label21.TabIndex = 39;
            this.label21.Text = "Categorie";
            // 
            // btnChooseCategorie
            // 
            this.btnChooseCategorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseCategorie.Location = new System.Drawing.Point(0, 0);
            this.btnChooseCategorie.MinimumSize = new System.Drawing.Size(159, 32);
            this.btnChooseCategorie.Name = "btnChooseCategorie";
            this.btnChooseCategorie.Size = new System.Drawing.Size(199, 32);
            this.btnChooseCategorie.TabIndex = 41;
            this.btnChooseCategorie.Text = "Choose Categorie";
            this.btnChooseCategorie.UseVisualStyleBackColor = true;
            this.btnChooseCategorie.Click += new System.EventHandler(this.btnChooseCategorie_Click);
            // 
            // pnlCategorie
            // 
            this.pnlCategorie.Controls.Add(this.btnAnime);
            this.pnlCategorie.Controls.Add(this.btnSerie);
            this.pnlCategorie.Controls.Add(this.btnChooseCategorie);
            this.pnlCategorie.Controls.Add(this.btnMovie);
            this.pnlCategorie.Location = new System.Drawing.Point(498, 155);
            this.pnlCategorie.MaximumSize = new System.Drawing.Size(199, 122);
            this.pnlCategorie.MinimumSize = new System.Drawing.Size(199, 33);
            this.pnlCategorie.Name = "pnlCategorie";
            this.pnlCategorie.Size = new System.Drawing.Size(199, 33);
            this.pnlCategorie.TabIndex = 42;
            // 
            // btnAnime
            // 
            this.btnAnime.Location = new System.Drawing.Point(0, 87);
            this.btnAnime.Name = "btnAnime";
            this.btnAnime.Size = new System.Drawing.Size(199, 32);
            this.btnAnime.TabIndex = 44;
            this.btnAnime.Text = "Anime";
            this.btnAnime.UseVisualStyleBackColor = true;
            this.btnAnime.Click += new System.EventHandler(this.btnAnime_Click);
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(0, 56);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(199, 32);
            this.btnSerie.TabIndex = 43;
            this.btnSerie.Text = "Serie";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.Location = new System.Drawing.Point(0, 29);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(199, 32);
            this.btnMovie.TabIndex = 42;
            this.btnMovie.Text = "Movie";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // timerPnlCategorie
            // 
            this.timerPnlCategorie.Interval = 15;
            this.timerPnlCategorie.Tick += new System.EventHandler(this.timerPnlCategorie_Tick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(676, 264);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 25);
            this.label22.TabIndex = 43;
            this.label22.Text = "*";
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1107, 723);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pnlCategorie);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnlGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtNbEpisode);
            this.Controls.Add(this.txtNbSeason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTextDescription);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "Movie";
            this.Text = "6";
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.pnlGenre.ResumeLayout(false);
            this.pnlCategorie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTextDescription;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNbSeason;
        private System.Windows.Forms.TextBox txtNbEpisode;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Panel pnlGenre;
        private System.Windows.Forms.Button btnRomance;
        private System.Windows.Forms.Button bntHorror;
        private System.Windows.Forms.Button btnDrama;
        private System.Windows.Forms.Button btnComedy;
        private System.Windows.Forms.Button btnFantastic;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnUS;
        private System.Windows.Forms.Button btnScience;
        private System.Windows.Forms.Button btnThriller;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Button btnPoliceOfficer;
        private System.Windows.Forms.Timer timerPnlGenre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnChooseCategorie;
        private System.Windows.Forms.Panel pnlCategorie;
        private System.Windows.Forms.Button btnAnime;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Timer timerPnlCategorie;
        private System.Windows.Forms.Label label22;
    }
}

