function solve(arr) {
    let resultText = [];

    for (let index = 0; index < arr.length; index++) {
        let valid = true;
        let line = arr[index];
        if (line[0] === '<' && line[line.length - 1] === '>') {

            let openTagNames = [];
            let openTags = [];
            openTags = line.match(/<\w+>/g);
            if(openTags !== null){
                openTagNames = openTags.map(x => x.slice(1, -1));
            }
            else{
                valid = false;
            }

            let closeTagNames = [];
            let closeTags = [];
            closeTags = line.match(/<\/\w+>/g);

            if(closeTags !== null){
                closeTagNames = closeTags.map(x => x.slice(2, -1));
            }
            else{
                valid = false;
            }

            while (openTagNames.length > 0 && closeTagNames.length > 0) {
                if(openTagNames.length !== closeTagNames.length){
                    valid = false;
                    break;
                }
                else{
                    if (openTagNames.length > 0 && closeTagNames.length > 0) {

                        let openTag = openTagNames.pop();
                        let closeTag = closeTagNames.shift();

                        if (openTag !== closeTag) {
                            valid = false;
                            break;
                        }
                    }
                }
            }
            if (valid) {
                let regExForCorectLine = /<\/?\w+((\s+\w+(\s*=\s*(?:\".*?"|'.*?'|[^'\">\s]+))?)+\s*|\s*)\/?>/gi;
                resultText.push(line.replace(regExForCorectLine, ''));
            }
        }
    }
    console.log(resultText.join(' '));
}

// solve(['<h1><p>te <p >    st</p></h1>']
// );

// solve(['<h1><span>Hello World!</span></h1>',
// '<p>I am Peter.']
// );