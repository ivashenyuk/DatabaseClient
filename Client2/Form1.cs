using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using components;
using System.ServiceModel;

namespace Client2
{
    public partial class Form1 : Form
    {
        Uri address;
        BasicHttpBinding binding;
        EndpointAddress endpoint;

        ChannelFactory<IUsers> factory;
        IUsers channel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.address = new Uri("http://localhost/IUsers");
                this.binding = new BasicHttpBinding();
                this.endpoint = new EndpointAddress(this.address);

                this.factory = new ChannelFactory<IUsers>(this.binding, this.endpoint);
                this.channel = this.factory.CreateChannel();
                this.SetValues();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connecting to server failed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void SetValues()
        {
            if (this.channel != null)
            {
                List<User> users = this.channel.GetUsers();

                foreach (var user in users)
                {
                    this.dataTableUsers.Rows.Add(user.Id, user.Name, user.Lastname, user.Birthday);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.dataTableUsers.Rows.Clear();
            SetValues();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.channel != null)
            {
                User user = CreateUser();
                if (user != null)
                {
                    this.channel.AddUser(user);
                    btnUpdate_Click(sender, e);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.channel != null)
            {
                User user = CreateUser();
                if (user != null)
                {
                    this.channel.EditUser(user);
                    btnUpdate_Click(sender, e);
                }

            }
        }
        private User CreateUser()
        {
            if (this.inputId.Text != "" &&
                      this.inputName.Text != "" &&
                      this.inputLastname.Text != "" &&
                      this.inputBirthday.Text != "")
            {
                return new User(
                    Convert.ToInt32(this.inputId.Text),
                    Convert.ToString(this.inputName.Text),
                    Convert.ToString(this.inputLastname.Text),
                    Convert.ToDateTime(this.inputBirthday.Text)
                      );
            }
            return null;
        }
    }
}
