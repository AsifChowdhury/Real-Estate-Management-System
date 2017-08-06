using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.DataAccessLayer;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
    class bllUserControl
    {
        dalUserControl _dLayer = new dalUserControl();

        #region Properties
        public string UserId { get; set; }
        public string Password { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentPosition { get; set; }
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email address is invalid.")]
        public string EMail { get; set; }

        public bool IsValidLogIn { get; set; }

        public bool IsAllowed { get; set; }
        public string MenuKey { get; set; }
        #endregion

        internal DataTable GetListOfAuthenticatedUsers(bool authorizedOnly = false)
        {
            return _dLayer.GetListOfAuthenticatedUsers(authorizedOnly);

        }

        internal bool ValidateUserLogIn()
        {
            return _dLayer.ValidateUserLogIn(this);
        }

        internal void GetUserDetails()
        {
            _dLayer.GetUserDetails(this);
        }

        internal void SetAppAuthentication()
        {
            _dLayer.SetAppAuthentication(this.UserId, this.IsAllowed);
        }

        internal DataSet GetActiveMenuList()
        {
            return _dLayer.GetActiveMenuList();
        }

        internal DataTable GetListOfAuthorizedUsers_ByMenuKey()
        {
            return _dLayer.GetListOfAuthorizedUsers_ByMenuKey(this.MenuKey);

        }

        internal void ManipulateApplicationMenu()
        {
            _dLayer.ManipulateApplicationMenu(this.MenuKey);
        }

        internal void SetAppMenuAuthentication()
        {
            _dLayer.SetAppMenuAuthentication(this.MenuKey, this.UserId, this.IsAllowed);
        }
    }
}
