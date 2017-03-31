using System;
using PBOSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOSharp.Objects;
using PBOSharp.Enums;

namespace PBOSharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //New PBOToolsClient instance 
            PBOSharpClient client = new PBOSharpClient();

            //Assing EH 
            client.onEvent += Client_onEvent;

            //AnalyzePBO
            PBO pbo = client.AnalyzePBO($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Workspace\\MyMission.Altis.pbo");

            //Extract with PBO object
            //client.ExtractAll(pbo, $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PBOOutput");

            //Extract with file path 
            //client.ExtractAll($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Workspace\\MyMission.Altis.pbo");

            //client.PackPBO(
            //    $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PBOOutput\\MyMission.Altis", 
            //    $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PBOOutput", 
            //    "MyMission.Altis.pbo");

            //Extract specific files data 
            //byte[] fileData = client.ExtractFileData(pbo.Files[0]);

            //Access list of all files within the pbo 
            //pbo.Files

            //Access file data attributes 
            //pbo.Files[0].FileName 
            //pbo.Files[0].FileNameShort 
            //pbo.Files[0].PackingMethod
            //pbo.Files[0].OriginalSize 
            //pbo.Files[0].Reserved
            //pbo.Files[0].Timestamp
            //pbo.Files[0].DataSize
            //pbo.Files[0].Offset
        }

        private static void Client_onEvent(PBOSharpEventArgs args)
            => Console.WriteLine($"[{args.Type}] {args.Message}");
    }
}
