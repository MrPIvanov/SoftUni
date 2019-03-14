function validate() {
    let $emailInput = $('#email');
    $emailInput.on('change', validateEmail);

    function validateEmail() {
        let validPattern = /^([a-zA-Z])+@([a-zA-Z])+\.([a-zA-Z])+$/gm;

        let inputText = $emailInput.val();

        if (validPattern.test(inputText)) {
            $emailInput.removeClass('error');
        } else {
            $emailInput.addClass('error');
        }
    }
}