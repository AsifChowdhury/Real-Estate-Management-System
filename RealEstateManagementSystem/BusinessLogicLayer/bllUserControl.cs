using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagementSystem.DataAccessLayer;
using System.ComponentModel.DataAnnotations;

namespace RealEstateManagementSystem.BusinessLogicLayer
{
    class bllUserControl
    {
        dalUserControl _dLayer = new dalUserControl();

        #region Properties
        //[Required(ErrorMessage = "Cannot Proceed without LogIn Id.", AllowEmptyStrings = false)]
        //[Display(Name = "LogIn Id")]
        public string UserId { get; set; }

        //[Required(ErrorMessage = "Cannot proceed without Password.", AllowEmptyStrings = false)]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentPosition { get; set; }
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email address is invalid.")]
        public string EMail { get; set; }

        public bool IsValidLogIn { get; set; }

        #endregion

        internal bool ValidateUserLogIn()
        {
            try
            {
                if (UserId == string.Empty) { throw new Exception("Please Provide the User Id."); }
                if (Password == string.Empty) { throw new Exception("Please Provide the Password."); }
                return _dLayer.ValidateUserLogIn(this);
            }
            catch (Exception ex) { throw ex; }
        }

        internal void GetUserDetails()
        {
            try
            {
                _dLayer.GetUserDetails(this);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
