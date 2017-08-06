using RealEstateManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
    class bllGlobal
    {
        dalGlobal dLayer = new dalGlobal();
        #region Client Search
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string UnitNumber { get; set; }

        #region For Summary Data on Main Screen
        public decimal Collection { get; set; }
        public decimal UnitSold { get; set; }


        public decimal UnitCancelled { get; set; }
        public DateTime StartDate { get; set; }



        #endregion



        internal DataTable GetListOfClients(bool includeCancelledClients = false)
        {
            return dLayer.GetListOfClients(this, includeCancelledClients);
        }

        internal DataTable GetCollectionData(DateTime startDate)
        {
            return dLayer.GetCollectionData(startDate);
        }

        internal void GetSummaryDataForMainScreen()
        {
            dLayer.GetSummaryDataForMainScreen(this);
        }

        internal DataTable GetRootSoldList(DateTime startDate)
        {
            return dLayer.GetRootSoldList(startDate);
        }
        internal DataTable GetRootCancelledList(DateTime startDate)
        {
            return dLayer.GetRootCancelledList(startDate);
        }

        internal DataTable GetCollectionDetails(DateTime startDate)
        {
            return dLayer.GetCollectionDetails(startDate);
        }

        #endregion
    }
}
