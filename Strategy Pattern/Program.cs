using Strategy_Pattern;

Player player = new Player(new Axe());
Game game = new Game(player);
game.StartGame();