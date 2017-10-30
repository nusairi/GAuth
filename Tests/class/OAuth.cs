using Google.Apis.Auth.OAuth2;
using Google.Apis.Tasks.v1;
using Google.Apis.Tasks.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace Tests
{
    class OAuth
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/tasks-dotnet-quickstart.json
        static string[] Scopes = { TasksService.Scope.Tasks };
        static string ApplicationName = "Google Tasks API .NET Quickstart";
        
        public void Googlepoc()
        {
           

            




       
       

            // Define parameters of request.
            TasklistsResource.ListRequest listRequest = service.Tasklists.List();
            listRequest.MaxResults = 10;

            // List task lists.
            IList<TaskList> taskLists = listRequest.Execute().Items;
            Console.WriteLine("Task Lists:");
            if (taskLists != null && taskLists.Count > 0)
            {
                foreach (var taskList in taskLists)
                {
                    Console.WriteLine("{0} ({1})", taskList.Title, taskList.Id);
                }
            }
            else
            {
                Console.WriteLine("No task lists found.");
            }
            Console.Read();
        }

        public static UserCredential authorize()
        {
            UserCredential credential;
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/tasks-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            return credential;
        }
        public static Tasks getTasksService()
        {
            UserCredential credential = authorize();
            // Create Google Tasks API service.
            var service = new Tasks(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
    }
   
}
