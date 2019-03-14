function stopWatch() {
    let isRunning = false;
    let interval;
    let $start = $('#startBtn');
    let $stop = $('#stopBtn');
    let $timer = $('#time');

    $start.on('click', startWatch);
    $stop.on('click', endWatch);

    function startWatch() {
        $timer.text('00:00');
        isRunning = true;
        $start.attr('disabled', isRunning);
        $stop.attr('disabled', !isRunning);
        let sec = 0;

        interval = setInterval(function () {
            sec++;
            let displayMin = Math.floor(sec / 60);
            let displaySec = sec % 60;

            $timer.text(`${addZero(displayMin)}:${addZero(displaySec)}`);
        }, 1000);
    }

    function endWatch() {
        isRunning = false;
        $start.attr('disabled', isRunning);
        $stop.attr('disabled', !isRunning);

        clearInterval(interval);
    }

    function addZero(time) {
        if (time < 10) {
            time = "0" + time;
        }

        return time;
    }
}