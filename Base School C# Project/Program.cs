class Quest
{
    string title;

    string difficulty;

    int reward;

    public Quest(string questTitle, string questDifficulty, int questReward)
    {
        title = questTitle;
        difficulty = questDifficulty;
        reward = questReward;
    }

    public void printBadge()
    {
        Console.WriteLine($"{title} - {difficulty} Quest - {reward} XP");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Quest questOne = new Quest("Finish this task", "Hard", 50);

        Quest questTwo = new Quest("Turn in task", "Medium", 40);

        Quest questThree = new Quest("Close laptop", "Easy", 30);

        questOne.printBadge();
        questTwo.printBadge();
        questThree.printBadge();
    }
}
