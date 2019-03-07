function solve(input) {
    let collection = {};
    let processor = {
        create: function (tokens) {
            if (tokens.length > 1) {
                let current = {
                    name: tokens[0]
                };

                Object.setPrototypeOf(current, collection[tokens[2]]);
                collection[tokens[0]] = current;
            } else {
                collection[tokens[0]] = {
                    name: tokens[0]
                };
            }
        },
        set: function(tokens){
            collection[tokens[0]][tokens[1]] = tokens[2];
        },
        print: function(tokens){
            let result = [];
            for (const property in collection[tokens[0]]) {
                if (property !== 'name') {
                    result.push(`${property}:${collection[tokens[0]][property]}`);
                }
            }
            console.log(result.join(', '));
        }
    };

    for (const line of input) {
        let [command, ...tokens] = line.split(' ');
        processor[command](tokens);
    }
}

// solve(['create c1',
//     'create c2 inherit c1',
//     'set c1 color red',
//     'set c2 model new',
//     'print c1',
//     'print c2'
// ]);