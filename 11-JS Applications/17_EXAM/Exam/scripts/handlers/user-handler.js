handlers.getRegister = function (ctx) {
  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs'
  }).then(function () {
    this.partial('../views/user/register.hbs');
  });
}

handlers.getLogin = function (ctx) {
  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs'
  }).then(function () {
    this.partial('../views/user/login.hbs');
  });
}

handlers.registerUser = function (ctx) {
  let username = ctx.params.username;
  let firstName = ctx.params.firstName;
  let lastName = ctx.params.lastName;
  let password = ctx.params.password;
  let repeatPassword = ctx.params.repeatPassword;

  if (firstName.length < 2) {
    notify.showError("The firstName should be at least 2 characters long");
    return;
  }
  if (lastName.length < 2) {
    notify.showError("The lastName should be at least 2 characters long");
    return;
  }
  if (username.length < 3) {
    notify.showError("The username should be at least 3 characters long");
    return;
  }
  if (password.length < 6) {
    notify.showError('The password should be at least 6 characters long');
    return;
  }
  if (password !== repeatPassword) {
    notify.showError('The repeat password should be equal to the password');
    return;
  }
  
  userService.register(username, password, firstName, lastName).then((res) => {
    userService.saveSession(res);

    notify.showInfo('User registration successful.');   

    ctx.redirect('#/home');
  }).catch(function (err) {

    notify.handleError(err);
  });
}

handlers.logoutUser = function (ctx) {
  userService.logout().then(() => {
    sessionStorage.clear();

    notify.showInfo('Logout successful.');

    ctx.redirect('#/home');
  })
}

handlers.loginUser = function (ctx) {
  let username = ctx.params.username;
  let password = ctx.params.password;
  userService.login(username, password).then((res) => {
    userService.saveSession(res);

    notify.showInfo('Login successful.');

    ctx.redirect('#/home');
  }).catch(function (err) {
    notify.handleError(err);
  });
}