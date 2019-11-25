using Codelab.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Codelab.ViewModels
{
    class ListUsersViewModel
    {
        public ObservableCollection<ListUsersModel> UsersList { get; set; }

        public ListUsersViewModel()
        {
            UsersList = new ObservableCollection<ListUsersModel>();
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
            UsersList.Add(new ListUsersModel { Name = "Jkamz", Image = "https://i.imgur.com/aYkGpAV.png", Detail = "The one who knocks" });
        }
    }
}
