using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ViewRentalHistoryForm : Form
    {
        private RentalTransactionController theRentalTransactionController;

        public int MemberID { get; set; }

        public ViewRentalHistoryForm()
        {
            InitializeComponent();
            this.theRentalTransactionController = new RentalTransactionController();
        }

        private void DisplayTransactionHistory()
        {
            rentalTransactionBindingSource.Clear();
            List<RentalTransaction> theRentalTransactionList = this.theRentalTransactionController.GetAllRentalTransactionsByMemberID(this.MemberID);
            foreach (RentalTransaction theRentalTransaction in theRentalTransactionList)
            {
                rentalTransactionBindingSource.Add(theRentalTransaction);
            }
        }

        private void OnViewRentalHistoryFormLoad(object sender, EventArgs e)
        {
            this.DisplayTransactionHistory();
        }
    }
}
