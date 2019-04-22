handlers.getHome = async function (ctx) {
  ctx.isAuth = userService.isAuth();
  ctx.firstName = sessionStorage.getItem('firstName');
  ctx.lastName = sessionStorage.getItem('lastName');

  if (userService.isAuth()) {
    try {
      ctx.recipes = await foodService.getAllRecipes();
    } catch (err) {
      notify.handleError(err)
    }

    ctx.haveRecipes = ctx.recipes.length === 0;
  }

  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs',
    recipe: '../views/food/recipe.hbs'
  }).then(function () {
    this.partial('views/home/home.hbs');
  });
}