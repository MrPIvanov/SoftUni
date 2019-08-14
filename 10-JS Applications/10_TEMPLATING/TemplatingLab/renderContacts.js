function showDetails (id){
    $(`#${id}`).toggle();
}

$(async function() {
    try {
        let contactInfoHtml = await $.get('./contact-info.hbs'); //Get The Data
        let contactListHtml = await $.get('./contacts-list.hbs'); //Get The Data
    
        Handlebars.registerPartial('contactInfo', contactInfoHtml); //partial templating registration

        let template = Handlebars.compile(contactListHtml); //create the main template

        let contex = {          //add the data we use as obj {}
            contacts
        };

        let finishedHtml = template(contex); //make the ready HTML

        $('body').append(finishedHtml); //append the HTML

    } catch (error) {
        console.log(error);
    }
});