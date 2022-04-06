using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;





namespace API_Movie_DB
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        static string StrCon = ConfigurationManager.ConnectionStrings["LIVEDNSfromLocal"].ConnectionString;

        SqlConnection connection = new SqlConnection(StrCon);
        string imgLocation = "";
        SqlCommand command;
        DataSet ds = new DataSet();
        SqlDataReader reader = null;
        private bool isCollapsed;
        private bool isCollapsed2;
        MemoryStream mstream = null;
       

        private void btnImage_Click(object sender, EventArgs e)
        {
            // insertion Image
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pctImage.ImageLocation = imgLocation;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCategorie.Text == "Movie")
                {
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtCategorie.Text != "")
                    {

                        byte[] images = null;
                        FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);

                        connection.Open();
                        //insertion dans db
                        string sqlQuery = $"Insert into Movie (ID,Title,Picture,Average,TextDescription,Categorie,Genre,Link)" +
                            $"Values('{txtID.Text}','  {txtTitle.Text}', @images ,'{txtAverage.Text}','{txtTextDescription.Text}','{txtCategorie.Text}','{txtGenre.Text}','{txtLink.Text}') ";

                        //Verification si se sont des chiffres
                        int numID, numAverage;
                        bool validID = Int32.TryParse(txtID.Text, out numID);
                        bool validAverage = Int32.TryParse(txtAverage.Text, out numAverage);                     

                        //verification de ID si il exist
                        bool valideVerificationID = true;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Movie where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valideVerificationID = false;
                            connection.Close();
                            MessageBox.Show("ID Existing in Movie!!");
                        }
                        // Verifi si id est correcte et execute la commande
                        if (valideVerificationID)
                        {
                            if (validID && validAverage && Star(txtAverage.Text))
                            {
                                command = new SqlCommand(sqlQuery, connection);
                                command.Parameters.Add(new SqlParameter("@images", images));
                                int n = command.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Data Saved SuccessFully...!");
                                txtID.Clear();
                                txtAverage.Clear();
                                txtTextDescription.Clear();
                                txtCategorie.Clear();
                                txtTitle.Clear();
                                pctImage.Image = null;
                                txtLink.Clear();
                                txtGenre.Clear();

                            }
                            else
                            {
                                connection.Close();
                                if (!Star(txtAverage.Text))
                                {
                                    connection.Close();
                                    MessageBox.Show($"The Average must be between 0 to 10 ");
                                }
                                else
                                {
                                    connection.Close();
                                    MessageBox.Show("ID is not valide...!");

                                }
                            }
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data not Saved you need complete all form...!");
                    }
                }
                else if (txtCategorie.Text == "Serie")
                {
                    txtNbEpisode.Enabled = true;
                    txtNbSeason.Enabled = true;
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtCategorie.Text != "" && txtNbEpisode.Text !="" && txtNbSeason.Text != "")
                    {

                        byte[] images = null;
                        FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);



                        connection.Open();
                        //insertion dans db
                        string sqlQuery = $"Insert into Serie (ID,Title,Picture,Average,TextDescription, Categorie,Nbseason,NBEpisode,Genre,Link)" +
                            $"Values('{txtID.Text}','  {txtTitle.Text}', @images ,'{txtAverage.Text}','{txtTextDescription.Text}','{txtCategorie.Text}','{txtNbSeason.Text}','{txtNbEpisode.Text}','{txtGenre.Text}','{txtLink.Text}') ";

                        //Verification si se sont des chiffres
                        int numID, numAverage, numNbSeason, numNbEpisode;
                        bool validID = Int32.TryParse(txtID.Text, out numID);
                        bool validAverage = Int32.TryParse(txtAverage.Text, out numAverage);
                        bool validNbSeason = Int32.TryParse(txtNbSeason.Text, out numNbSeason);
                        bool validNbEpisode = Int32.TryParse(txtNbEpisode.Text, out numNbEpisode);

                        //verification de ID si il exist
                        bool valideVerificationID = true;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Serie where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valideVerificationID = false;
                            connection.Close();
                            MessageBox.Show("ID Existing in Serie!!");
                        }
                        // Verifi si id est correcte et execute la commande
                        if (valideVerificationID)
                        {

                            if (validID && validAverage && Star(txtAverage.Text))
                            {
                                //&& SuperiorZero(txtNbSeason.Text) && SuperiorZero(txtNbEpisode.Text)
                                //if(SuperiorZero(txtNbSeason.Text) && SuperiorZero(txtNbEpisode.Text) || txtNbSeason.Text == "" && txtNbEpisode.Text =="")

                                if (txtNbSeason.Text == "" && txtNbEpisode.Text == "")
                                {
                                    command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.Add(new SqlParameter("@images", images));
                                    int n = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Data Saved SuccessFully...!");
                                    txtID.Clear();
                                    txtAverage.Clear();
                                    txtTextDescription.Clear();
                                    txtCategorie.Clear();
                                    txtTitle.Clear();
                                    pctImage.Image = null;
                                    txtNbEpisode.Clear();
                                    txtNbSeason.Clear();
                                    txtLink.Clear();
                                    txtGenre.Clear();
                                }
                                else if (txtNbSeason.Text != "" && txtNbEpisode.Text == "")
                                {
                                    connection.Close();
                                    MessageBox.Show("If the series has episodes then you had to write the number of seasons");
                                }
                                else if (txtNbSeason.Text == "" && txtNbEpisode.Text != "")
                                {
                                    connection.Close();
                                    MessageBox.Show("If the series has seasons then you should write the episode number");
                                }
                                else if (SuperiorZero(txtNbSeason.Text) && SuperiorZero(txtNbEpisode.Text))
                                {
                                    command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.Add(new SqlParameter("@images", images));
                                    int n = command.ExecuteNonQuery();
                                    connection.Close();
                                    _ = MessageBox.Show("Data Saved SuccessFully...!");
                                    txtID.Clear();
                                    txtAverage.Clear();
                                    txtTextDescription.Clear();
                                    txtTitle.Clear();
                                    pctImage.Image = null;
                                    txtNbEpisode.Clear();
                                    txtNbSeason.Clear();
                                    txtLink.Clear();
                                    txtGenre.Clear();
                                }
                                else
                                {
                                    if (!SuperiorZero(txtNbSeason.Text))
                                    {
                                        connection.Close();
                                        MessageBox.Show("The season box must contain only numbers superior 0 ...!");
                                    }
                                    else if (!SuperiorZero(txtNbEpisode.Text))
                                    {
                                        connection.Close();
                                        MessageBox.Show("The episode box must contain only numbers superior 0...!");
                                    }


                                }



                            }
                            else
                            {
                                connection.Close();
                                if (!Star(txtAverage.Text))
                                {
                                    connection.Close();
                                    MessageBox.Show($"The Average must be between 0 to 10 ");
                                }

                                else
                                {
                                    connection.Close();
                                    MessageBox.Show("ID is not valide...!");

                                }

                            }
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data not Saved you need complete all form...!");

                    }
                }
                else if(txtCategorie.Text == "Anime")
                {
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtCategorie.Text != "")
                    {

                        byte[] images = null;
                        FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);



                        connection.Open();
                        //insertion dans db
                        string sqlQuery = $"Insert into Anime (ID,Title,Picture,Average,TextDescription,Categorie,Genre,Link)" +
                            $"Values('{txtID.Text}','  {txtTitle.Text}', @images ,'{txtAverage.Text}','{txtTextDescription.Text}','{txtCategorie.Text}','{txtGenre.Text}','{txtLink.Text}') ";

                        //Verification si se sont des chiffres
                        int numID, numAverage;
                        bool validID = Int32.TryParse(txtID.Text, out numID);
                        bool validAverage = Int32.TryParse(txtAverage.Text, out numAverage);                     

                        //verification de ID si il exist
                        bool valideVerificationID = true;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Anime where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valideVerificationID = false;
                            connection.Close();
                            MessageBox.Show("ID Existing in Movie!!");
                        }
                        // Verifi si id est correcte et execute la commande
                        if (valideVerificationID)
                        {

                            if (validID && validAverage && Star(txtAverage.Text))
                            {
                                
                                    command = new SqlCommand(sqlQuery, connection);
                                    command.Parameters.Add(new SqlParameter("@images", images));
                                    int n = command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Data Saved SuccessFully...!");
                                    txtID.Clear();
                                    txtAverage.Clear();
                                    txtTextDescription.Clear();
                                    txtCategorie.Clear();
                                    txtTitle.Clear();
                                    pctImage.Image = null;
                                    txtNbEpisode.Clear();
                                    txtNbSeason.Clear();
                                    txtLink.Clear();
                                    txtGenre.Clear();                                                              
                            }
                            else
                            {
                                connection.Close();
                                if (!Star(txtAverage.Text))
                                {
                                    connection.Close();
                                    MessageBox.Show($"The Average must be between 0 to 10 ");
                                }

                                else
                                {
                                    connection.Close();
                                    MessageBox.Show("ID is not valide...!");

                                }

                            }
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data not Saved you need complete all form...!");
                    }
                }
                else if(txtCategorie.Text != "Movie" || txtCategorie.Text != "Serie" || txtCategorie.Text != "Anime")
                {
                    MessageBox.Show("Categorie is not valid");
                }
                

            }
            catch (Exception message)
            {
                MessageBox.Show("Error in the program\n" +
                    "Check if your image is valid\n" +
                    "Checks if the season and episode boxes are numbers\n"+
                    "Checks if the Average boxes are numbers\n" + message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            btnSave.Enabled = true;
            btnRemove.Enabled = true;
            pnlCategorie.Enabled = true;


            try
            {
                if (txtCategorie.Text == "Movie")
                {
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtGenre.Text != "" && txtCategorie.Text != "")
                    {
                        connection.Open();

                        string sqlQuery = $" UPDATE Movie" +
                              $" Set Title='{txtTitle.Text}', Average='{txtAverage.Text}',Picture = @img, TextDescription='{txtTextDescription.Text}',Categorie='{txtCategorie.Text}', Genre='{txtGenre.Text}', Link ='{txtLink.Text}'" +
                              $" WHERE ID='{txtID.Text}'";

                        bool valide = false;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Movie where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valide = true;

                        }
                        if (valide)
                        {
                            command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.Add(new SqlParameter("@img", SavePhoto()));
                            int n = command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show($"{txtID.Text} is Update");
                            txtID.Clear();
                            txtAverage.Clear();
                            txtTextDescription.Clear();
                            txtTitle.Clear();
                            pctImage.Image = null;
                            txtLink.Clear();
                            txtGenre.Clear();

                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show($" ID {txtID.Text} not Exist....!!!");
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show($"To change a data you will have to complete all the form for Update!!!");
                    }
                    btnUpdate.Enabled = false;
                }
                else if (txtCategorie.Text == "Serie")
                {
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtGenre.Text != "" && txtCategorie.Text != "")
                    {
                        connection.Open();

                        string sqlQuery = $" UPDATE Serie" +
                              $" Set Title='{txtTitle.Text}', Average='{txtAverage.Text}',Picture = @img, TextDescription='{txtTextDescription.Text}',Categorie='{txtCategorie.Text}',NbSeason = '{txtNbSeason.Text}', NbEpisode = '{txtNbEpisode.Text}', Genre='{txtGenre.Text}', Link ='{txtLink.Text}'" +
                              $" WHERE ID='{txtID.Text}'";

                        
                        bool valide = false;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Serie where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valide = true;

                        }
                        if (valide)
                        {
                            command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.Add(new SqlParameter("@img", SavePhoto()));
                            int n = command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show($"{txtID.Text} is Update");
                            txtID.Clear();
                            txtAverage.Clear();
                            txtTextDescription.Clear();
                            txtTitle.Clear();
                            pctImage.Image = null;
                            txtLink.Clear();
                            txtGenre.Clear();

                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show($" ID {txtID.Text} not Exist....!!!");
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show($"To change a data you will have to complete all the form for Update!!!");
                    }
                    btnUpdate.Enabled = false;
                }
                else if (txtCategorie.Text == "Anime")
                {
                    if (txtID.Text != "" && txtTitle.Text != "" && txtAverage.Text != "" && txtTextDescription.Text != "" && pctImage.Image != null && txtGenre.Text != "" && txtCategorie.Text != "")
                    {
                        connection.Open();

                        string sqlQuery = $" UPDATE Anime" +
                              $" Set Title='{txtTitle.Text}', Average='{txtAverage.Text}',Picture = @img, TextDescription='{txtTextDescription.Text}',Categorie='{txtCategorie.Text}', Genre='{txtGenre.Text}', Link ='{txtLink.Text}'" +
                              $" WHERE ID='{txtID.Text}'";

                        bool valide = false;
                        SqlDataAdapter data = new SqlDataAdapter("Select ID from Anime where ID = '" + txtID.Text + "'", connection);
                        DataTable dt = new DataTable();
                        data.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            valide = true;

                        }
                        if (valide)
                        {
                            command = new SqlCommand(sqlQuery, connection);
                            command.Parameters.Add(new SqlParameter("@img", SavePhoto()));
                            int n = command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show($"{txtID.Text} is Update");
                            txtID.Clear();
                            txtAverage.Clear();
                            txtTextDescription.Clear();
                            txtTitle.Clear();
                            pctImage.Image = null;
                            txtLink.Clear();
                            txtGenre.Clear();

                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show($" ID {txtID.Text} not Exist....!!!");
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show($"To change a data you will have to complete all the form for Update!!!");
                    }
                    btnUpdate.Enabled = false;
                }
            }          
            catch (Exception message)
            {
                connection.Close();
                MessageBox.Show($"Error in program your form has not received valid data \n" + message);
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategorie.Text == "Movie")
                {
                    connection.Open();
                    string sqlQuery = $" DELETE Movie " +
                           $" WHERE ID='{txtID.Text}'";
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Movie where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }

                    if (valide)
                    {
                        command = new SqlCommand(sqlQuery, connection);
                        int n = command.ExecuteNonQuery();
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"The movie is Delete!");
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID  not exist...!!!");
                    }
                }
                else if (txtCategorie.Text == "Serie")
                {
                    connection.Open();
                    string sqlQuery = $" DELETE Serie " +
                           $" WHERE ID='{txtID.Text}'";
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Serie where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }

                    if (valide)
                    {
                        command = new SqlCommand(sqlQuery, connection);
                        int n = command.ExecuteNonQuery();
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"The serie is Delete!");
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID  not exist...!!!");
                    }
                }
                else if (txtCategorie.Text == "Anime")
                {
                    connection.Open();
                    string sqlQuery = $" DELETE Anime " +
                           $" WHERE ID='{txtID.Text}'";
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Anime where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }

                    if (valide)
                    {
                        command = new SqlCommand(sqlQuery, connection);
                        int n = command.ExecuteNonQuery();
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"The anime is Delete!");
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID  not exist...!!!");
                    }
                }
                else if (txtCategorie.Text != "Movie" || txtCategorie.Text != "Serie" || txtCategorie.Text != "Anime" && txtID.Text == "")
                {
                    connection.Close();
                    MessageBox.Show($"ID and Categorie not valid !!!");
                }
                
            }
            catch (Exception message)
            {
                MessageBox.Show($"Error in program your form has not received valid data \n" + message);
            }
            

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                //txtID.Enabled = false;
                txtCategorie.Enabled = false;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
                btnRemove.Enabled = false;
                pnlCategorie.Enabled = false;
                if (txtCategorie.Text == "Movie")
                {
                    connection.Open();
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Movie where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }
                    if (valide)
                    {
                        string output = "";

                        command = new SqlCommand("Select * from Movie where ID = '" + txtID.Text + "'", connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            output += reader["Title"];
                            txtTitle.Text = output;

                            output = "";
                            output += reader["Average"];
                            txtAverage.Text = output;

                            output = "";
                            output += reader["TextDescription"];
                            txtTextDescription.Text = output;

                            output = "";
                            output += reader["Categorie"];
                            txtCategorie.Text = output;

                            output = "";
                            output += reader["Genre"];
                            txtGenre.Text = output;

                            output = "";
                            output += reader["Link"];
                            txtLink.Text = output;

                            byte[] img = (byte[])reader["Picture"];
                            if (img == null)
                                pctImage.Image = null;
                            else
                            {
                                mstream = new MemoryStream(img);
                                pctImage.Image = Image.FromStream(mstream);
                            }
                        }
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID not exist...!!!");
                        txtID.Enabled = true;
                    }


                }
                else if (txtCategorie.Text == "Serie")
                {
                    connection.Open();
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Serie where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }
                    if (valide)
                    {
                        string output = "";

                        command = new SqlCommand("Select * from Serie where ID = '" + txtID.Text + "'", connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            output += reader["Title"];
                            txtTitle.Text = output;

                            output = "";
                            output += reader["Average"];
                            txtAverage.Text = output;

                            output = "";
                            output += reader["TextDescription"];
                            txtTextDescription.Text = output;

                            output = "";
                            output += reader["Categorie"];
                            txtCategorie.Text = output;

                            output = "";
                            output += reader["Nbseason"];
                            txtNbSeason.Text = output;
                            output = "";
                            output += reader["NBEpisode"];
                            txtNbEpisode.Text = output;

                            output = "";
                            output += reader["Genre"];
                            txtGenre.Text = output;

                            output = "";
                            output += reader["Link"];
                            txtLink.Text = output;

                            byte[] img = (byte[])reader["Picture"];
                            if (img == null)
                                pctImage.Image = null;
                            else
                            {
                                mstream = new MemoryStream(img);
                                pctImage.Image = Image.FromStream(mstream);
                            }
                        }
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID not exist...!!!");
                        txtID.Enabled = true;
                    }

                }
                else if (txtCategorie.Text == "Anime")
                {
                    connection.Open();
                    bool valide = false;
                    SqlDataAdapter data = new SqlDataAdapter("Select ID from Anime where ID = '" + txtID.Text + "'", connection);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        valide = true;

                    }
                    if (valide)
                    {
                        string output = "";

                        command = new SqlCommand("Select * from Anime where ID = '" + txtID.Text + "'", connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            output += reader["Title"];
                            txtTitle.Text = output;

                            output = "";
                            output += reader["Average"];
                            txtAverage.Text = output;

                            output = "";
                            output += reader["TextDescription"];
                            txtTextDescription.Text = output;

                            output = "";
                            output += reader["Categorie"];
                            txtCategorie.Text = output;

                            output = "";
                            output += reader["Genre"];
                            txtGenre.Text = output;

                            output = "";
                            output += reader["Link"];
                            txtLink.Text = output;

                            byte[] img = (byte[])reader["Picture"];
                            if (img == null)
                                pctImage.Image = null;
                            else
                            {
                                mstream = new MemoryStream(img);
                                pctImage.Image = Image.FromStream(mstream);
                            }
                        }
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                        txtID.Clear();
                        MessageBox.Show($"Number ID not exist...!!!");
                        txtID.Enabled = true;
                    }
                }
                else if (txtCategorie.Text != "Movie" || txtCategorie.Text != "Serie" || txtCategorie.Text != "Anime" && txtID.Text == "")
                {
                    connection.Close();
                    MessageBox.Show($"ID and Categorie not valid !!!");
                }
            }
            catch(Exception message)
            {
                MessageBox.Show("Error in the program\n" +
                    "Check if your image is valid\n" +
                    "Checks if the season and episode boxes are numbers\n" +
                    "Checks if the Average boxes are numbers\n" + message);
            }
          
        }
        private void Movie_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtNbEpisode.Enabled = false;
            txtNbSeason.Enabled = false;
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pctImage.Image.Save(ms, pctImage.Image.RawFormat);
            return ms.GetBuffer();
        }      
        private bool Star(string txtAverage)
        {
            int numAverage = int.Parse(txtAverage);

            if (numAverage >= 0 && numAverage < 11)
                return true;           
            return false;
        }
        private bool SuperiorZero(string txtNBseasonOrEpisode)
        {

           
            int numNBseasonOrEpisode = int.Parse(txtNBseasonOrEpisode);
            bool validNBseasonOrEpisode = Int32.TryParse(txtNBseasonOrEpisode, out numNBseasonOrEpisode);

            if (numNBseasonOrEpisode >= 0 && validNBseasonOrEpisode)
                return true;
            return false;
        }
        private void txtGenre_TextChanged(object sender, EventArgs e)
        {          
                txtGenre.Enabled = false;                               
        }
        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {
            txtCategorie.Enabled = false;
        }
        private void btnChooseCategorie_Click(object sender, EventArgs e)
        {
            timerPnlCategorie.Start();
        }
        private void btnGenre_Click(object sender, EventArgs e)
        {
            timerPnlGenre.Start();
        }
        private void timerPnlCategorie_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                pnlCategorie.Height += 10;
                if (pnlCategorie.Size == pnlCategorie.MaximumSize)
                {
                    timerPnlCategorie.Stop();
                    isCollapsed2 = false;

                }
            }
            else
            {
                pnlCategorie.Height -= 10;
                if (pnlCategorie.Size == pnlCategorie.MinimumSize)
                {
                    timerPnlCategorie.Stop();
                    isCollapsed2 = true;

                }
            }
        }
        private void timerPnlGenre_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                pnlGenre.Height += 10;
                if(pnlGenre.Size == pnlGenre.MaximumSize)
                {
                    timerPnlGenre.Stop();
                    isCollapsed = false;

                }
            }
            else
            {
                pnlGenre.Height -= 10;
                if (pnlGenre.Size == pnlGenre.MinimumSize)
                {
                    timerPnlGenre.Stop();
                    isCollapsed = true;

                }
            }
        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            string genre = "Action";
            txtGenre.Text = genre; 
        }
        private void btnFantastic_Click(object sender, EventArgs e)
        {
            string genre = "Fantastic";
            txtGenre.Text = genre;
        }
        private void btnComedy_Click(object sender, EventArgs e)
        {
            string genre = "Comedy";
            txtGenre.Text = genre;
        }
        private void btnDrama_Click(object sender, EventArgs e)
        {
            string genre = "Drama";
            txtGenre.Text = genre;
        }
        private void bntHorror_Click(object sender, EventArgs e)
        {
            string genre = "Horror";
            txtGenre.Text = genre;
        }
        private void btnRomance_Click(object sender, EventArgs e)
        {
            string genre = "Romance";
            txtGenre.Text = genre;
        }
        private void btnPoliceOfficer_Click(object sender, EventArgs e)
        {
            string genre = "Police Officer";
            txtGenre.Text = genre;
        }
        private void btnChild_Click(object sender, EventArgs e)
        {
            string genre = "Child";
            txtGenre.Text = genre;
        }
        private void btnThriller_Click(object sender, EventArgs e)
        {
            string genre = "Thriller";
            txtGenre.Text = genre;
        }
        private void btnScience_Click(object sender, EventArgs e)
        {
            string genre = "Science";
            txtGenre.Text = genre;
        }
        private void btnUS_Click(object sender, EventArgs e)
        {
            string genre = "US";
            txtGenre.Text = genre;
        }
        private void btnEurope_Click(object sender, EventArgs e)
        {
            string genre = "Europe";
            txtGenre.Text = genre;
        }
        private void btnMovie_Click(object sender, EventArgs e)
        {
            string categorie = "Movie";
            txtCategorie.Text = categorie;

            txtNbEpisode.Enabled = false;
            txtNbSeason.Enabled = false;
        }
        private void btnSerie_Click(object sender, EventArgs e)
        {
            string categorie = "Serie";
            txtCategorie.Text = categorie;

            txtNbEpisode.Enabled = true;
            txtNbSeason.Enabled = true;
        }
        private void btnAnime_Click(object sender, EventArgs e)
        {
            string categorie = "Anime";
            txtCategorie.Text = categorie;

            txtNbEpisode.Enabled = false;
            txtNbSeason.Enabled = false;
        }
    }
}
