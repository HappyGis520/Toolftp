﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows;
using AutoMapper;
using GTD.Api.Request;
using GTD.Api.Response;
using EllaMaker.FTP.Helper;
using EllaMaker.FTP.Model;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;

namespace EllaMaker.FTP
{
    public static class GlobalPara
    {
        public static string WebApiAdress= DESEncryptHelper.Decrypt(ConfigurationManager.AppSettings.Get("WebApiAdress"));
        public static string ImageServerAdress = DESEncryptHelper.Decrypt(ConfigurationManager.AppSettings.Get("ImageServerAdress"));
        public static string UserName= INIOperationHelper.INIGetStringValue(AppDomain.CurrentDomain.BaseDirectory + "DownloadRec.ini", "User","Name","");
        public static string UserPwd = DESEncryptHelper.Decrypt(INIOperationHelper.INIGetStringValue(AppDomain.CurrentDomain.BaseDirectory + "DownloadRec.ini", "User","Pwd", ""));
        public static bool Remember = INIOperationHelper.INIGetStringValue(AppDomain.CurrentDomain.BaseDirectory + "DownloadRec.ini", "User", "Remember", "0") != "0";
        public static string SourceServerAdress =
            DESEncryptHelper.Decrypt(ConfigurationManager.AppSettings.Get("SourceServerAdress"));
        public static string SourceUserName =
            DESEncryptHelper.Decrypt(ConfigurationManager.AppSettings.Get("SourceUserName"));
        public static string SourcePwd =
            DESEncryptHelper.Decrypt(ConfigurationManager.AppSettings.Get("SourcePwd"));
        public static DocumentV1QueryModel CatalogNow = new DocumentV1QueryModel();
        public static int rootTypeNow = 3;
        public static string UploadPathNow = "";
        public static string IniPath = AppDomain.CurrentDomain.BaseDirectory + "DownloadRec.ini";
        public static long lastDownSize = 0;
        public static List<DocumentV1Request> FolderNeedUpload = new List<DocumentV1Request>();
        public static string DefaultSavePath =
            INIOperationHelper.INIGetStringValue(IniPath, "System", "DefaultSavePath", @"C:\");
        private static List<EmployeeAndDeptNodelApiModel> _deptTreesSource;
        private static List<EmployeeAndDeptNodelApiModel> _personTreesSource;
        public static bool CompanyDocDeletRight = false;
        public static bool CompanyFileDeletRight = false;
        public static bool CompanyDocEditRight = false;
        public static bool CompanyFileEditRight = false;

        public static List<EmployeeAndDeptNodelApiModel> PersonTreesSource
        {
            get { return _personTreesSource; }
        }

        public static List<EmployeeAndDeptNodelApiModel> DeptTreesSource
        {
            get { return _deptTreesSource; }
        }

        public static void SetPersonTreesSource(List<EmployeeAndDeptNodelApiModel> value)
        {
            _personTreesSource = value;
        }

        public static void SetDeptTreesSource(List<EmployeeAndDeptNodelApiModel> value)
        {
            _deptTreesSource = value;
        }
        public static List<string> DepartId;
        public static List<OpenFolderOptDataModel> RecordList = new List<OpenFolderOptDataModel>();
        public static GTD.Api.WebApis webApis = new Api.WebApis(WebApiAdress);
        public static AuthToken authToken = new AuthToken();
        public static List<EmployerApiModel> ComapnyList = new List<EmployerApiModel>();
        public static List<DocBaseInfoApiModel> UploadItems = new List<DocBaseInfoApiModel>();
        public static bool hasSyncRight(DocumentsModel value)
        {
            if (value.CreatorId == GlobalPara.authToken.Profile.ProfileId) return true;
            if (value.SynergyRange.departs == null) return false;
            bool hasSyncRight =
            (value.SynergyRange.departs.Select(p => p.DepartmentId).ToList().Intersect(GlobalPara.DepartId).Any() ||
             value.SynergyRange.users.Select(p => p.ProfileId).ToList()
                 .Intersect(new List<string>() {GlobalPara.authToken.Profile.ProfileId}).Any());
            {
                return true;
            }
            return false;

        }
    }
}
