using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the member lookup form of the RentMe Application
    /// </summary>
    public partial class MemberLookupForm : Form
    {
        private List<Member> theMemberList;
        private Member theSelectedMember;

        public List<Member> TheMemberList
        {
            get { return this.theMemberList; }
            set {
                if (value == null || value.Count == 0)
                {
                    throw new Exception("Member list not provided");
                }
                this.theMemberList = value; 
            } 
        }

        public Member TheSelectedMember 
        {
            get { return this.theSelectedMember; }
        }

        /// <summary>
        /// Initialize the member lookup form
        /// </summary>
        public MemberLookupForm()
        {
            InitializeComponent();
        }

        private void OnMemberLookupFormLoad(object sender, EventArgs e)
        {
            memberBindingSource.Clear();
            foreach (Member theMember in theMemberList)
            {
                memberBindingSource.Add(theMember);
            }
        }

        private void MemberDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                int i = e.RowIndex;
                this.theSelectedMember = (Member)memberBindingSource[i];
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButtonOnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
