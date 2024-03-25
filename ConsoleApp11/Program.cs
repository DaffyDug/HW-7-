using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        DraverHelper.Avalible();


        DriveInfo[] driveInfos = DriveInfo.GetDrives();
        foreach (var item in driveInfos)
        {
            if (item.IsReady)
            {
                Console.WriteLine(item.TotalFreeSpace.ToGb());
                Console.WriteLine(item.RootDirectory);
            }
            if (Directory.Exists($@"{item.RootDirectory}\Windows"))
            {
                Console.WriteLine("такая папка есть");
            }
            else
            {
                Console.WriteLine("такой папки нет");
            }
        }
    }
}
public static class TOGB
{
    public static long ToGb(this long b)
    {
        return b / 1000000000;
    }
}

public static class DraverHelper
{
    public static void Avalible()
    {
        int procent;
        DriveInfo[] driveInfos = DriveInfo.GetDrives();
        foreach (var item in driveInfos)
        {
            if (item.IsReady)
            {
                procent = (int)((float)item.TotalFreeSpace / (float)item.TotalSize * 100);
                Console.WriteLine($"{item.Name} {procent}%");
            }
        }
    }
}
