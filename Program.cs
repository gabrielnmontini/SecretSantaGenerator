var friends = new List<string> { /* Participants names goes here */ };
var friendsRaffled = new List<string>(friends).OrderBy(fren => new Random().Next(0, friends.Count - 1)).ToList();
for (int i = 0; i < friends.Count; i++) Console.WriteLine($"{friends[i]} => {friendsRaffled[i]}");
