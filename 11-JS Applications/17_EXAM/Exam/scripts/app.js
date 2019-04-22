const handlers = {}

$(() => {
  const app = Sammy('#rooter', function () {
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

    this.get('#/createRecipe', handlers.getCreateRecipe);
    this.post('#/createRecipe', handlers.postCreateRecipe);

    this.get('#/viewRecipe/:id', handlers.getViewRecipe);
    this.get('#/edit/:id', handlers.getEdit);
    this.post('#/editRecipe/:id', handlers.postEdit);

    this.get('#/archive/:id', handlers.getArchive);
    this.get('#/like/:id', handlers.getLike);


    
  });
  app.run('#/home');
});