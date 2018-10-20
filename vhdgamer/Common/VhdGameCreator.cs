using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using System.IO;

using DiscUtils;
using DiscUtils.Ntfs;
using DiscUtils.Partitions;
using DiscUtils.Vhd;

namespace Vhdgamer.Common
{
    public class VhdGameCreator
    {
        public void Create(long size, string sourceFolderPath, string targetFilePath, string diskLabel, string startFilePath)
        {
            // Create
            this.CreateDisk(targetFilePath, size, diskLabel);

            // Mount
            var disk = this.OpenDisk(targetFilePath);

            // Copy files
            var targetFolderPath = Path.Combine(disk.GetDriveLetter() + "\\", diskLabel);
            var computer = new Computer();
            computer.FileSystem.CopyDirectory(sourceFolderPath, targetFolderPath, UIOption.AllDialogs);

            disk.Close();
        }

        private void CreateDisk(string targetFilePath, long size, string diskLabel)
        {
            // Create the disk
            using (var vhdStream = File.Create(targetFilePath))
            {
                var disk = Disk.InitializeDynamic(vhdStream, Ownership.None, size);
                BiosPartitionTable.Initialize(disk, WellKnownPartitionType.WindowsNtfs);
                using (var fs = NtfsFileSystem.Format(new VolumeManager(disk).GetLogicalVolumes()[0], diskLabel))
                {
                    //fs.CreateDirectory(@"TestDir\CHILD");
                    // do other things with the file system...
                }
            }
        }

        private VirtualDisk OpenDisk(string targetFilePath)
        {
            var disk = new VirtualDisk(targetFilePath);
            disk.Open();
            disk.Attach(VirtualDiskAttachOptions.None);
            return disk;
        }
    }
}
