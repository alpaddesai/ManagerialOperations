using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManagerialOperations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SupplyChainOperations_Click(object sender, RoutedEventArgs e)
        {
            string messageText = "Supply Chain Operations Reference Additional Project for Details ";
            MessageBox.Show(messageText, " Supply Chain",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void ProcessCapacity_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Process Capacity ";
            MessageBox.Show(messageText, " Process Capacity ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ProductProcessInnovation_Click(object sender, RoutedEventArgs e)
        {
            string messageText = "Product and Process Innovation ";
            MessageBox.Show(messageText, " Product Innovation ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ManufacturingProcesses_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Manufacturing Processes ";
            MessageBox.Show(messageText, " Manufacturing Processes ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LeanSystems_Click(object sender, RoutedEventArgs e)
        {
           string messageText = " Lean Systems";
           MessageBox.Show(messageText, " Lean Systems and Processes  ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ManagingQuality_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Managing Quality Assurance, reference additional projects for details";
            MessageBox.Show(messageText, " Quality Assurance", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Managing_Inventories_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Managing Inventories s";
            MessageBox.Show(messageText, " Logistics of Managing Inventories  ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Customer_Service_Logistics_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Customer Service Logistics ";
            MessageBox.Show(messageText, " Customer Service Logistics ", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void SupplyManagement_Click_1(object sender, RoutedEventArgs e)
        {
            string messageText = " Supply Chain Management ";
            MessageBox.Show(messageText, " Supply Chain Management and Processes ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SustainableOperations_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Sustainable Operations";
            MessageBox.Show(messageText, " Sustainable Operations and Processes ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LogisticsManagement_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Logistics Management ";
            MessageBox.Show(messageText, " Logistics Management ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DemandForecasting_Click(object sender, RoutedEventArgs e)
        {
            string messageText = "Demand Forecasting ";
            MessageBox.Show(messageText, " Demand Forecasting and Planning ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SalesOperationsPlanning_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Sales Operation Planning  ";
            MessageBox.Show(messageText, " Sales Operation Planning and Planning ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MaterialsResourceReqPlanning_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Materials Resoource Planning   ";
            MessageBox.Show(messageText, " Materials Resoource Planning  ", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ProjectPlanning_Click(object sender, RoutedEventArgs e)
        {
            string messageText = " Project Planning   ";
            MessageBox.Show(messageText, " Project Planning  ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
