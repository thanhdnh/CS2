class Account
{
  private string username;
  private string email;
  private int age;
  private string status;
  public Account(string username, string email, int age, string status){
    this.username = username;
    this.email = email;
    this.age = age;
    this.status = status;
  }
  //public string getUsername(){return username;}
  //public void setUsername(string username){this.username = username;}
  //public string abc{get; set;}
  public string Username { get => username; set => username = value; }
  public string Email { get => email; set => email = value; }
  public int Age { get => age; set => age = value; }
  public string Status { get => status; set => status = value; }
  public override string ToString()
  {
    return $"Account[username:{username}, email:{email}, age:{age}, status:{status}]";
  }
}