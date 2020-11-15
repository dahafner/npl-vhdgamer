using Danisoft.Utils.Powershell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;

namespace VhdMountTest
{
    public class ImageMounter
    {
        private readonly string filePath;

        public ImageMounter(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));

            this.filePath = filePath;
        }

        public void Mount()
        {
            PowershellWrapper.MountDiskImage(this.filePath);
        }

        public void Unmount()
        {
            PowershellWrapper.DismountDiskImage(this.filePath);
        }
    }
}
