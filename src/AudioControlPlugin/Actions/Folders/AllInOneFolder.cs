﻿namespace Loupedeck.AudioControlPlugin
{
    using System;

    internal class AllInOneFolder : Folder
    {
        public const string ICON_RESOURCE_PATH = "all-in-one.png";

        public const string DISPLAY_NAME = "All in one";
        public const string DESCRIPTION = "";
        public const string GROUP_NAME = "";

        public AllInOneFolder() : base(DISPLAY_NAME, DESCRIPTION, GROUP_NAME)
        {
            base.HomePage = new AllInOnePage(this);
        }

        public override BitmapImage GetButtonImage(PluginImageSize imageSize)
        {
            return PluginImage.DrawFolderIconImage(true, ICON_RESOURCE_PATH, imageSize);
        }
    }
}
