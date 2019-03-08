function attachEvents() {
    $('.button').on('click', btnClick);

    function btnClick(e){
        $('.button').removeClass('selected');
        this.classList.add("selected");
    }
}