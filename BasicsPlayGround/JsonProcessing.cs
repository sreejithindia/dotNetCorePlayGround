using Nancy.Json;

namespace BasicsPlayGround
{
    public class Name
    {
        public int[] Values { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class JsonProcessing
    {
        public Name ConvertToName ()
        {
            var json = "{'FirstName': 'David', 'LastName': 'Fincher', 'Values': [0,1,2]}";
            var ser = new JavaScriptSerializer();
            return ser.Deserialize<Name>(json);
        }
    }
}
