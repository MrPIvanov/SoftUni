handlers.getAllSongs = async function (ctx) {
  ctx.isAuth = userService.isAuth();
  ctx.username = sessionStorage.getItem('username');
  

  try {
    ctx.songs = await songService.getAllSongs();
  } catch (err) {
    notify.handleError(err)
  }

  ctx.songs.forEach((song) => song.isAuthor = song._acl.creator === sessionStorage.getItem('id'));

  ctx.mySongs = ctx.songs.filter(s => s.isAuthor === true).sort((a, b) => {

    if ((Number)(a.likes) < (Number)(b.likes)) {
      return 1;
    }
    if ((Number)(a.likes) > (Number)(b.likes)) {
      return -1;
    }
    if ((Number)(a.listen) < (Number)(b.listen)) {
      return 1;
    }
    if ((Number)(a.listen) > (Number)(b.listen)) {
      return -1;
    }
    return 0;
  })





  ctx.songs = ctx.songs.filter(s => s.isAuthor === false ).sort((a, b) => {
    if ((Number)(a.likes) < (Number)(b.likes)) {
      return 1;
    }
    if ((Number)(a.likes) > (Number)(b.likes)) {
      return -1;
    }
    return 0;
  })

  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs',
    song: '../views/song.hbs'
  }).then(function () {
    this.partial('../views/allSongs.hbs');
  })
}

handlers.getMySongs = async function(ctx){

  ctx.isAuth = userService.isAuth();
  ctx.username = sessionStorage.getItem('username');
  ctx.isAuthor = true;


  try {
    ctx.songs = await songService.getAllSongs();
  } catch (err) {
    notify.handleError(err)
  }

  ctx.songs = ctx
            .songs
            .filter(s => s._acl.creator === sessionStorage.getItem('id'));

  ctx.songs
  .forEach((song) => song.isAuthor = song._acl.creator === sessionStorage.getItem('id'));
  
  ctx.songs = ctx.songs.sort((a, b) => {

    if ((Number)(a.likes) < (Number)(b.likes)) {
      return 1;
    }
    if ((Number)(a.likes) > (Number)(b.likes)) {
      return -1;
    }
    if ((Number)(a.listen) < (Number)(b.listen)) {
      return 1;
    }
    if ((Number)(a.listen) > (Number)(b.listen)) {
      return -1;
    }
    return 0;
  });

  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs',
    songMy: '../views/songMy.hbs'
  }).then(function () {
    this.partial('../views/mySongs.hbs');
  })
}

handlers.getCreateSong = function (ctx) {
  ctx.isAuth = userService.isAuth();
  ctx.username = sessionStorage.getItem('username');


  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs',
  }).then(function () {
    this.partial('../views/createSong.hbs');
  })
}

handlers.removeSong = function (ctx) {
  let id = ctx.params.id;

  songService.removeSong(id).then((res) => {

    notify.showInfo('Song removed successfully!');

    ctx.redirect('#/allSongs');
  }).catch(function (err) {
    notify.handleError(err)
  });
}

handlers.removeSongMy = function (ctx) {
  let id = ctx.params.id;

  songService.removeSong(id).then((res) => {

    notify.showInfo('Song removed successfully!');

    ctx.redirect('#/mySongs');
  }).catch(function (err) {
    notify.handleError(err)
  });
}

handlers.listenSong = async function (ctx) {
  let id = ctx.params.id;


  let currentSong = await songService.getSongById(id);
  songService.listenSong(currentSong).then((res) => {

    notify.showInfo(`You just listened ${currentSong.title}`);



    ctx.redirect('#/allSongs');
  }).catch(function (err) {
    notify.handleError(err)
  });
}

handlers.listenSongMy = async function (ctx) {
  let id = ctx.params.id;


  let currentSong = await songService.getSongById(id);
  songService.listenSong(currentSong).then((res) => {

    notify.showInfo(`You just listened ${currentSong.title}`);



    ctx.redirect('#/mySongs');
  }).catch(function (err) {
    notify.handleError(err)
  });
}

handlers.likeSong = async function (ctx) {
  let id = ctx.params.id;

  let currentSong = await songService.getSongById(id);
  songService.likeSong(currentSong).then((res) => {

    notify.showInfo(`Liked!`);

    ctx.redirect('#/allSongs');
  }).catch(function (err) {
    notify.handleError(err)
  });
}

handlers.postSong = function (ctx) {
  let title = ctx.params.title;
  let artist = ctx.params.artist;
  let imageURL = ctx.params.imageURL;

  if (title.length < 6) {
    notify.showError("The title should be at least 6 characters long");
    return;
  }
  if (artist.length < 3) {
    notify.showError('The artist should be at least 3 characters long');
    return;
  }
  if (!imageURL.startsWith('http')) {
    notify.showError('The image should start with "http://" or "https://"');
    return;
  }

  songService.addSong(title, artist, imageURL).then((res) => {

    notify.showInfo('Song created successfully.');

    ctx.redirect('#/allSongs');
  }).catch(function (err) {
    notify.handleError(err)
  });

}