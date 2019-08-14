handlers.getCreateRecipe = function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.firstName = sessionStorage.getItem('firstName');
    ctx.lastName = sessionStorage.getItem('lastName');

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
    }).then(function () {
        this.partial('../views/food/createRecipe.hbs');
    });
}

handlers.postCreateRecipe = function (ctx) {

    let meal = ctx.params.meal;
    let ingredients = ctx.params.ingredients;
    let prepMethod = ctx.params.prepMethod;
    let description = ctx.params.description;
    let foodImageURL = ctx.params.foodImageURL;
    let category = ctx.params.category;

    if (meal.length < 4) {
        notify.showError("The meal should be at least 4 characters long.");
        return;
    }
    if (ingredients.split(' ').length < 2) {
        notify.showError('The ingredients should at least 2');
        return;
    }
    if (prepMethod.length < 10) {
        notify.showError("The preparation method should be at least 10 characters long.");
        return;
    }
    if (description.length < 10) {
        notify.showError("The description should be at least 10 characters long.");
        return;
    }
    if (!foodImageURL.startsWith('http')) {
        notify.showError('The image should start with "http://" or "https://"');
        return;
    }

    if (category === 'Select category...') {
        notify.showError("Select Category.");
        return;
    }

    foodService.addRecipe(meal, ingredients, prepMethod, description, foodImageURL, category).then((res) => {

        notify.showInfo('Recipe shared successfully!');

        ctx.redirect('#/home');
    }).catch(function (err) {
        notify.handleError(err)
    });

}

handlers.getViewRecipe = async function (ctx) {

    ctx.isAuth = userService.isAuth();
    ctx.firstName = sessionStorage.getItem('firstName');
    ctx.lastName = sessionStorage.getItem('lastName');

    let id = ctx.params.id;
    let currentRecipe = await foodService.getRecipeById(id);

    ctx.meal = currentRecipe.meal
    ctx.prepMethod = currentRecipe.prepMethod
    ctx.description = currentRecipe.description
    ctx.ingredients = currentRecipe.ingredients
    ctx.likes = currentRecipe.likesCounter
    ctx.recipeId = currentRecipe._id;
    ctx.foodImageURL = currentRecipe.foodImageURL

    ctx.isAuthor = currentRecipe._acl.creator === sessionStorage.getItem('id');

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
    }).then(function () {
        this.partial('views/food/singleRecipe.hbs');
    });
}

handlers.getEdit = async function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.firstName = sessionStorage.getItem('firstName');
    ctx.lastName = sessionStorage.getItem('lastName');

    let id = ctx.params.id;
    let currentRecipe = await foodService.getRecipeById(id);

    ctx.recipeId = id;
    ctx.meal = currentRecipe.meal
    ctx.prepMethod = currentRecipe.prepMethod
    ctx.description = currentRecipe.description
    ctx.ingredients = currentRecipe.ingredients.join(' ');
    ctx.foodImageURL = currentRecipe.foodImageURL
    ctx.category = currentRecipe.category

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
    }).then(function () {
        this.partial('views/food/editRecipe.hbs');
    });

}

handlers.postEdit = async function (ctx) {

    foodService.editRecipe(ctx).then((res) => {

        notify.showInfo(`Yoy edited your recipe`);
        
        ctx.redirect('#/home');
      }).catch(function (err) {
        notify.handleError(err)
      });
}

handlers.getArchive = async function (ctx) {
    let id = ctx.params.id;

    foodService.archiveRecipe(id).then((res) => {

        notify.showInfo('Your recipe was archived.');

        ctx.redirect('#/home');
    }).catch(function (err) {
        notify.handleError(err)
    });

}

handlers.getLike = async function (ctx) {
    let id = ctx.params.id;

    let currentRecipe = await foodService.getRecipeById(id);
    foodService.likeRecipe(currentRecipe).then((res) => {
  
      notify.showInfo(`You liked that recipe.`);
  
      ctx.redirect('#/home');
    }).catch(function (err) {
      notify.handleError(err)
    });
}