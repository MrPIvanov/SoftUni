function solve(n) {
    let total = n*n;
    let result= [];
 
    for(let i = 0; i < n; i++) {
        let current = [];
        for(let j = 0; j < n; j++) {
            current.push(0);
        }   
        result.push(current);
    }
    
    let x=0;
    let y=0;
    let step = 0;

    //Fill the matrix. It is not my solution!!!
    for(let i = 0; i < total;){
        while(y + step < n){
            i++;
            result[x][y]=i; 
            y++;
 
        }    
        y--;
        x++;
        
        while(x+step<n){
            i++;
            result[x][y]=i;
            x++;
        }
        x--;
        y--;
         
        while(y>=step){
            i++;
            result[x][y]=i;
            y--;
        }
        y++;
        x--;
        step++;
         
        while(x>=step){
            i++;
            result[x][y]=i;
            x--;
        }
        x++;
        y++;
    }

    //print the matrix
    for (let row = 0; row < n; row++) {
        console.log(result[row].join(' '));
    }
}

//solve(5, 5);