﻿using RealEstateManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagementSystem.Utilities;
using RealEstateManagementSystem.Reports;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmRoot_CancelList : Form
    {
        public DateTime startDate;
        public frmRoot_CancelList()
        {
            InitializeComponent();
        }

        private void frmRoot_CancelList_Load(object sender, EventArgs e)
        {
            this.Text = "List of Cancelled Client since " + startDate.ToString("dddd dd-MMM-yyyy");
            bllGlobal b = new bllGlobal();
            foreach (DataRow drItems in b.GetRootCancelledList(startDate).Rows)
            {
                ListViewItem lvItems = new ListViewItem(Convert.ToString(drItems["ClientId"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["Name"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["ContactNumber"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["ProjectName"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["UnitNumber"]));
                lvItems.SubItems.Add(Convert.ToString(drItems["CancelDate"]).ShowAsStandardDateFormat(false));
                lstcancelList.Items.Add(lvItems);
            }
            tssStatus.Text = "Total # of Cancelled Unit(s): " + lstcancelList.Items.Count;
        }

        private void lstcancelList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstcancelList.Items.Count > 0 && lstcancelList.SelectedItems.Count > 0)
            {
                ContextMenu c = new ContextMenu();
                MenuItem clientProfile = new MenuItem("Profile", clientProfile_OnClick);
                MenuItem paymentSchedule = new MenuItem("Payment Schedule", paymentSchedule_OnClick);
                MenuItem paymentHistory = new MenuItem("Payment History", paymentHistory_OnClick);
                MenuItem sep1 = new MenuItem("-");
                c.MenuItems.Add("ClientId # " + lstcancelList.SelectedItems[0].Text.ToString());
                c.MenuItems.Add(sep1);
                c.MenuItems.Add(clientProfile);
                c.MenuItems.Add(paymentSchedule);
                c.MenuItems.Add(paymentHistory);
                c.Show((Control)sender, e.Location);
            }
        }

        private void paymentHistory_OnClick(object sender, EventArgs e)
        {
            clsGlobalClass.ShowUnderConstructionMessage();
        }

        private void paymentSchedule_OnClick(object sender, EventArgs e)
        {
            clsGlobalClass.ShowUnderConstructionMessage();
        }

        private void clientProfile_OnClick(object sender, EventArgs e)
        {
            try { clsReports.ShowReport_ClientProfile(lstcancelList.SelectedItems[0].Text.ToString(), tssStatus); }
            catch (Exception ex) { ex.Display(); }
        }
    }
}
