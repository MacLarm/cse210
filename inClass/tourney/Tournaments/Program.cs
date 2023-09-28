
Team chungas = new Team("Big Chungas");

Player yoshi = new Player("Beeg Yoshi", 2);
Player john = new Player("John Jacob", 42);

chungas.AddPlayer(yoshi);
chungas.AddPlayer(john);
chungas.DisplayRoster();

Team spinners = new Team("spinners");

Player lilly = new Player("Lilly Mae", 0);
Player Anne = new Player("Anne Banana",21);
spinners.AddPlayer(lilly);
spinners.AddPlayer(Anne);

Match match1 = new Match(chungas,spinners);
match1.DecideWin();

spinners.DisplayRoster();
chungas.DisplayRoster();