﻿using System.Runtime.Serialization;
using DotNetNuke.Services.Localization;

namespace DotNetNuke.Web.UI.WebControls
{
    [DataContract]
    public class DnnGettingStartedOptions
    {

        [DataMember(Name = "showOnStartup")]
        public bool ShowOnStartup;

        [DataMember(Name = "title")]
        public string Title;

        [DataMember(Name = "signUpLabel")]
        public string SignUpLabel;

        [DataMember(Name = "signUpText")]
        public string SignUpText;

        [DataMember(Name = "signUpButton")]
        public string SignUpButton;

        [DataMember(Name = "downloadManualButton")]
        public string DownloadManualButton;

        [DataMember(Name = "dontShowDialogLabel")]
        public string DontShowDialogLabel;

        [DataMember(Name = "facebookLinkTooltip")]
        public string FacebookLinkTooltip;

        [DataMember(Name = "twitterLinkTooltip")]
        public string TwitterLinkTooltip;

        [DataMember(Name = "contentUrl")]
        public string ContentUrl;

        [DataMember(Name = "userManualLinkUrl")]
        public string UserManualLinkUrl;

        public DnnGettingStartedOptions()
        {
            // all the resources are located under the Website\App_GlobalResources\SharedResources.resx
            Title = Localization.GetString("GettingStarted.Title", Localization.SharedResourceFile);
            SignUpLabel = Localization.GetString("GettingStarted.SignUpLabel", Localization.SharedResourceFile);
            SignUpText = Localization.GetString("GettingStarted.SignUpText", Localization.SharedResourceFile);
            SignUpButton = Localization.GetString("GettingStarted.SignUpButton", Localization.SharedResourceFile);
            DownloadManualButton = Localization.GetString("GettingStarted.DownloadManualButton", Localization.SharedResourceFile);
            DontShowDialogLabel = Localization.GetString("GettingStarted.DontShowDialogLabel", Localization.SharedResourceFile);
            FacebookLinkTooltip = Localization.GetString("GettingStarted.FacebookLinkTooltip", Localization.SharedResourceFile);
            TwitterLinkTooltip = Localization.GetString("GettingStarted.TwitterLinkTooltip", Localization.SharedResourceFile);
        }

    }
}
