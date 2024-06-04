﻿using Linkedin_Automation.Model;

namespace forms.Models.Interfaces
{
    public interface ILoginRepository : IBaseRepository
    {
        UserModel ConvertMsgpackFileToObject();
        string GetFilePath();
    }
}
