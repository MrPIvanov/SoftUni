const foodService = (() => {
    
    function addRecipe(meal, ingredients, prepMethod, description, foodImageURL, category){
        let likesCounter = 0;
        let categoryImageURL = 'https://t3.ftcdn.net/jpg/01/18/84/52/240_F_118845283_n9uWnb81tg8cG7Rf9y3McWT1DT1ZKTDx.jpg';

        if (category === 'Vegetables and legumes/beans') {
            categoryImageURL = 'https://cdn.pixabay.com/photo/2017/10/09/19/29/eat-2834549__340.jpg';
        }
        if (category === 'Grain Food') {
            categoryImageURL = 'https://cdn.pixabay.com/photo/2014/12/11/02/55/corn-syrup-563796__340.jpg';
        }
        if (category === 'Fruits') {
            categoryImageURL = 'https://cdn.pixabay.com/photo/2017/06/02/18/24/fruit-2367029__340.jpg';
        }
        if (category === 'Milk, cheese, eggs and alternatives') {
            categoryImageURL = 'https://image.shutterstock.com/image-photo/assorted-dairy-products-milk-yogurt-260nw-530162824.jpg';
        }

        ingredients = ingredients.split(' ');
        return kinvey.post('appdata', 'recipes', 'kinvey', {
            meal,
            ingredients, 
            prepMethod, 
            description, 
            foodImageURL, 
            category,
            likesCounter,
            categoryImageURL
          });
    }

    function getAllRecipes(){
        return kinvey.get('appdata', 'recipes', 'kinvey')
    }

    function getRecipeById(id){
        return kinvey.get('appdata', `recipes/${id}`, 'kinvey');
    }

    function showRecipe(){

    }

    async function editRecipe(ctx){
        console.log(ctx)
        let id = ctx.params.id;
        debugger;

        let currentRecipe = await getRecipeById(id);

        console.log(currentRecipe);
        debugger;

        return kinvey.update('appdata', `recipes/${ctx.params.id}`, 'kinvey', currentRecipe);
    }

    function archiveRecipe(id){
        return kinvey.remove('appdata', `recipes/${id}`, 'kinvey');
    }

    function likeRecipe(currentRecipe){

        let newValue = (Number)(currentRecipe.likesCounter) + 1;
        currentRecipe.likesCounter = newValue; 

        return kinvey.update('appdata', `recipes/${currentRecipe._id}`, 'kinvey', currentRecipe);
    } 

    return {
        addRecipe,
        getAllRecipes,
        getRecipeById,
        showRecipe,
        editRecipe,
        archiveRecipe,
        likeRecipe
    }
})()