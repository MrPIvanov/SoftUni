function solve(input) {
    let collection = [];
    let processor = {
        add: function (element) {
            collection.push(element);
        },
        remove: function (element) {
            collection = collection.filter(x => x !== element);
        },
        print: function () {
            console.log(collection.join(','));
        }
    };

    for (const item of input) {
        processor[item.split(' ')[0]](item.split(' ')[1]);
    }
}

//solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);
//solve(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']);