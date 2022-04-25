﻿using ExamSystemAppApi.Models;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public interface IUserServices
    {
        List<User> GetAllUsers();
        void InsertNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
