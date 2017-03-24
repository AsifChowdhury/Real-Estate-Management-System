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
            try { return _dLayer.GetListOfAuthenticatedUsers(authorizedOnly); }
            catch (Exception ex) { throw ex; }
        }

        internal bool ValidateUserLogIn()
        {
            try { return _dLayer.ValidateUserLogIn(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void GetUserDetails()
        {
            try { _dLayer.GetUserDetails(this); }
            catch (Exception ex) { throw ex; }
        }

        internal void SetAppAuthentication()
        {
            try
            {
                _dLayer.SetAppAuthentication(this.UserId, this.IsAllowed);
            }
            catch (Exception ex) { throw ex; }
        }

        internal DataSet GetActiveMenuList()
        {
            try { return _dLayer.GetActiveMenuList(); }
            catch (Exception ex) { throw ex; }
        }

        internal DataTable GetListOfAuthorizedUsers_ByMenuKey()
        {
            try { return _dLayer.GetListOfAuthorizedUsers_ByMenuKey(this.MenuKey); }
            catch (Exception ex) { throw ex; }
        }

        internal void ManipulateApplicationMenu()
        {
            try { _dLayer.ManipulateApplicationMenu(this.MenuKey); }
            catch (Exception ex) { throw ex; }
        }

        internal void SetAppMenuAuthentication()
        {
            try { _dLayer.SetAppMenuAuthentication(this.MenuKey, this.UserId, this.IsAllowed); }
            catch (Exception ex) { throw ex; }
        }
    }
}
