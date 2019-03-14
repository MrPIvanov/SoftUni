function focus() {
    let $inputs = $('div div input');

    $inputs.on('focus', onFocus);
    $inputs.on('blur', onBlur);

    function onFocus(e) {
        $(e.target).parent().addClass('focused');
    }

    function onBlur(e) {
        $(e.target).parent().removeClass('focused');
    }
}