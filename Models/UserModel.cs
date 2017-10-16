using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShipBobApp_LMB.Models
{
    public class UserModel
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; private set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }
    }

    // public User() {}


    public class Users
    {
        /// <summary>
        /// The user list.
        /// </summary>
        public List<UserModel> _userList = new List<UserModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ShipBobApp_LMB.Models.Users"/> class.
        /// </summary>
        public Users() => _userList.Add(new UserModel
        {
            //Id: 1,
            //FirstName: "Laura",
            //LastName: "Brennan"
        });

        /// <summary>
        /// Creates the user and adds it to _userList
        /// </summary>
        /// <param name="userModel">User model.</param>
        public void AddEditUser(UserModel userModel)
        {
            _userList.Add(userModel);
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="userModel">User model to update.</param>
        public void UpdateUser(UserModel userModel)
        {
            foreach (UserModel user in _userList)
            {
                if (user.Id == userModel.Id)
                {
                    _userList.Remove(user);
                    _userList.Add(userModel);
                    break;
                }
            }
        }

        /// <summary>
        /// Removes the user.
        /// </summary>
        /// <param name="userModel">User model to remove.</param>
        public void RemoveUser(UserModel userModel)
        {
            foreach (UserModel user in _userList)
            {
                if (user.Id == userModel.Id)
                {
                    _userList.Remove(user);
                    break;
                }
            }
        }

    }
}
