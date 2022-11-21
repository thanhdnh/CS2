using System.Collections;

class HTAccount{
    private Hashtable infos = new Hashtable();
    public HTAccount(string username, string email, int age, string status){
        infos.Add("username", username);
        infos.Add("email", email);
        infos["age"] = age;
        infos["status"] = status;
    }
  public override string ToString()
  {
    return $"HTAccount[username:{infos["username"]}, email:{infos["email"]}, age:{infos["age"]}, status:{infos["status"]}]";
  }
}