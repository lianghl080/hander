
async Task<int> AccessTheWebAsync()
 7 { 
 9     HttpClient client = new HttpClient();

13     Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com"); 

16     DoIndependentWork(); 

23     string urlContents = await getStringTask; 
27     return urlContents.Length;
28 }


static void Go() { throw null; }
static string GetName() { throw null; }

public static void Main(){
    try{
        new Thread(Go).Start();
    }
    catch (Exception ex){

        Console.WriteLine('Exception!');
    }
}

public static void Main(){
    try{
        var task = Task.Run(() => { Go(); });
        task.Wait(); 

        var task2 = Task.Run(() => { return GetName(); });
        var name = task2.Result;
    }
    catch (Exception ex){
        Console.WriteLine('Exception!');
    }
}