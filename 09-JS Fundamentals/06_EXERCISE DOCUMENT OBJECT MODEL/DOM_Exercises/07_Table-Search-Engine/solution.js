function solve() {
    
    let btn = document.getElementById('searchBtn');

    btn.addEventListener('click', function (){
        let text = document.getElementById('searchField');
        let input = text.value.toLowerCase();
        text.value = "";

        let elements = document.querySelectorAll('#exercise table tbody tr');

        for (const ele of elements) {
            let str = '';
            let innerEle = Array.from(ele.children);
            innerEle.forEach(el => {
                str += el.textContent.toLowerCase();
            });

            ele.className = '';

            if(str.includes(input)){
                ele.className += 'select';
            }
        }
    });
}