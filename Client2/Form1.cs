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
            catch(Exception ex)
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
    }
}
