using Microsoft.Azure.Cosmos;

string EndpointUri = "<<Endpoint-general>>";
string PrimaryKey = "<<Primary-key>>";
string databaseId = "az204Database";
string containnerId ="az204Container";

try
{
    Console.WriteLine("Inicia app cosmos db...");
    CosmosClient cosmosClient= new CosmosClient(EndpointUri,PrimaryKey);
    var database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
    Console.WriteLine($"BD creada: {database.Database.Id}");
    var container = await database.Database.CreateContainerIfNotExistsAsync(containnerId, "/LastName");
    Console.WriteLine($"Container creado: {container.Container.Id}");
}
catch (Exception ex)
{
    Console.WriteLine("", ex.Message);
}
finally
{
    Console.WriteLine("Finaliza el programa... ");
    Console.ReadKey();
}


