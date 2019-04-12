const songService = (() => {
    function getAllSongs() {
        return kinvey.get('appdata', 'songs', 'kinvey')
    }

    function addSong(title, artist, imageURL){
        let likes = 0;
        let listen = 0;

        return kinvey.post('appdata', 'songs', 'kinvey', {
            title,
            artist,
            imageURL,
            likes,
            listen
          });
    }

    function removeSong(id){
        return kinvey.remove('appdata', `songs/${id}`, 'kinvey');
    }

    function listenSong(currentSong){
        let newValue = (Number)(currentSong.listen) + 1;
        currentSong.listen = newValue; 
     
        return kinvey.update('appdata', `songs/${currentSong._id}`, 'kinvey', currentSong);
    }

    function likeSong(currentSong){
        let newValue = (Number)(currentSong.likes) + 1;
        currentSong.likes = newValue; 
        
        return kinvey.update('appdata', `songs/${currentSong._id}`, 'kinvey', currentSong);
    }

    function getSongById(id){
        return kinvey.get('appdata', `songs/${id}`, 'kinvey');
    }

    return {
        getAllSongs,
        addSong,
        removeSong,
        listenSong,
        getSongById,
        likeSong
    }
})()