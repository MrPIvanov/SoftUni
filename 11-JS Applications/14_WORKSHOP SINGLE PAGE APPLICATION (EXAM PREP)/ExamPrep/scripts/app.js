const handlers = {}

$(() => {
  const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');

    // home page routes
    this.get('/index.html', handlers.getHome);
    this.get('/', handlers.getHome);
    this.get('#/home', handlers.getHome);

    // user routes
    this.get('#/register', handlers.getRegister);
    this.get('#/login', handlers.getLogin);

    this.post('#/register', handlers.registerUser);
    this.post('#/login', handlers.loginUser);
    this.get('#/logout', handlers.logoutUser);

    // ADD YOUR ROUTES HERE

    this.get('#/allSongs', handlers.getAllSongs);
    this.get('#/createSong', handlers.getCreateSong);
    this.get('#/mySongs', handlers.getMySongs);


    this.get('#/removeSong/:id', handlers.removeSong);
    this.get('#/removeSongMy/:id', handlers.removeSongMy);
    this.get('#/likeSong/:id', handlers.likeSong);
    this.get('#/listenSong/:id', handlers.listenSong);
    this.get('#/listenSongMy/:id', handlers.listenSongMy);

    this.post('#/createSongPost', handlers.postSong);

    
  });
  app.run('#/home');
});