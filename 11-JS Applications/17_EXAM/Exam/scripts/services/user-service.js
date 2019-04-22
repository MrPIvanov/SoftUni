const userService = (() => {
  function isAuth() {
    return sessionStorage.getItem('authtoken') !== null;
  }

  function saveSession(res) {
    sessionStorage.setItem('username', res.username);
    sessionStorage.setItem('firstName', res.firstName);
    sessionStorage.setItem('lastName', res.lastName);
    sessionStorage.setItem('authtoken', res._kmd.authtoken);
    sessionStorage.setItem('id', res._id);  //Not sure if i gona need it
  }

  function register(username, password, firstName, lastName) {
    return kinvey.post('user', '', 'basic', {
      username,
      password,
      firstName,
      lastName
    })
  }

  function login(username, password) {
    return kinvey.post('user', 'login', 'basic', {
      username,
      password
    });
  }

  function logout() {
    return kinvey.post('user', '_logout', 'kinvey');
  }

  return {
    register,
    login,
    logout,
    saveSession,
    isAuth
  }
})()