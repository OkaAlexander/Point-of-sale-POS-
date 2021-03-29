using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DeveloperConfigurations;
namespace POS.Views
{
    public partial class ApplicationConfigurationSettings : MaterialSkin.Controls.MaterialForm
    {

        DeveloperConfigurations.DeveloperConfigurations developerConfiguration = new DeveloperConfigurations.DeveloperConfigurations();

        public ApplicationConfigurationSettings()
        {
            InitializeComponent();
            Developer.Text = developerConfiguration.GetDeveloper();
            Version.Text = developerConfiguration.ApplicationVersion();
            License.Text = Environment.MachineName;
            Owner.Text = developerConfiguration.GetOwner();
        }
    }
}
