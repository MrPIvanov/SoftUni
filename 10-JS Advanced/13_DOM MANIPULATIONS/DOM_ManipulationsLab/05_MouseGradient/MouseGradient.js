function attachGradientEvents() {
    let $gradient = $('#gradient');
    let $result = $('#result');

    $gradient.on('mousemove', function (e) {
        let temp = (+e.offsetX) / +$gradient[0].clientWidth;
        
        let percentage = Math.floor(temp * 100);

        $result.text(percentage + '%');
    });
}