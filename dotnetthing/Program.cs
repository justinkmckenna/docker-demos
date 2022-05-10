var fileName = "someText.txt";
var current = 0;
var path = Path.Join("data", fileName); //using Path is a little safer for cross platform than just path = "data/someText.txt"
if(File.Exists(path)) {
    var content = File.ReadAllText(path);
    current = int.Parse(content);
}
Console.WriteLine($"Current is {current}");
while(true) {
    Thread.Sleep(3000);
    current = ++current;
    File.WriteAllText(path, (current).ToString());
    Console.WriteLine($"Wrote {current} at {DateTime.Now:t}");
}