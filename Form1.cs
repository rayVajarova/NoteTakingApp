using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {

        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadNotes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT NoteID, Title, Content, timeOfSave FROM Notes", connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notes: " + ex.Message);
            }
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Notes (Title, Content, timeOfSave) VALUES (@Title, @Content, @timeOfSave)", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Content", Content.Text);
                    cmd.Parameters.AddWithValue("@timeOfSave", DateTime.Now.ToString());

                    cmd.ExecuteNonQuery();


                }



                LoadNotes();
                MessageBox.Show("Note added successfully.");

            }



        }



        private void DeleteNote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = dataGridView1.SelectedRows[0].Index;
                int NoteID = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["NoteID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC22\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Notes WHERE NoteID = @NoteID", connection);
                        command.Parameters.AddWithValue("@NoteID", NoteID);
                        command.ExecuteNonQuery();
                    }

                    LoadNotes();
                    MessageBox.Show("Note deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting note: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }
    }

}