List<string> friends = new List<string> { /* Participants names goes here */};
List<string> friendsLeft= new(friends);
List<string> friendsRaffled = new();
for (int i = 0; i < 12; i++)
{
    var raffled = friendsLeft[new Random().Next(0, friendsLeft.Count)];
    while(friends[i] == raffled) raffled = friendsLeft[new Random().Next(0, friendsLeft.Count)];
    friendsLeft.Remove(raffled);
    friendsRaffled.Add(raffled);
}
for (int i = 0; i < friends.Count; i++) Console.WriteLine($"{friends[i]} => {friendsRaffled[i]}");