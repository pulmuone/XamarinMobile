using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static ServiceReference1.Cont_Work_DSoapClient;

namespace XamarinMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {

            //Cont_Work_DSoap, Cont_Work_DSoap12  두개중에 어느거?..
            Cont_Work_DSoapClient client = new Cont_Work_DSoapClient(EndpointConfiguration.Cont_Work_DSoap12);

            User_Data[] ud = new User_Data[1];
            ud[0].Tran_Code = "111";
            ud[0].Tran_Name = "111";
            ud[0].Work_Group = "111";
            
            await client.Log_inAsync("userid", "pass", ud);


            client.Close();

        }
    }
}
