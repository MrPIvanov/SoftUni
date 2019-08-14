function solution(day, service, hour){

    let price;

    if(service === 'Fitness'){
        switch(day){
            case 'Monday': hour <= 15 ? price = 5 : price = 7.5; break; 
            case 'Tuesday': hour <= 15 ? price = 5 : price = 7.5; break; 
            case 'Wednesday': hour <= 15 ? price = 5 : price = 7.5; break; 
            case 'Thursday': hour <= 15 ? price = 5 : price = 7.5; break; 
            case 'Friday': hour <= 15 ? price = 5 : price = 7.5; break; 
            case 'Saturday': hour <= 15 ? price = 8 : price = 8; break; 
            case 'Sunday': hour <= 15 ? price = 8 : price = 8; break; 
        }
    }
    else if(service === 'Sauna'){
        switch(day){
            case 'Monday': hour <= 15 ? price = 4 : price = 6.5; break; 
            case 'Tuesday': hour <= 15 ? price = 4 : price = 6.5; break; 
            case 'Wednesday': hour <= 15 ? price = 4 : price = 6.5; break; 
            case 'Thursday': hour <= 15 ? price = 4 : price = 6.5; break; 
            case 'Friday': hour <= 15 ? price = 4 : price = 6.5; break; 
            case 'Saturday': hour <= 15 ? price = 7 : price = 7; break; 
            case 'Sunday': hour <= 15 ? price = 7 : price = 7; break; 
        }
    }
    else{
        switch(day){
            case 'Monday': hour <= 15 ? price = 10 : price = 12.5; break; 
            case 'Tuesday': hour <= 15 ? price = 10 : price = 12.5; break; 
            case 'Wednesday': hour <= 15 ? price = 10 : price = 12.5; break; 
            case 'Thursday': hour <= 15 ? price = 10 : price = 12.5; break; 
            case 'Friday': hour <= 15 ? price = 10 : price = 12.5; break; 
            case 'Saturday': hour <= 15 ? price = 15 : price = 15; break; 
            case 'Sunday': hour <= 15 ? price = 15 : price = 15; break; 
        }
    }

    console.log(price);
}

//solution('Sunday', 'Fitness', 22.00);