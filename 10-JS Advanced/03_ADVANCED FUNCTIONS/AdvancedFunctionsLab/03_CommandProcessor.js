function result(arr) {

    let text = '';

    let commands = {
        append: (str) => text = text + str,
        removeStart: (n) => text = text.slice(n),
        removeEnd: (n) => text = text.slice(0, n * -1),
        print: () => console.log(text)
    };

    for (const iterator of arr) {
        let tokens = iterator.split(' ');

        if (tokens.length > 0) {
            commands[tokens[0]](tokens[1]);
        } else {
            commands[tokens[0]]();
        }
    }
}

//result(['append hello',
//'append again',
//'removeStart 3',
//'removeEnd 4',
//'print']
//);